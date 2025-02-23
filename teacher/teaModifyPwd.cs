using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.teacher
{

    public partial class teaModifyPwd : Form
    {
        string username;
        public teaModifyPwd(string username)
        {
            InitializeComponent();
            label1.Text += username;
            this.username = username;
        }
        public teaModifyPwd()
        {
            InitializeComponent();
        }

        private void teaModifyPwd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prePwd.Text.Equals("") || newPwd.Text.Equals("") || confirmPwd.Text.Equals(""))
            {

                MessageBox.Show("以上字段不能为空！！", "WARNING", MessageBoxButtons.OK);
            }
            else
            {
                if (newPwd.Text.Equals(confirmPwd.Text) & Method.Modify_t_user_password(prePwd.Text, username, newPwd.Text))
                {
                    MessageBox.Show("密码修改成功", "NOTICE");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("两次输入的密码不一致!!", "WARNING", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
