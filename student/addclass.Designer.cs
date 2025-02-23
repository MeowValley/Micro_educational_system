namespace Satelliteeducationsystem.student
{
    partial class addclass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addclass));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new AntdUI.Button();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.button2 = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 25);
            this.textBox1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(173, 152);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "如何获得班级编号？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(22)))));
            this.button1.Location = new System.Drawing.Point(40, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认加入";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.uiLabel1.Location = new System.Drawing.Point(12, 43);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(191, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "请输入班级编号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(22)))));
            this.button2.Location = new System.Drawing.Point(271, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "返回";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 176);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "加入班级";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private AntdUI.Button button1;
        private Sunny.UI.UILabel uiLabel1;
        private AntdUI.Button button2;
    }
}