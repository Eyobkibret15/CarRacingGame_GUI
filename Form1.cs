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
        protected static int score_value { get; set; }
        protected static int enemy_car_speed_boost { get; set; }
        protected static int speed_check { get; set; }
        protected static int speed_boost { get; set; }

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            score_value = 0;
            speed_boost = 5;
            enemy_car_speed_boost = -5;
            speed_check = 1000;
            label2.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (car.Bounds.IntersectsWith(enemy_car1.Bounds) || car.Bounds.IntersectsWith(enemy_car2.Bounds) ||
               car.Bounds.IntersectsWith(enemy_car3.Bounds) || car.Bounds.IntersectsWith(enemy_car4.Bounds))
            {
                label2.Text = "GAME OVER";
                label2.Visible = true;
                timer1.Enabled = false;
            }
            if(car.Bounds.IntersectsWith(star.Bounds))
            {
                score_value += 10;
                star.Top = rand.Next(-90, -50);
                star.Left = rand.Next(10, 330);
            }
            if (car.Bounds.IntersectsWith(dimond.Bounds))
            {
                score_value += 50;
                dimond.Top = rand.Next(-500, -470);
                dimond.Left = rand.Next(10, 330);
            }
            score_display.Text = score_value.ToString();
            Speed_Control();
            if(speed_boost < 0 )
            {
                speed_boost = 0;             
            }
            Speed(speed_boost, enemy_car_speed_boost);
            if(speed_boost > 0)
            {
                score_value += 1;
            }
           

        }
        void Speed_Control()
        {
            if (score_value - speed_check > 0 && speed_boost <= 25 && enemy_car_speed_boost > 25)
            {
                speed_boost +=3;
                enemy_car_speed_boost -=3;
                speed_check += 1000;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        } 
        void Speed(int value ,int enemy_speed)
        {           
           
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
            if (pb6.Top >= 550)
            {
                pb6.Top = -100;
            }
            if (pb7.Top >= 550)
            {
                pb7.Top = -100;
            }
            if (pb8.Top >= 550)
            {
                pb8.Top = -100;
            }
            if (pb9.Top >= 550)
            {
                pb9.Top = -100;
            }
            Object_Speed();
            pb2.Top += value;
            pb3.Top += value;
            pb4.Top += value;
            pb5.Top += value;
            pb6.Top += value;
            pb7.Top += value;
            pb8.Top += value;
            pb9.Top += value;
            enemy_car1.Top += enemy_speed;
            enemy_car2.Top += enemy_speed;
            enemy_car3.Top += enemy_speed;
            enemy_car4.Top += enemy_speed;
            star.Top += value;
            dimond.Top += value;
        }

       void Object_Speed()
        {
            if (enemy_car1.Top < -170 || enemy_car1.Top > 550)
            {
                do
                {
                    enemy_car1.Top = rand.Next(-170, -130);
                    enemy_car1.Left = rand.Next(10, 330);
                }
                while (enemy_car1.Bounds.IntersectsWith(enemy_car2.Bounds) || enemy_car1.Bounds.IntersectsWith(enemy_car3.Bounds) ||
               enemy_car1.Bounds.IntersectsWith(enemy_car4.Bounds) || enemy_car1.Bounds.IntersectsWith(star.Bounds)
               || enemy_car1.Bounds.IntersectsWith(dimond.Bounds));   
            }
            if (enemy_car2.Top < -270 || enemy_car2.Top > 550)
            {
                do
                {
                    enemy_car2.Top = rand.Next(-270, -230);
                    enemy_car2.Left = rand.Next(10, 330);
                }
                while (enemy_car2.Bounds.IntersectsWith(enemy_car1.Bounds) || enemy_car2.Bounds.IntersectsWith(enemy_car3.Bounds) ||
               enemy_car2.Bounds.IntersectsWith(enemy_car4.Bounds) || enemy_car2.Bounds.IntersectsWith(star.Bounds)
               || enemy_car2.Bounds.IntersectsWith(dimond.Bounds));
            }

            if (enemy_car3.Top < -400 || enemy_car3.Top > 550)
            {
                do
                {
                    enemy_car3.Top = rand.Next(-400, -350);
                    enemy_car3.Left = rand.Next(10, 330);
                }
                while (enemy_car3.Bounds.IntersectsWith(enemy_car1.Bounds) || enemy_car3.Bounds.IntersectsWith(enemy_car2.Bounds) ||
               enemy_car3.Bounds.IntersectsWith(enemy_car4.Bounds) || enemy_car3.Bounds.IntersectsWith(star.Bounds)
               || enemy_car3.Bounds.IntersectsWith(dimond.Bounds));
            }

            if (enemy_car4.Top < -530 || enemy_car4.Top > 550)
            {
                do
                {
                    enemy_car4.Top = rand.Next(-530, -480);
                    enemy_car4.Left = rand.Next(10, 330);
                }
                while (enemy_car4.Bounds.IntersectsWith(enemy_car1.Bounds) || enemy_car4.Bounds.IntersectsWith(enemy_car2.Bounds) ||
               enemy_car4.Bounds.IntersectsWith(enemy_car3.Bounds) || enemy_car4.Bounds.IntersectsWith(star.Bounds)
               || enemy_car4.Bounds.IntersectsWith(dimond.Bounds));
            }
            if (star.Top > 550)
            {
                do
                {
                    star.Top = rand.Next(-90, -50);
                    star.Left = rand.Next(10, 330);
                }
                while (star.Bounds.IntersectsWith(enemy_car1.Bounds) || star.Bounds.IntersectsWith(enemy_car2.Bounds) ||
               star.Bounds.IntersectsWith(enemy_car3.Bounds) || star.Bounds.IntersectsWith(enemy_car4.Bounds)
               || star.Bounds.IntersectsWith(dimond.Bounds));
            }
            if (dimond.Top > 550)
            {
                do
                {
                    dimond.Top = rand.Next(-660, -630);
                    dimond.Left = rand.Next(10, 330);
                }
                while (dimond.Bounds.IntersectsWith(enemy_car1.Bounds) || dimond.Bounds.IntersectsWith(enemy_car2.Bounds) ||
                     dimond.Bounds.IntersectsWith(enemy_car3.Bounds) || dimond.Bounds.IntersectsWith(enemy_car4.Bounds)
                   || dimond.Bounds.IntersectsWith(star.Bounds));
            }    
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
           if(timer1.Enabled == true)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if(car.Left > 10)
                    {
                        car.Left -= 5;
                    }
                    
                }
                if (e.KeyCode == Keys.Right)

                {
                    if (car.Left < 330)
                    {
                        car.Left += 5;
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if(speed_boost <= 25)
                    {
                        speed_boost += 2;
                        enemy_car_speed_boost +=2;
                        Speed(2,2);
                    }
                    
                }
                if (e.KeyCode == Keys.Down)
                {
                    if(speed_boost - 5 >= 2)
                    {
                        enemy_car_speed_boost -= 2;
                        speed_boost -= 2;
                        Speed(-2,-2);
                    }
                    else if (speed_boost > 0)
                    {
                        enemy_car_speed_boost -= speed_boost;
                        speed_boost -=speed_boost;
                        Speed(-speed_boost, -speed_boost);

                    }
                    
                }
            }
        }
        private void Start(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
        private void Stop(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void start_button_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

                var keys = new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down };
                if (keys.Contains(e.KeyData))
                    e.IsInputKey = true;
        }
        private void stop_button_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
                var keys = new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down };
            if (keys.Contains(e.KeyData))
            {
                e.IsInputKey = true;
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void enemy_car2_Click(object sender, EventArgs e)
        {

        }
    }   
}