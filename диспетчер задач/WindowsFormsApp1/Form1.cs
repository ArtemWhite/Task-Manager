using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var item in Process.GetProcesses())
                lBox.Items.Add(item.ProcessName);
            //TimerCallback tcb = new TimerCallback(update);
            //System.Threading.Timer timer = new System.Threading.Timer(tcb, 0,0,1000);
            Thread ts = new Thread(update);
            ts.IsBackground = true;
            ts.Start();
        }
        void update()
        {
            while (true)
            {
                lBox.Items.Clear();
                foreach (var item in Process.GetProcesses())
                    lBox.Items.Add(item.ProcessName);
                Thread.Sleep(5000);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
 
            foreach (var p in Process.GetProcessesByName($"{tBox2.Text}"))
                p.CloseMainWindow();
            lBox.Items.Remove(tBox2.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo($"{tBox.Text}") ;
            p.Start();
            lBox.Items.Add($"{tBox.Text}");
            

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lBox.Items.Clear();
            var list = Process.GetProcesses();
            
                foreach (var item in list)
                {
                    if (item.ProcessName.ToLower().Contains(tBox2.Text.ToLower()))
                        lBox.Items.Add(item.ProcessName);

                }
            
            
        }
        private void tBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lBox_SelectedItemChanged(object sender, EventArgs e)
        {
            tBox2.Text = lBox.SelectedItem.ToString();
        }
    }
}
