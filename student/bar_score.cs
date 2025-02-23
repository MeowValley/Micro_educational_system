using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Satelliteeducationsystem.student
{
    public partial class bar_score : Form
    {
        private string cid;
        private string  sid;
        public bar_score(string cid,string sid)
        {
            InitializeComponent();
            this.cid = cid;
            this.sid = sid;
        }

        private void bar_score_Load(object sender, EventArgs e)
        {
            UIBarOption option = new UIBarOption();
            // 配置标题
            option.Title = new UITitle();
            // 主标题
            option.Title.Text = "分数可视化";
            // 副标题
            option.Title.SubText = "";

            // 设置图例
            option.Legend = new UILegend();
            // 图例水平布局
            option.Legend.Orient = UIOrient.Horizontal;
            // 图例放置在左上角
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            // 两个图例分别是Bar1和Bar2
            option.Legend.AddData("个人成绩");
            option.Legend.AddData("班级平均成绩");

            // 设置系列
            UIBarSeries series = new UIBarSeries();
            // 第一系列Bar1
            series.Name = "个人成绩";
            DataSet ds = Method.bar_score(cid, sid);
            for(int i = 0; i < ds.Tables["bar_score"].Rows.Count; i++)
            {
                series.AddData(float.Parse(ds.Tables["bar_score"].Rows[i][0].ToString()));
            }
            
            
            option.Series.Add(series);

            // 设置第二系列Bar2
            series = new UIBarSeries();
            series.Name = "班级平均成绩";
            DataSet ds1=Method.bar_avgscore(cid);
            for (int i = 0; i < ds.Tables["bar_score"].Rows.Count; i++)
            {
                series.AddData(float.Parse(ds1.Tables["avg_score"].Rows[0][0].ToString()));
            }
               
           
            option.Series.Add(series);

            // 设置横坐标内容
            // 第一系列和第二系列的元素交织分布
            // 所以Mon是指第一和二系列的第一个元素的横坐标
            // Tue指第一和二系列的第二个元素的横坐标

            for (int i = 0; i < ds.Tables["bar_score"].Rows.Count; i++)
            {
                option.XAxis.Data.Add(ds.Tables["bar_score"].Rows[i][1].ToString());
            }
            
            //option.XAxis.Data.Add("Tue");
            //option.XAxis.Data.Add("Wed");
            //option.XAxis.Data.Add("Thu");
            //option.XAxis.Data.Add("Fri");

            // 辅助ToolTip是否可见
            option.ToolTip.Visible = true;
            // Y轴的刻度
            option.YAxis.Scale = true;
            // XY轴的单位
            option.XAxis.Name = "科目";
            option.YAxis.Name = "数值";
            // 标记处上下限（数值超过了也没事）
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "及格线", Value = 60 });
            //option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = -20 });
            // 更新坐标轴
            uiBarChart1.SetOption(option);

        }
    }
}
