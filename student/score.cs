using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.student
{
    public partial class score : Form
    {
        public string sid;
        public string cid;
        public score(string sid, string cid)
        {
            InitializeComponent();
            this.sid = sid;
            this.cid = cid;
        }

        private void score_Load(object sender, EventArgs e)
        {
            DataSet ds = Method.student_score(sid);
            scorelist.DataSource = ds.Tables["score"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bar_score bar_Score=new bar_score(cid,sid);
            bar_Score.ShowDialog();
        }
    }
}
