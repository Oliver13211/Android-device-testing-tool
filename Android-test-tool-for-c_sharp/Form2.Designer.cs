using System.Security.Policy;

namespace Android_test_tool_for_c_sharp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(680, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 523);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "关于本软件";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.工具;
            pictureBox1.Location = new Point(97, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 369);
            label6.Name = "label6";
            label6.Size = new Size(128, 17);
            label6.TabIndex = 3;
            label6.Text = "制作不易，感谢使用！";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 186);
            label5.Name = "label5";
            label5.Size = new Size(254, 17);
            label5.TabIndex = 2;
            label5.Text = "错误反馈请发邮件至：2995306790@qq.com";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 158);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 1;
            label4.Text = "作者：Oliver\r\n";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 127);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 0;
            label3.Text = "安卓设备测试工具";
            label3.Click += label3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(webView21);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(662, 523);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "帮助";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 17);
            webView21.Name = "webView21";
            webView21.Size = new Size(662, 506);
            webView21.Source = new Uri("file:///" + AppDomain.CurrentDomain.BaseDirectory + "help.html", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 547);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "关于";
            Load += Form2_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}