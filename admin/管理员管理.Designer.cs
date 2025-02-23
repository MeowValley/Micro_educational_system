namespace Satelliteeducationsystem.admin
{
    partial class 管理员管理
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminlist = new Sunny.UI.UIDataGridView();
            this.button1 = new AntdUI.Button();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminlist)).BeginInit();
            this.SuspendLayout();
            // 
            // adminlist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.adminlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adminlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.adminlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.adminlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adminlist.ColumnHeadersHeight = 32;
            this.adminlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.adminlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aid,
            this.aname,
            this.apassword,
            this.aidcard,
            this.aemail,
            this.aphone,
            this.state});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.adminlist.EnableHeadersVisualStyles = false;
            this.adminlist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.adminlist.Location = new System.Drawing.Point(0, 1);
            this.adminlist.Name = "adminlist";
            this.adminlist.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.adminlist.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.adminlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.adminlist.RowTemplate.Height = 27;
            this.adminlist.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.adminlist.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.adminlist.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.adminlist.SelectedIndex = -1;
            this.adminlist.Size = new System.Drawing.Size(1153, 511);
            this.adminlist.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.adminlist.Style = Sunny.UI.UIStyle.Purple;
            this.adminlist.TabIndex = 6;
            this.adminlist.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(31)))));
            this.button1.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(60, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1043, 86);
            this.button1.TabIndex = 7;
            this.button1.Text = "完成编辑？点我更新至数据库！";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aid
            // 
            this.aid.DataPropertyName = "aid";
            this.aid.HeaderText = "编号";
            this.aid.MinimumWidth = 6;
            this.aid.Name = "aid";
            // 
            // aname
            // 
            this.aname.DataPropertyName = "aname";
            this.aname.HeaderText = "姓名";
            this.aname.MinimumWidth = 6;
            this.aname.Name = "aname";
            // 
            // apassword
            // 
            this.apassword.DataPropertyName = "apassword";
            this.apassword.HeaderText = "密码";
            this.apassword.MinimumWidth = 6;
            this.apassword.Name = "apassword";
            // 
            // aidcard
            // 
            this.aidcard.DataPropertyName = "aidcard";
            this.aidcard.HeaderText = "身份证号";
            this.aidcard.MinimumWidth = 6;
            this.aidcard.Name = "aidcard";
            // 
            // aemail
            // 
            this.aemail.DataPropertyName = "aemail";
            this.aemail.HeaderText = "电子邮箱";
            this.aemail.MinimumWidth = 6;
            this.aemail.Name = "aemail";
            // 
            // aphone
            // 
            this.aphone.DataPropertyName = "aphone";
            this.aphone.HeaderText = "手机号";
            this.aphone.MinimumWidth = 6;
            this.aphone.Name = "aphone";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "状态";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            // 
            // 管理员管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminlist);
            this.Name = "管理员管理";
            this.Text = "管理员管理";
            this.Load += new System.EventHandler(this.管理员管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView adminlist;
        private AntdUI.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn aname;
        private System.Windows.Forms.DataGridViewTextBoxColumn apassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn aemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn aphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}