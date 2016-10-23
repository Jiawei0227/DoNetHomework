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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“superCourseDataSet1.lessonplan”中。您可以根据需要移动或删除它。
            this.lessonplanTableAdapter.Fill(this.superCourseDataSet1.lessonplan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            Form5_Load(new object(),new EventArgs());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xingqi = (string)dataGridView1.CurrentRow.Cells[1].Value;
            string time = (string)dataGridView1.CurrentRow.Cells[2].Value;
            if (MyDataBaseModel.deleteLessonPlan(xingqi, time))
            {
                MessageBox.Show("删除成功！");
                Form5_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
