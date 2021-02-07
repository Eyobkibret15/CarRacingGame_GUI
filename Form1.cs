using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarRacingGame_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Speed(5);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        void Speed(int value)
        {
            pb2.Top += value;
            pb3.Top += value;
            pb4.Top += value;
            pb5.Top += value;

            if (pb2.Top >= 550)
            {
                pb2.Top = -100;
            }
            if (pb3.Top >= 550)
            {
                pb3.Top = -100;
            }
            if (pb4.Top >= 550)
            {
                pb4.Top = -100;
            }
            if (pb5.Top >= 550 )
            {
                pb5.Top = -100;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        
           if(timer1.Enabled == true)
            {
                if (e.KeyCode == Keys.Left)
                {
                    car.Left -= 5;
                }
                if (e.KeyCode == Keys.Right)

                {
                    car.Left += 5;
                }
                if (e.KeyCode == Keys.Up)
                {
                    Speed(5);
                }
                if (e.KeyCode == Keys.Down)
                {
                    Speed(-5);
                }
            }
        }

        private void Start(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label2.Focus();
        }

        private void Stop(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label2.Focus();
        }

        private void Form1_KeyDown(object sender, KeyPressEventArgs e)
        {

        }
    }
}