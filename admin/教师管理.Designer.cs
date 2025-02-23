namespace Satelliteeducationsystem.admin
{
    partial class 教师管理
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
            this.button1 = new AntdUI.Button();
            this.teacherlist = new Sunny.UI.UIDataGridView();
            this.tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tidcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teacherlist)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(31)))));
            this.button1.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(25, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1087, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "完成编辑？点我更新至数据库！";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // teacherlist
            // 
            this.teacherlist.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.teacherlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.teacherlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.teacherlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.teacherlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.teacherlist.ColumnHeadersHeight = 32;
            this.teacherlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.teacherlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tid,
            this.tname,
            this.tpassword,
            this.tidcard,
            this.sex,
            this.temail,
            this.tphone,
            this.tage,
            this.cid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.teacherlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.teacherlist.EnableHeadersVisualStyles = false;
            this.teacherlist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teacherlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.teacherlist.Location = new System.Drawing.Point(1, 6);
            this.teacherlist.Name = "teacherlist";
            this.teacherlist.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.teacherlist.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.teacherlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.teacherlist.RowTemplate.Height = 27;
            this.teacherlist.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.teacherlist.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.teacherlist.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.teacherlist.SelectedIndex = -1;
            this.teacherlist.Size = new System.Drawing.Size(1153, 511);
            this.teacherlist.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.teacherlist.Style = Sunny.UI.UIStyle.Red;
            this.teacherlist.TabIndex = 5;
            this.teacherlist.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tid
            // 
            this.tid.DataPropertyName = "tid";
            this.tid.HeaderText = "编号";
            this.tid.MinimumWidth = 6;
            this.tid.Name = "tid";
            // 
            // tname
            // 
            this.tname.DataPropertyName = "tname";
            this.tname.HeaderText = "姓名";
            this.tname.MinimumWidth = 6;
            this.tname.Name = "tname";
            // 
            // tpassword
            // 
            this.tpassword.DataPropertyName = "tpassword";
            this.tpassword.HeaderText = "密码";
            this.tpassword.MinimumWidth = 6;
            this.tpassword.Name = "tpassword";
            // 
            // tidcard
            // 
            this.tidcard.DataPropertyName = "tidcard";
            this.tidcard.HeaderText = "身份证号";
            this.tidcard.MinimumWidth = 6;
            this.tidcard.Name = "tidcard";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            // 
            // temail
            // 
            this.temail.DataPropertyName = "temail";
            this.temail.HeaderText = "电子邮箱";
            this.temail.MinimumWidth = 6;
            this.temail.Name = "temail";
            // 
            // tphone
            // 
            this.tphone.DataPropertyName = "tphone";
            this.tphone.HeaderText = "手机号";
            this.tphone.MinimumWidth = 6;
            this.tphone.Name = "tphone";
            // 
            // tage
            // 
            this.tage.DataPropertyName = "tage";
            this.tage.HeaderText = "年龄";
            this.tage.MinimumWidth = 6;
            this.tage.Name = "tage";
            // 
            // cid
            // 
            this.cid.DataPropertyName = "cid";
            this.cid.HeaderText = "班级编号";
            this.cid.MinimumWidth = 6;
            this.cid.Name = "cid";
            // 
            // 教师管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teacherlist);
            this.Name = "教师管理";
            this.Text = "教师管理";
            this.Load += new System.EventHandler(this.教师管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Button button1;
        private Sunny.UI.UIDataGridView teacherlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn tid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn temail;
        private System.Windows.Forms.DataGridViewTextBoxColumn tphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn tage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
    }
}