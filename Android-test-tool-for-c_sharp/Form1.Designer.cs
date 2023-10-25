namespace Android_test_tool_for_c_sharp
{
    partial class Form1
    {
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(40, 56);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 3;
            button1.Text = "开始";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(113, 27);
            numericUpDown1.Maximum = new decimal(new int[] { 21, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 412);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(860, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(56, 17);
            toolStripStatusLabel1.Text = "准备就绪";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(860, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.关于;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "关于";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.avgvq_w6rmb_001;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "导出";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "重启次数：";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(437, 353);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(411, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 381);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "输出内容";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "重启";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 434);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "调试工具";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDown1;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStripButton toolStripButton2;
    }
}