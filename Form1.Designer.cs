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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            tabPage2 = new TabPage();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(51, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(581, 425);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(573, 395);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "重启";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(419, 340);
            button2.Name = "button2";
            button2.Size = new Size(98, 36);
            button2.TabIndex = 4;
            button2.Text = "导出";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(49, 340);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 3;
            button1.Text = "开始";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(468, 219);
            textBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(162, 30);
            numericUpDown1.Maximum = new decimal(new int[] { 21, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 25);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "重启次数：";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(573, 395);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "更多";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 483);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(696, 22);
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(696, 25);
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
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 505);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "调试工具";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button2;
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
    }
}