using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homwork3
{
    public partial class Form4 : Form
    {
        private string xingqi = "-1";
        private string time = "-1";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“superCourseDataSet.course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.superCourseDataSet.course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xingqi = "";
            if (radioButton1.Checked)
            {
                xingqi = "星期一";
            }
            else if (radioButton2.Checked)
            {
                xingqi = "星期二";
            }
            else if (radioButton3.Checked)
            {
                xingqi = "星期三";
            }
            else if (radioButton4.Checked)
            {
                xingqi = "星期四";
            }
            else if (radioButton5.Checked)
            {
                xingqi = "星期五";
            }
            else
            {
                MessageBox.Show("请选择上课星期");
                return;
            }
            string time = "";
            if (radioButton6.Checked)
            {
                time = "8:00-10:00";
            }
            else if (radioButton7.Checked)
            {
                time = "10:00-12:00";
            }
            else if (radioButton8.Checked)
            {
                time = "14:00-16:00";
            }
            else if (radioButton9.Checked)
            {
                time = "16:00-18:00";
            }
            else if (radioButton10.Checked)
            {
                time = "18:30-21:00";
            }
            else
            {
                MessageBox.Show("请选择上课时间");
                return;
            }

            string lesson = (string)listBox1.SelectedValue;
            MyLessonPlan mylessonplan = new MyLessonPlan(lesson, xingqi, time);

            if (MyDataBaseModel.addLessonPlan(mylessonplan))
            {
                MessageBox.Show("添加成功！！");
            }
            else
            {
                MessageBox.Show("添加失败，您在该时段已经有课啦！");
            }
        }





        
    }
}
