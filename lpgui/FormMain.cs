using System;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lpgui
{
    public partial class Form_Main : Form
    {
        private delegate void InfoUpdateDelegate(String info);
        /// <summary>
        /// 配置
        /// </summary>
        private TaskConfig taskConfig = new TaskConfig();
        /// <summary>
        /// 进程对象
        /// </summary>
        private TaskProcess taskProcess;
        /// <summary>
        /// 是否为多文件（文件夹）操作
        /// </summary>
        private bool isMultiFile = false;
        /// <summary>
        /// 多文件情况下的进度
        /// </summary>
        private float multiFileProcess = 0.0f;
        /// <summary>
        /// 多文件情况下的比例
        /// </summary>
        private float multiFileMultiply = 1.0f;
        /// <summary>
        /// 多文件列表
        /// </summary>
        private ArrayList fileList = new ArrayList();
        /// <summary>
        /// 文件下标
        /// </summary>
        private int fileIndex;

        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 更新控件的委托捏
        /// </summary>
        /// <param name="info">传入的信息</param>
        private void InfoUpdate(String info)
        {
            if (this.InvokeRequired)
            {
                Invoke(new InfoUpdateDelegate(InfoUpdate), new object[] { info });
            }
            else
            {
                if (info != null)
                {
                    if (info.Equals("BTN-STOP"))
                    {
                        button_Start.Text = "停止";
                    }
                    else if(info.Equals("INFO-CLR"))
                    {
                        textBox_Info.Clear();
                    }
                    else if (Regex.IsMatch(info, @"\d+.\d+%"))
                    {
                        label_Percentage.Text = info;
                        progressBar_Progress.Value = Convert.ToInt32(info.Substring(0, info.IndexOf(".")));
                        if (isMultiFile)
                        {
                            multiFileProcess = (fileIndex == 0 ? fileIndex : fileIndex - 1) * 100 * multiFileMultiply;
                            multiFileProcess += Convert.ToSingle(info.Substring(0, info.IndexOf("%"))) * multiFileMultiply;
                            progressBar_Progress_Total.Value = Convert.ToInt32(multiFileProcess);
                            label_Percentage_Total.Text = String.Format("{0:F2}%", multiFileProcess);
                        }
                    }
                    else
                    {
                        textBox_Info.AppendText(info + Environment.NewLine);
                        if (info.Equals("Finished."))
                        {
                            button_Start.Text = "开始";
                            progressBar_Progress_Total.Value = progressBar_Progress.Value = 0;
                            label_Percentage_Total.Text = label_Percentage.Text = "0.00%";
                            progressBar_Progress_Total.Visible = label_Percentage_Total.Visible = false;
                            DLLImports.MessageBeep(DLLImports.MB_ICONEXCLAMATION);
                            this.Cursor = Cursors.Default;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 文件名加上processed
        /// </summary>
        /// <param name="path">要处理的文件路径</param>
        /// <returns>处理后的文件路径</returns>
        private String ProcessFileName(String path)
        {
            return path.Substring(0, path.LastIndexOf(".")) + "(processed)" + path.Substring(path.LastIndexOf("."));
        }

        /// <summary>
        /// 窗口载入 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ArrayList files, model, param;
            String name;

            files = new ArrayList(new DirectoryInfo(Directory.GetCurrentDirectory() + "\\models").GetFiles());
            model = new ArrayList();
            param = new ArrayList();
            foreach (FileInfo item in files)
            {
                name = item.Name.Split(new char[] { '.' }, 2)[0];
                if (item.Extension.ToLower().Equals(".bin"))
                {
                    model.Add(name);
                }
                if (item.Extension.ToLower().Equals(".param"))
                {
                    param.Add(name);
                }
            }
            foreach (String item in model)
            {
                if (!param.Contains(item))
                {
                    model.Remove(item);
                }
            }
            comboBox_Model.Items.Clear();
            comboBox_Model.Items.AddRange(model.ToArray());
            comboBox_Model.SelectedIndex = 0;
            taskProcess = new TaskProcess(taskConfig, new DataReceivedEventHandler(Proc_OutputDataReceived), new EventHandler(Proc_Exited));
        }

        /// <summary>
        /// 拖放进入 配置光标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Input_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 拖放 处理拖放数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Input_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                String path;
                String[] files;

                path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                if (File.Exists(path))
                {
                    if (Regex.IsMatch(path.Substring(path.LastIndexOf(".")), "(png|jpg|jpeg|webp)"))
                    {
                        isMultiFile = false;
                        fileIndex = 0;
                        fileList.Clear();
                        textBox_Input.Text = path;
                        textBox_Output.Text = ProcessFileName(path);
                        textBox_Output.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("文件格式不支持", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (Directory.Exists(path))
                {
                    isMultiFile = true;
                    files = Directory.GetFiles(path);
                    fileList.Clear();
                    foreach (String file in files)
                    {
                        if (Regex.IsMatch(file.Substring(file.LastIndexOf(".")), "(png|jpg|jpeg|webp)"))
                        {
                            fileList.Add(file);
                        }
                    }
                    InfoUpdate(String.Format("添加了{0}个文件至列表", fileList.Count));
                    multiFileMultiply = 1.0f / fileList.Count;
                    fileIndex = fileList.Count;
                    if (path[path.Length - 1] != '/' && path[path.Length - 1] != '\\')
                    {
                        path += "\\";
                    }
                    textBox_Input.Text = path + "*.*";
                    textBox_Output.Text = path + "*(processed).*";
                    textBox_Output.Enabled = false;
                }
                else
                {
                    MessageBox.Show("文件或路径不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 开始/停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text.Equals("停止"))
            {
                taskProcess.StopProcess();
                if (isMultiFile)
                {
                    fileIndex = fileList.Count;
                }
            }
            else
            {
                if (isMultiFile)
                {
                    progressBar_Progress_Total.Visible = label_Percentage_Total.Visible = true;
                    fileIndex = 0;
                    Proc_Exited(null, null);
                }
                else
                {
                    if (File.Exists(textBox_Input.Text))
                    {
                        textBox_Info.Clear();
                        taskProcess.UpdateFile(textBox_Input.Text, textBox_Output.Text);
                        if (taskProcess.StartProcess())
                        {
                            InfoUpdate("处理文件: " + textBox_Input.Text);
                            button_Start.Text = "停止";
                        }
                        else
                        {
                            InfoUpdate("进程启动失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// 当前处理进程退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Proc_Exited(object sender, EventArgs e)
        {
            if (fileList.Count <= fileIndex)
            {
                InfoUpdate("Finished.");
            }
            else
            {
                if (File.Exists(fileList[fileIndex].ToString()))
                {
                    InfoUpdate("100.00%");
                    InfoUpdate("INFO-CLR");
                    taskProcess.UpdateFile(fileList[fileIndex].ToString(), ProcessFileName(fileList[fileIndex].ToString()));
                    fileIndex += 1;
                    if (taskProcess.StartProcess())
                    {
                        InfoUpdate("处理文件: " + textBox_Input.Text);
                        InfoUpdate("BTN-STOP");
                    }
                    else
                    {
                        InfoUpdate("进程启动失败");
                    }
                }
            }
        }

        /// <summary>
        /// 处理进程输出数据处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
                InfoUpdate(e.Data);
        }

        /// <summary>
        /// 点击链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/xinntao/Real-ESRGAN");
        }

        /// <summary>
        /// 载入设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Config_Click(object sender, EventArgs e)
        {
            FormConfig form = new FormConfig(ref taskConfig);
            form.ShowDialog(this);
        }

        /// <summary>
        /// 改变处理模型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskConfig.Model = comboBox_Model.SelectedItem.ToString();
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            MyDataObject dataObject = new MyDataObject();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataObject.Data = openFileDialog.FileName;
                textBox_Input_DragDrop(null, new DragEventArgs(dataObject, 0, 0, 0, DragDropEffects.All, DragDropEffects.All));
            }
        }

        /// <summary>
        /// 打开目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenFolder_Click(object sender, EventArgs e)
        {
            MyDataObject dataObject = new MyDataObject();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dataObject.Data = folderBrowserDialog.SelectedPath;
                textBox_Input_DragDrop(null, new DragEventArgs(dataObject, 0, 0, 0, DragDropEffects.All, DragDropEffects.All));
            }
        }
    }
}
