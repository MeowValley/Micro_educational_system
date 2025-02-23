namespace Satelliteeducationsystem
{
    partial class code
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
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new AntdUI.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "您当前正在注册的身份为：";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "请键入您的密钥：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(208, 237);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 25);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "密钥说明？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.button1.Location = new System.Drawing.Point(62, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 25);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.button2.Location = new System.Drawing.Point(322, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "返回";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 271);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "code";
            this.Text = "密钥";
            this.Load += new System.EventHandler(this.code_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private AntdUI.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private AntdUI.Button button2;
    }
}