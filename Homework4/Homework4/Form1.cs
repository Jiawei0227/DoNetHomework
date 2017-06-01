using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Homework4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hScrollBar1.Value = 100;
        }

        int beishu = 10;
        Thread t1,t2,t3;
        TimeKeeper timekeeper;
        MyProgressBar myProgressBar1, myProgressBar2, myProgressBar3;

        private void button1_Click(object sender, EventArgs e)
        {
            //时间线程
            timekeeper = new TimeKeeper();
            Thread timeT = new Thread(new ThreadStart(timekeeper.runMethod));
            timeT.Start();

            //第一个进度条线程
            myProgressBar1 = new MyProgressBar(1,timekeeper);
            myProgressBar1.setProgressBar += setProgress1Value;
            t1 = new Thread(new ThreadStart(myProgressBar1.runMethod));
            t1.Start();

            //第二个进度条线程
            myProgressBar2 = new MyProgressBar(2,timekeeper);
            myProgressBar2.setProgressBar += setProgress2Value;
            t2 = new Thread(new ThreadStart(myProgressBar2.runMethod));
            t2.Start();

            //第三个进度条线程
            myProgressBar3 = new MyProgressBar(3,timekeeper);
            myProgressBar3.setProgressBar += setProgress3Value;
            t3 = new Thread(new ThreadStart(myProgressBar3.runMethod));
            t3.Start();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           label8.Text = ((hScrollBar1.Value+10)/10).ToString() + "倍";
            beishu = (hScrollBar1.Value+10) / 10;

        }

        private void setProgress1Value(int value,int number)
        {
            if (this.progressBar1.InvokeRequired)
            {
                MyProgressBar m = new MyProgressBar(number);
                m.setProgressBar += setProgress1Value;
                this.Invoke(m.setProgressBar, new Object[] { value, number });
            }
            else
            {
                if ((value / 100) > 0 && (value % 100) == 0)
                {
                    this.progressBar1.Value = 100;
                    this.label4.Text =  "100%";
                }
                else
                {
                    this.progressBar1.Value = value % 100;
                    this.label4.Text = (value % 100).ToString() + "%";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timekeeper.isStop = true;
            myProgressBar1.isStop = true;
            myProgressBar2.isStop = true;
            myProgressBar3.isStop = true;
        }

        private void setProgress2Value(int value, int number)
        {
            if (this.progressBar2.InvokeRequired)
            {
                MyProgressBar m = new MyProgressBar(number);
                m.setProgressBar += setProgress2Value;
                this.Invoke(m.setProgressBar, new Object[] { value, number });
            }
            else
            {
                if ((value / beishu) > 0 && ((value / beishu) % 100) == 0)
                {
                    this.progressBar2.Value = 100;
                    this.label5.Text = "100%";
                }
                else
                {
                    this.progressBar2.Value = (value / beishu) % 100;
                    this.label5.Text = ((value / beishu) % 100).ToString() + "%";
                }
            }
        }

        private void setProgress3Value(int value, int number)
        {
            if (this.progressBar3.InvokeRequired)
            {
                MyProgressBar m = new MyProgressBar(number);
                m.setProgressBar += setProgress3Value;
                this.Invoke(m.setProgressBar, new Object[] { value, number });
            }
            else
            {
                if (value / (beishu * beishu) == 100)
                    this.button2_Click(new object(),new EventArgs());
                this.progressBar3.Value = value / (beishu*beishu);
                this.label6.Text = (value /(beishu*beishu)).ToString()+"%";
            }
        }
         
    }

    public class TimeKeeper
    {
        int time;
        public bool isStop = false;
        public void runMethod()
        {
            while (!isStop)
            {
                Thread.Sleep(100);
                time+=5;
            }
        }

        public int getTime()
        {
           return time;
         
        }
    }


    public class MyProgressBar
    {
        //声明一个委托
        public delegate void setProgressBarValue(int value,int number);
        public setProgressBarValue setProgressBar;
        int number;
        public bool isStop = false;
        TimeKeeper t;

        public MyProgressBar(int number)
        {
            this.number = number;
        }

        public MyProgressBar(int number,TimeKeeper t)
        {
            this.number = number;
            this.t = t;
        }
        public void runMethod()
        {
            while (!isStop)
            {
                Thread.Sleep(50);
                lock (t)
                {
                    setProgressBar(t.getTime(), number);
                }
            }
                
            
        }
    }
}
