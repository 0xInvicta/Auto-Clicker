using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

using System.Windows.Forms;

namespace Auto_Clicker
{
    public partial class Form1 : Form
    {

        public volatile bool threadFlag_Abort;
        public volatile bool threadFlag_Start = false;
        public Thread mouseClickTimed;
        public Thread mouseClick;
        public Thread counter;

        public Form1()
        {
            InitializeComponent();
            abortButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
   
            startButton.Enabled = false;
            abortButton.Enabled = true;

            threadFlag_Abort = false;
            if (runForeverBox.Checked)
            {
                mouseClick = new Thread(mouseClick_Thread);
                mouseClick.Start(); 
                
            }
            else
            {
                try
                {
                    int minsTest = Int32.Parse(minTextBox.Text);
                    int secsTest = Int32.Parse(SecTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Please Enter a valid number !", "ERROR");
                }
                int mins = Int32.Parse(minTextBox.Text);
                int secs = Int32.Parse(SecTextBox.Text);
                counter = new Thread(() => counter_thread(mins, secs));
                mouseClickTimed = new Thread(mouseClick_Thread);
                counter.Start();
                mouseClickTimed.Start();
            }

            
        }

        private void counter_thread(int mins, int secs)
        {
            int runtime = mins * 60 + secs;
            while (!threadFlag_Abort)
            {
                for (int i = 0; i < runtime; i++)
                {
                    Thread.Sleep(1000);
                }
                threadFlag_Abort = true;
            }


        }
        private void abortButton_Click(object sender, EventArgs e)
        {
            threadFlag_Abort = true;

            mouseClickTimed.Abort();
            startButton.Enabled = true;
            abortButton.Enabled = false;
        }
        private void mouseClick_Thread()
        {
            mouseClickClass mouseClickObj = new mouseClickClass();
            while (!threadFlag_Abort)
            {
                Thread.Sleep(10);
                mouseClickObj.clickFunction();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadFlag_Start == true)
            {
                mouseClickTimed.Abort();
            }
            threadFlag_Abort = true;
        }
    }



    public class mouseClickClass
    {

        //Constructor Function
        public mouseClickClass()
        {
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int mouseEvent1 = 0x02;
        private const int mouseEvent2 = 0x04;

        public void clickFunction()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(mouseEvent1 | mouseEvent2, X, Y, 0, 0);
        }
    }
}

        
   
