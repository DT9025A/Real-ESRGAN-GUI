using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lpgui
{
    public partial class FormConfig : Form
    {
        TaskConfig TaskConfig;

        public FormConfig(ref TaskConfig config)
        {
            InitializeComponent();
            TaskConfig = config;
        }

        private void FromConfig_Load(object sender, EventArgs e)
        {
            if (TaskConfig.Scale == 2)
            {
                comboBox_Scale.SelectedIndex = 0;
            }
            else
            {
                comboBox_Scale.SelectedIndex = 1;
            }
            textBox_TileSize.Text = TaskConfig.TileSize.ToString();
            comboBox_OutputFormat.SelectedIndex = (int)TaskConfig.Output;
            textBox_GPUID.Text = TaskConfig.GPU_ID;
            textBox_LPS.Text = TaskConfig.Load_Proc_Save;
            checkBox_TTA.Checked = TaskConfig.TTA;
        }

        private void FromConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            TaskConfig.Scale = Convert.ToInt32(comboBox_Scale.SelectedItem);
            TaskConfig.TileSize = Convert.ToInt32(textBox_TileSize.Text);
            TaskConfig.Output = (TaskConfig.OutputFormat)comboBox_OutputFormat.SelectedIndex;
            TaskConfig.GPU_ID = textBox_GPUID.Text;
            TaskConfig.Load_Proc_Save = textBox_LPS.Text;
            TaskConfig.TTA = checkBox_TTA.Checked;
        }
    }
}
