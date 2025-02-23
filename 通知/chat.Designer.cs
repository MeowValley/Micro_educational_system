namespace Satelliteeducationsystem.通知
{
    partial class chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.rtbContent = new Sunny.UI.UIRichTextBox();
            this.rtbSend = new Sunny.UI.UIRichTextBox();
            this.txtIP = new Sunny.UI.UITextBox();
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.txtName = new Sunny.UI.UITextBox();
            this.button1 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.button3 = new AntdUI.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flist = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbContent.BackColor = System.Drawing.Color.Transparent;
            this.rtbContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rtbContent.FillColor = System.Drawing.Color.White;
            this.rtbContent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbContent.Location = new System.Drawing.Point(-2, 0);
            this.rtbContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbContent.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Padding = new System.Windows.Forms.Padding(2);
            this.rtbContent.ShowText = false;
            this.rtbContent.Size = new System.Drawing.Size(1112, 536);
            this.rtbContent.Style = Sunny.UI.UIStyle.Custom;
            this.rtbContent.TabIndex = 0;
            this.rtbContent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rtbContent.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rtbSend
            // 
            this.rtbSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbSend.FillColor = System.Drawing.Color.White;
            this.rtbSend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbSend.Location = new System.Drawing.Point(-2, 555);
            this.rtbSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Padding = new System.Windows.Forms.Padding(2);
            this.rtbSend.ShowText = false;
            this.rtbSend.Size = new System.Drawing.Size(1112, 112);
            this.rtbSend.Style = Sunny.UI.UIStyle.Custom;
            this.rtbSend.TabIndex = 1;
            this.rtbSend.Text = "请在此键入内容（按Ctrl+Enter或者发送即可）";
            this.rtbSend.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rtbSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.rtbSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbSend_MouseDown);
            this.rtbSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbSend_KeyDown);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Transparent;
            this.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(198, 681);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIP.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtIP.Name = "txtIP";
            this.txtIP.ShowText = false;
            this.txtIP.Size = new System.Drawing.Size(192, 29);
            this.txtIP.TabIndex = 2;
            this.txtIP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtIP.Watermark = "";
            this.txtIP.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(75, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "对方主机：";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(418, 684);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "昵称：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(495, 681);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(192, 29);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            this.txtName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(255)))), ((int)(((byte)(167)))));
            this.button1.Location = new System.Drawing.Point(735, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "清屏";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(22)))));
            this.button2.Location = new System.Drawing.Point(858, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "发送";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(22)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(979, 675);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "关闭";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flist
            // 
            this.flist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flist.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.flist.Location = new System.Drawing.Point(272, 718);
            this.flist.Name = "flist";
            this.flist.Size = new System.Drawing.Size(601, 51);
            this.flist.TabIndex = 8;
            this.flist.Text = "怕记不住或者忘记了好友IP，点我试试？";
            this.flist.Click += new System.EventHandler(this.flist_Click);
            this.flist.MouseEnter += new System.EventHandler(this.flist_MouseEnter);
            this.flist.MouseLeave += new System.EventHandler(this.flist_MouseLeave);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 768);
            this.Controls.Add(this.flist);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSend);
            this.Controls.Add(this.rtbContent);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "聊天";
            this.Load += new System.EventHandler(this.chat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRichTextBox rtbContent;
        private Sunny.UI.UIRichTextBox rtbSend;
        private Sunny.UI.UITextBox txtIP;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private Sunny.UI.UITextBox txtName;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private System.Windows.Forms.Timer timer1;
        private AntdUI.Button flist;
    }
}