
namespace lpgui
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Scale = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TileSize = new System.Windows.Forms.TextBox();
            this.comboBox_OutputFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_GPUID = new System.Windows.Forms.TextBox();
            this.textBox_LPS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_TTA = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "放大比例";
            // 
            // comboBox_Scale
            // 
            this.comboBox_Scale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Scale.FormattingEnabled = true;
            this.comboBox_Scale.Items.AddRange(new object[] {
            "2",
            "4"});
            this.comboBox_Scale.Location = new System.Drawing.Point(71, 6);
            this.comboBox_Scale.Name = "comboBox_Scale";
            this.comboBox_Scale.Size = new System.Drawing.Size(57, 20);
            this.comboBox_Scale.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "分割尺寸";
            // 
            // textBox_TileSize
            // 
            this.textBox_TileSize.Location = new System.Drawing.Point(71, 36);
            this.textBox_TileSize.Name = "textBox_TileSize";
            this.textBox_TileSize.Size = new System.Drawing.Size(57, 21);
            this.textBox_TileSize.TabIndex = 3;
            // 
            // comboBox_OutputFormat
            // 
            this.comboBox_OutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OutputFormat.FormattingEnabled = true;
            this.comboBox_OutputFormat.Items.AddRange(new object[] {
            "原始",
            "PNG",
            "JPG",
            "WEBP"});
            this.comboBox_OutputFormat.Location = new System.Drawing.Point(71, 63);
            this.comboBox_OutputFormat.Name = "comboBox_OutputFormat";
            this.comboBox_OutputFormat.Size = new System.Drawing.Size(57, 20);
            this.comboBox_OutputFormat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "输出格式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "GPUID";
            // 
            // textBox_GPUID
            // 
            this.textBox_GPUID.Location = new System.Drawing.Point(189, 5);
            this.textBox_GPUID.Name = "textBox_GPUID";
            this.textBox_GPUID.Size = new System.Drawing.Size(100, 21);
            this.textBox_GPUID.TabIndex = 7;
            // 
            // textBox_LPS
            // 
            this.textBox_LPS.Location = new System.Drawing.Point(189, 36);
            this.textBox_LPS.Name = "textBox_LPS";
            this.textBox_LPS.Size = new System.Drawing.Size(100, 21);
            this.textBox_LPS.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "l/p/s";
            // 
            // checkBox_TTA
            // 
            this.checkBox_TTA.AutoSize = true;
            this.checkBox_TTA.Location = new System.Drawing.Point(150, 67);
            this.checkBox_TTA.Name = "checkBox_TTA";
            this.checkBox_TTA.Size = new System.Drawing.Size(42, 16);
            this.checkBox_TTA.TabIndex = 10;
            this.checkBox_TTA.Text = "TTA";
            this.checkBox_TTA.UseVisualStyleBackColor = true;
            // 
            // FromConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 98);
            this.Controls.Add(this.checkBox_TTA);
            this.Controls.Add(this.textBox_LPS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_GPUID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_OutputFormat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_TileSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Scale);
            this.Controls.Add(this.label1);
            this.Name = "FromConfig";
            this.Text = "详细设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromConfig_FormClosing);
            this.Load += new System.EventHandler(this.FromConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Scale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TileSize;
        private System.Windows.Forms.ComboBox comboBox_OutputFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_GPUID;
        private System.Windows.Forms.TextBox textBox_LPS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_TTA;
    }
}