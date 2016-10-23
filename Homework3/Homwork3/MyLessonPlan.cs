using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork3
{
    class MyLessonPlan
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string xingqi;

        public string Xingqi
        {
            get { return xingqi; }
            set { xingqi = value; }
        }

        private string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public MyLessonPlan(string name, string xingqi, string time)
        {
            this.Name = name;
            this.Xingqi = xingqi;
            this.Time = time;
        }
    }
}
