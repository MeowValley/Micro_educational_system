using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.admin
{
    public partial class adminModifyPwd : Form
    {
        string username;
        public adminModifyPwd(string usernaem)
        {
            InitializeComponent();
            label1.Text += usernaem;
            this.username = usernaem;
        }
        public adminModifyPwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prePwd.Text.Equals("") || newPwd.Text.Equals("") || confirmPwd.Text.Equals(""))
            {

                MessageBox.Show("以上字段不能为空！！", "WARNING", MessageBoxButtons.OK);
            }
            else
            {
                if (newPwd.Text.Equals(confirmPwd.Text) & Method.Modify_admin_password(prePwd.Text, username, newPwd.Text))
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
