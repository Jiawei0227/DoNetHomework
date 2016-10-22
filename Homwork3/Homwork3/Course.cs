using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork3
{
    class Course
    {
        private string className;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        
        private string teacher;

        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
        private string classroom;
        public string Classroom
        {
            set { classroom = value; }
            get { return classroom; }
        }
        private int score;
        public int Score
        {
            set { score = value; }
            get { return score; }
        }
        private int hour;
        public int Hour
        {
            set { hour = value; }
            get { return hour; }
        }
        private bool isBixiu;
        public bool IsBixiu
        {
            set { isBixiu = value; }
            get { return isBixiu; }
        }
        public Course(string className,string teacher,string classroom,int score,int hour,bool isBixiu)
        {
            this.classroom = classroom;
            this.className = className;
            this.teacher = teacher; 
            this.score = score;
            this.hour = hour;
            this.isBixiu = isBixiu;
        }
    }
}
