using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.通知
{
    public partial class Messageadd : Form
    {
        public Messageadd()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "咻咻咻~发布留言喵！";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "确认发布喵！";
        }

        private void uiRichTextBox1_MouseLeave(object sender, EventArgs e)
        {
            uiRichTextBox1.Text = "使用者，你好呀！请在这里键入留言喵";

        }

        private void uiRichTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            uiRichTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uiRichTextBox1.Text.Equals("使用者，你好呀！请在这里键入留言喵"))
            {
                MessageBox.Show("主人是疏忽还是太懒了喵，您似乎什么都没有输入哦喵","喵喵喵？", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Method.sendmg(uiRichTextBox1.Text))
                {
                    MessageBox.Show("好耶，新大陆上也有主人的痕迹啦喵，解锁板块+1喵","探险喵喵成就达成",MessageBoxButtons.OK);
                   通知.Message message=new 通知.Message();
                    this.Hide();
                    
                    message.ShowDialog();
                }
                else
                {
                    MessageBox.Show("唔，出现了未知错误了喵", "探险失利了喵", MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            通知.Message message = new 通知.Message();
           this.Hide();
            message.ShowDialog();
            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Text = "主人下次再见喵！";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "返回喵！";
        }
    }
}
