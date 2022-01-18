using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lpgui
{
    public class TaskConfig
    {
        /// <summary>
        /// 输出格式
        /// </summary>
        public enum OutputFormat
        {
            ORIGINAL = 0,
            PNG,
            JPG,
            WEBP
        }

        private int scale = 4;
        private int tile_size = 0;
        private OutputFormat output = OutputFormat.ORIGINAL;
        private String gpu_id = null;
        private String l_p_s = null;
        private bool tta = false;
        private String model = null;

        /// <summary>
        /// 向上放大比例
        /// </summary>
        public int Scale
        {
            get => scale; 
            
            set
            {
                if (value == 2)
                {
                    scale = 2;
                }
                else
                {
                    scale = 4;
                }
            }
        }

        /// <summary>
        /// 分割尺寸
        /// </summary>
        public int TileSize
        {
            get => tile_size; 
            
            set
            {
                if (value >= 32)
                {
                    tile_size = value;
                }
                else
                {
                    tile_size = 0;
                }
            }
        }

        /// <summary>
        /// 输出格式
        /// </summary>
        public OutputFormat Output { get => output; set => output = value; }

        /// <summary>
        /// 使用的GPU ID
        /// </summary>
        public String GPU_ID { get => gpu_id; set => gpu_id = value; }

        /// <summary>
        /// 加载/处理/保存的线程数
        /// </summary>
        public string Load_Proc_Save { get => l_p_s; set => l_p_s = value; }

        /// <summary>
        /// 允许TTA
        /// </summary>
        public bool TTA { get => tta; set => tta = value; }

        /// <summary>
        /// 使用的模型
        /// </summary>
        public string Model { get => model; set => model = value; }
    }
}
