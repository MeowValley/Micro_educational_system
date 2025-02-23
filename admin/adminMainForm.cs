using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Satelliteeducationsystem.通知;
using System.Security.Cryptography;
using System.Net.Sockets;

namespace Satelliteeducationsystem.admin
{
    public partial class adminMainForm : Form
    {
        private Timer Timer1;
        private int currentIndex = 0; // 当前图片索引
        private int imageCount;       // 图片总数
        public string identity;
        public string account;
        public string aid;
        public string cid;
        public string name;
        public string cname;
        public string state;
        private TcpListener tcpListener;
        public adminMainForm(string identity, string account)
        {
            InitializeComponent();
            this.identity = identity;
            this.account = account;
            imageCount = carousel1.Image.Count;
            tcpListener = new TcpListener(888);//创建监听对象
            // 初始化计时器
            Timer1 = new Timer();
            Timer1.Interval = 3000; // 每隔3秒切换图片
            Timer1.Tick += timer1_Tick; // 绑定计时器事件

        }
        public adminMainForm()
        {
            InitializeComponent();
        }
        private void StartCarousel()
        {
            // 开始循环播放
            if (imageCount > 0) // 确保有图片
            {
                Timer1.Start();
            }
            else
            {
                MessageBox.Show("没有可播放的图片！");
            }
        }

        private void StopCarousel()
        {
            // 停止循环播放
            Timer1.Stop();
        }
        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("用户:" + account + "\n您即将退出客户端", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                Login login = new Login();
                this.Close();
                login.Show();

            }
        }

        private void adminMainForm_Load(object sender, EventArgs e)
        {
            // 窗体加载时启动走马灯
            StartCarousel();
            admininfo a = Method.query_admin_info(account);
            this.aid = a.aid;
            this.state=a.state;
            this.name = a.aname;
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           adminModifyPwd adminModifyPwd = new adminModifyPwd(account);
            adminModifyPwd.ShowDialog();

        }

        private void 我的班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            班级管理 class_admin = new 班级管理();
            class_admin.ShowDialog();
        }

        private void 成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            学生管理 student_admin =new 学生管理();
            student_admin.ShowDialog();
        }

        private void 课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            教师管理 teacher_admin=new 教师管理();
            teacher_admin.ShowDialog();
        }

        private void 公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotice frmNotice =new FrmNotice();
            frmNotice.id = aid;
            frmNotice.identity = identity;
            frmNotice.ShowDialog();
        }

        private void 公共留言板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            通知.Message message= new 通知.Message();
            message.ShowDialog();
        }

        private void 文件中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileoperation.creat_directory(aid))
            {
                MessageBox.Show("文件中心资源配置完成!", "成功", MessageBoxButtons.OK);
                FileCenter filecenter = new FileCenter(aid, "个人文件");
                filecenter.ShowDialog();
            }
            else
            {
                MessageBox.Show("文件中心资源配置失败!", "失败", MessageBoxButtons.OK);
            }
        }

        private void 关于本系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about =new About(identity);
            about.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paisi.edu.cn/html/988/");
        }

        private void 关于本校ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutSchool aboutSchool = new AboutSchool();
            aboutSchool.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paisi.edu.cn");
        }

        private void 密钥管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state.Equals("0"))
            {
                MessageBox.Show("您的权限不足！");

            }
            else
            {
                密钥管理 code=new 密钥管理();
                code.ShowDialog();
            }
        }

        private void 管理员列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state.Equals("0"))
            {
                MessageBox.Show("您的权限不足！");

            }
            else
            {
                管理员管理 manageadmin= new 管理员管理();
                manageadmin.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 切换到下一张图片
            currentIndex = (currentIndex + 1) % imageCount; // 循环切换
            carousel1.SelectIndex = currentIndex;
        }

        private void 聊天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chat chat=new chat(aid, tcpListener);
            chat.ShowDialog();
        }

        private void 教室管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classroom classroom = new classroom();
            classroom.ShowDialog();
        }
    }
}
