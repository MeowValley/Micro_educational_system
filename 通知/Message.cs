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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "一起在这里留下你的足迹吧！";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "发布留言";
        }

        private void Message_Load(object sender, EventArgs e)
        {
            DataSet ds=Method.message();
            if (ds.Tables["message"].Rows.Count == 0)
            {
                uiRichTextBox1.Text = "坏了，您似乎来到了一处无人区~~";
            }
            else
            {
                for (int i = 0; i < ds.Tables["message"].Rows.Count; i++)
                {
                    uiRichTextBox1.Text += $"\t第{i+1}条留言：\t" + ds.Tables["message"].Rows[i][0].ToString() + "\n\n\n"+ "\t\t\t\t\t\t\t\t\t\t\t\t\t时间：" + ds.Tables["message"].Rows[i][1].ToString()+"\n";
            }
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Messageadd messageadd = new Messageadd();
            通知.Message message = new 通知.Message();
            this.Hide();
            messageadd.ShowDialog();
            
        }

        

      

        
    }
}
