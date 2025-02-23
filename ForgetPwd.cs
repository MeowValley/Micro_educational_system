using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem
{
    public partial class ForgetPwd : Form
    {
        public ForgetPwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Phone = phone.Text;
            string email = "";
            string IDCard = idcard.Text;
            string Password = password.Text;
            if (phone.Text.Equals("") || idcard.Text.Equals("") || password.Text.Equals(""))
            {
                MessageBox.Show("请填写以上所有字段！！", "WARNING", MessageBoxButtons.OK);
            }
            else
            {
                if (Method.query_s_user_exist(Phone, email, IDCard) || Method.query_t_user_exist(Phone, email, IDCard) || Method.query_admin_exist(Phone, email, IDCard))
                {
                    if (Method.Forget_s_user_passwprd(Phone, IDCard, Password) || Method.Forget_t_user_passwprd(Phone, IDCard, Password) || Method.Forget_admin_passwprd(Phone, IDCard, Password))
                    {
                        MessageBox.Show("密码修改成功，请牢记您的密码！", "importance", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("出现未知错误导致您的密码修改失败！");
                    }
                }
                else
                {
                    MessageBox.Show("该用户不存在，请前往注册!!", "notice", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Close();
            login.ShowDialog();
        }

        private void ForgetPwd_Load(object sender, EventArgs e)
        {

        }
    }
}
