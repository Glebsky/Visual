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

namespace SecondSyn
{
    public partial class Form1 : Form
    {
        static int count;
        Semaphore s = null;
        List<Thread> threads = new List<Thread>();
        delegate void ForList(string str);



        public Form1()
        {
            InitializeComponent();
            btnCreate.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Go);
            count++;
            t.Name = "Thread" + count.ToString();
            threads.Add(t);
            lbCreated.Items.Add(t.Name);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                s = new Semaphore(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown1.Value));
                btnCreate.Enabled = true;
            }
            else {
                btnCreate.Enabled = false;
            }
        }

        public void Go()
        {
            s.WaitOne();
            Thread ct = Thread.CurrentThread;
            list2(ct.Name);
            list3(ct.Name);
        }

        private void lbCreated_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbCreated.SelectedIndex;
            if (index != -1 )
            {
                string str = lbCreated.SelectedItem.ToString();
                str = str.Substring(6);
                int i = Convert.ToInt32(str);
                Thread t = threads[i - 1];
                lbCreated.Items.RemoveAt(index);
                lbWait.Items.Add(t.Name);
                t.IsBackground = true;
                t.Start();
            }
        }

        void list2(string tname)
        {
            if (lbWait.InvokeRequired)
            {
                lbWait.Invoke(new ForList(list2), new object[]{tname});
                return;
            }
            lbWait.Items.Remove(tname);
        }

        void list3(string tname)
        {
            if (lbWork.InvokeRequired)
            {
                lbWork.Invoke(new ForList(list3), new object[] { tname });
                return;
            }
            lbWork.Items.Add(tname);
        }
    }
}
