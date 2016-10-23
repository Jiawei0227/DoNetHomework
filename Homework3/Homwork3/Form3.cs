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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“superCourseDataSet.course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.superCourseDataSet.course);
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if (i.Cells[6].Value.ToString() == "False")
                {
                    i.Cells[7].Value = "选修";
                }
                else
                {
                    i.Cells[7].Value = "必修";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            this.Form3_Load(new object(),new EventArgs());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (MyDataBaseModel.deleteCourse(id))
                MessageBox.Show("删除课程成功！");
            else
                MessageBox.Show("删除课程失败！");
            this.Form3_Load(new object(), new EventArgs());
        }
    }
}
