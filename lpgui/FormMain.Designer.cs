
namespace lpgui
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.progressBar_Progress = new System.Windows.Forms.ProgressBar();
            this.label_Percentage = new System.Windows.Forms.Label();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_OpenFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progressBar_Progress_Total = new System.Windows.Forms.ProgressBar();
            this.label_Percentage_Total = new System.Windows.Forms.Label();
            this.button_Config = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "输出";
            // 
            // textBox_Input
            // 
            this.textBox_Input.AllowDrop = true;
            this.textBox_Input.Location = new System.Drawing.Point(45, 10);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(419, 21);
            this.textBox_Input.TabIndex = 2;
            this.textBox_Input.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_Input_DragDrop);
            this.textBox_Input.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_Input_DragEnter);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(45, 35);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(419, 21);
            this.textBox_Output.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "输入文本框支持拖放！";
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(69, 63);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(233, 20);
            this.comboBox_Model.TabIndex = 5;
            this.comboBox_Model.SelectedIndexChanged += new System.EventHandler(this.comboBox_Model_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "处理模型";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(308, 62);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "开始！";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // textBox_Info
            // 
            this.textBox_Info.Enabled = false;
            this.textBox_Info.Location = new System.Drawing.Point(12, 89);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Info.Size = new System.Drawing.Size(581, 116);
            this.textBox_Info.TabIndex = 8;
            // 
            // progressBar_Progress
            // 
            this.progressBar_Progress.Location = new System.Drawing.Point(12, 211);
            this.progressBar_Progress.Name = "progressBar_Progress";
            this.progressBar_Progress.Size = new System.Drawing.Size(540, 23);
            this.progressBar_Progress.TabIndex = 9;
            // 
            // label_Percentage
            // 
            this.label_Percentage.AutoSize = true;
            this.label_Percentage.Location = new System.Drawing.Point(558, 219);
            this.label_Percentage.Name = "label_Percentage";
            this.label_Percentage.Size = new System.Drawing.Size(35, 12);
            this.label_Percentage.TabIndex = 10;
            this.label_Percentage.Text = "0.00%";
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(507, 9);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(86, 21);
            this.button_OpenFile.TabIndex = 11;
            this.button_OpenFile.Text = "选择文件";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "支持的文件|*.png;*.jpg;*.jpeg;*.webp";
            // 
            // button_OpenFolder
            // 
            this.button_OpenFolder.Location = new System.Drawing.Point(507, 35);
            this.button_OpenFolder.Name = "button_OpenFolder";
            this.button_OpenFolder.Size = new System.Drawing.Size(86, 21);
            this.button_OpenFolder.TabIndex = 12;
            this.button_OpenFolder.Text = "选择文件夹";
            this.button_OpenFolder.UseVisualStyleBackColor = true;
            this.button_OpenFolder.Click += new System.EventHandler(this.button_OpenFolder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "输\r\n入";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 247);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 12);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Real-ESRGAN(0.2.3.0)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // progressBar_Progress_Total
            // 
            this.progressBar_Progress_Total.Location = new System.Drawing.Point(141, 240);
            this.progressBar_Progress_Total.Name = "progressBar_Progress_Total";
            this.progressBar_Progress_Total.Size = new System.Drawing.Size(411, 23);
            this.progressBar_Progress_Total.TabIndex = 16;
            this.progressBar_Progress_Total.Visible = false;
            // 
            // label_Percentage_Total
            // 
            this.label_Percentage_Total.AutoSize = true;
            this.label_Percentage_Total.Location = new System.Drawing.Point(558, 247);
            this.label_Percentage_Total.Name = "label_Percentage_Total";
            this.label_Percentage_Total.Size = new System.Drawing.Size(35, 12);
            this.label_Percentage_Total.TabIndex = 17;
            this.label_Percentage_Total.Text = "0.00%";
            this.label_Percentage_Total.Visible = false;
            // 
            // button_Config
            // 
            this.button_Config.Location = new System.Drawing.Point(389, 62);
            this.button_Config.Name = "button_Config";
            this.button_Config.Size = new System.Drawing.Size(75, 22);
            this.button_Config.TabIndex = 18;
            this.button_Config.Text = "更多设置";
            this.button_Config.UseVisualStyleBackColor = true;
            this.button_Config.Click += new System.EventHandler(this.button_Config_Click);
            // 
            // Form_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 268);
            this.Controls.Add(this.button_Config);
            this.Controls.Add(this.label_Percentage_Total);
            this.Controls.Add(this.progressBar_Progress_Total);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_OpenFolder);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.label_Percentage);
            this.Controls.Add(this.progressBar_Progress);
            this.Controls.Add(this.textBox_Info);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Real-ESRGAN GUI";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.ProgressBar progressBar_Progress;
        private System.Windows.Forms.Label label_Percentage;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button_OpenFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar progressBar_Progress_Total;
        private System.Windows.Forms.Label label_Percentage_Total;
        private System.Windows.Forms.Button button_Config;
    }
}

