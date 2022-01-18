using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace lpgui
{
    class TaskProcess
    {
        private readonly TaskConfig config;
        private readonly DataReceivedEventHandler dataEventHandler;
        private readonly EventHandler exitEventHandler;
        private String inputPath;
        private String outputPath;
        private Process process = null;

        /// <summary>
        /// 构造执行的对象
        /// </summary>
        /// <param name="Config">使用的设置</param>
        /// <param name="DataEventHandler">数据处理入口</param>
        public TaskProcess(TaskConfig Config, DataReceivedEventHandler DataEventHandler, EventHandler ExitEventHandler)
        {
            config = Config;
            dataEventHandler = DataEventHandler;
            exitEventHandler = ExitEventHandler;
        }

        /// <summary>
        /// 更新要操作的文件信息
        /// </summary>
        /// <param name="InputPath">输入文件路径</param>
        /// <param name="OutputPath">输出文件路径</param>
        public void UpdateFile(String InputPath, String OutputPath)
        {
            inputPath = InputPath;
            outputPath = OutputPath;
        }

        /// <summary>
        /// 启动执行进程
        /// </summary>
        /// <returns>是否成功执行</returns>
        public bool StartProcess()
        {
            if (process == null)
            {
                String arg, format = null;
                if (config.Model == null)
                {
                    return false;
                }
                // 输出格式
                switch (config.Output)
                {
                    case TaskConfig.OutputFormat.PNG:
                        format = "png";
                        break;
                    case TaskConfig.OutputFormat.JPG:
                        format = "jpg";
                        break;
                    case TaskConfig.OutputFormat.WEBP:
                        format = "webp";
                        break;
                    default:
                        format = "ext";
                        break;
                }
                if (!format.Equals("ext"))
                {
                    outputPath = outputPath.Substring(0, outputPath.LastIndexOf(".")) + "." + format;
                }
                arg = String.Format("-i \"{0}\" -o \"{1}\" -n {2} -s {3} -f {4}",
                    inputPath, outputPath, config.Model, config.Scale, format);
                // 使用自定义GPUID
                if (config.GPU_ID != null && config.GPU_ID != string.Empty)
                {
                    arg += " -g " + config.GPU_ID;
                }
                // 使用自定义load:proc:save
                if (config.Load_Proc_Save != null && config.Load_Proc_Save != string.Empty)
                {
                    arg += " -j " + config.Load_Proc_Save;
                }
                // 使用自定义的分割大小
                if (config.TileSize != 0)
                {
                    arg += " -t " + config.TileSize;
                }
                // 使用TTA
                if (config.TTA)
                {
                    arg += " -x";
                }

                process = new Process();
                process.StartInfo.FileName = "realesrgan-ncnn-vulkan.exe";
                process.StartInfo.Arguments = arg;

                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.OutputDataReceived += dataEventHandler;
                process.ErrorDataReceived += dataEventHandler;

                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(Exit);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            process = null;
            exitEventHandler(null, null);
        }

        public void StopProcess()
        {
            if (process != null)
            {
                process.Kill();
            }
        }
    }
}
