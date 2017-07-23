using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSynchronize
{
    public partial class Form1 : Form
    {
        static EventWaitHandle eh1 = new AutoResetEvent(false);
        static EventWaitHandle eh2 = new AutoResetEvent(false);
        static string task = "Task:";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Go1(object obj)
        {
            string str = (string)obj;
            eh1.WaitOne();
            while (true)
            {
                if (task.Length >= 50)
                {
                    eh2.Set();
                    return;
                }
                task += str;
                eh2.Set();
                eh1.WaitOne();
            }

        }

        void Go2(object obj)
        {
            string str = (string)obj;
            eh2.WaitOne();
            while (true)
            {
                if (task.Length >= 50)
                {
                    eh1.Set();
                    return;
                }
                task += str;
                eh1.Set();
                eh2.WaitOne();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(Go1);
            t1.IsBackground = true;
            t1.Start("A");
            
            Thread t2 = new Thread(Go2);
            t2.IsBackground = true;
            t2.Start("_");
            eh1.Set();
            t1.Join(2000);
            t2.Join(2000);

            listBox1.Items.Add(task);
        }
    }
}
