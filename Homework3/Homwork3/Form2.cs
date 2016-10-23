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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string classname = textBox1.Text;
            if (classname == "")
            {
                MessageBox.Show("请输入课程名！");
                return;
            }
            string teacher = textBox2.Text;
            if (teacher == "")
            {
                MessageBox.Show("请输入教师！");
                return;
            }
            string classroom = textBox3.Text;
            if (classroom == "")
            {
                MessageBox.Show("请输入上课教室！");
                return;
            }
            int score;
            try
            {
                score = int.Parse(textBox4.Text);
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("请输入学分！");
                return;
            }catch(FormatException){
                MessageBox.Show("请输入正确格式的学分！");
                return;
            }
            int hour;
            try
            {
                hour = int.Parse(textBox5.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("请输入课时！");
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确格式的课时！");
                return;
            }
            if(!checkedListBox1.GetItemChecked(0) && !checkedListBox1.GetItemChecked(1)){
                MessageBox.Show("请选择是否为必修课！");
                return;
            }
            bool isBixiu = checkedListBox1.GetItemChecked(0);
            Course newCourse = new Course(classname,teacher,classname,score,hour,isBixiu);
            if (MyDataBaseModel.addNewCourse(newCourse))
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
                MessageBox.Show("添加失败，请检查输入的内容和格式！");
        }


    }
}
