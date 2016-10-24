namespace ProDebugTool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPot = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelinfo = new System.Windows.Forms.Label();
            this.groupdata = new System.Windows.Forms.GroupBox();
            this.grouprecive = new System.Windows.Forms.GroupBox();
            this.textBre = new System.Windows.Forms.TextBox();
            this.groupBoxconfig = new System.Windows.Forms.GroupBox();
            this.checkBoxhex = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grouprecive.SuspendLayout();
            this.groupBoxconfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "协议类型";
            // 
            // comboBoxPro
            // 
            this.comboBoxPro.FormattingEnabled = true;
            this.comboBoxPro.Items.AddRange(new object[] {
            "TCP Server",
            "UDP Server",
            "TCP Clint",
            "UDP Clint"});
            this.comboBoxPro.Location = new System.Drawing.Point(85, 25);
            this.comboBoxPro.Name = "comboBoxPro";
            this.comboBoxPro.Size = new System.Drawing.Size(100, 20);
            this.comboBoxPro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP地址";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(85, 67);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 21);
            this.textBoxIP.TabIndex = 4;
            // 
            // textBoxPot
            // 
            this.textBoxPot.Location = new System.Drawing.Point(85, 108);
            this.textBoxPot.Name = "textBoxPot";
            this.textBoxPot.Size = new System.Drawing.Size(69, 21);
            this.textBoxPot.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(79, 172);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 30);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "启动服务";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.labelinfo);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPot);
            this.groupBox1.Controls.Add(this.comboBoxPro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 222);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP地址和端口号";
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelinfo.ForeColor = System.Drawing.Color.Cyan;
            this.labelinfo.Location = new System.Drawing.Point(67, 150);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(0, 14);
            this.labelinfo.TabIndex = 7;
            // 
            // groupdata
            // 
            this.groupdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupdata.AutoSize = true;
            this.groupdata.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupdata.Location = new System.Drawing.Point(228, 12);
            this.groupdata.Name = "groupdata";
            this.groupdata.Size = new System.Drawing.Size(617, 219);
            this.groupdata.TabIndex = 8;
            this.groupdata.TabStop = false;
            this.groupdata.Text = "数据区域";
            // 
            // grouprecive
            // 
            this.grouprecive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grouprecive.AutoSize = true;
            this.grouprecive.Controls.Add(this.textBre);
            this.grouprecive.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grouprecive.Location = new System.Drawing.Point(14, 232);
            this.grouprecive.Name = "grouprecive";
            this.grouprecive.Size = new System.Drawing.Size(484, 313);
            this.grouprecive.TabIndex = 9;
            this.grouprecive.TabStop = false;
            this.grouprecive.Text = "接收区域";
            // 
            // textBre
            // 
            this.textBre.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBre.ForeColor = System.Drawing.Color.Yellow;
            this.textBre.Location = new System.Drawing.Point(3, 17);
            this.textBre.Multiline = true;
            this.textBre.Name = "textBre";
            this.textBre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBre.Size = new System.Drawing.Size(478, 293);
            this.textBre.TabIndex = 0;
            this.textBre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxconfig
            // 
            this.groupBoxconfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxconfig.Controls.Add(this.buttonClear);
            this.groupBoxconfig.Controls.Add(this.checkBoxhex);
            this.groupBoxconfig.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxconfig.Location = new System.Drawing.Point(504, 232);
            this.groupBoxconfig.Name = "groupBoxconfig";
            this.groupBoxconfig.Size = new System.Drawing.Size(344, 313);
            this.groupBoxconfig.TabIndex = 10;
            this.groupBoxconfig.TabStop = false;
            this.groupBoxconfig.Text = "配置区域";
            // 
            // checkBoxhex
            // 
            this.checkBoxhex.AutoSize = true;
            this.checkBoxhex.Location = new System.Drawing.Point(6, 38);
            this.checkBoxhex.Name = "checkBoxhex";
            this.checkBoxhex.Size = new System.Drawing.Size(96, 16);
            this.checkBoxhex.TabIndex = 0;
            this.checkBoxhex.Text = "十六进制显示";
            this.checkBoxhex.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 60);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 30);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "清除显示";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 554);
            this.Controls.Add(this.groupBoxconfig);
            this.Controls.Add(this.grouprecive);
            this.Controls.Add(this.groupdata);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Main";
            this.Text = "通讯协议调试助手(V1_0)";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grouprecive.ResumeLayout(false);
            this.grouprecive.PerformLayout();
            this.groupBoxconfig.ResumeLayout(false);
            this.groupBoxconfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPot;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupdata;
        private System.Windows.Forms.GroupBox grouprecive;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.TextBox textBre;
        private System.Windows.Forms.GroupBox groupBoxconfig;
        private System.Windows.Forms.CheckBox checkBoxhex;
        private System.Windows.Forms.Button buttonClear;
    }
}

