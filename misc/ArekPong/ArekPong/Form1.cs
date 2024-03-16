using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArekPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics gfx;
        Ball ball;
        Paddle userPaddle;
        Paddle cpuPaddle;
        int Score = 0;
        int CpuScore = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(drawBox.Width, drawBox.Height);
            gfx = Graphics.FromImage(bitmap);
            ball = new Ball(10, 10, 25, Brushes.White, 15, 15);
            userPaddle = new Paddle(ClientSize.Width-20, 20, 8, 50, 25, Brushes.White);
            cpuPaddle = new Paddle(10, 20, 8, 50, 20, Brushes.White);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            ball.Move(ClientSize);
            ball.Draw(gfx);
            userPaddle.Draw(gfx);
            cpuPaddle.Draw(gfx);
            if (ball.HitBox.IntersectsWith(userPaddle.PaddleHitBox))
            {
                ball.Xspeed *= -1;
                Score++;
            }
            else if (ball.HitBox.IntersectsWith(cpuPaddle.PaddleHitBox))
            {
                ball.Xspeed *= -1;
                CpuScore++;
            }
            cpuPaddle.PaddleHitBox.Y = ball.HitBox.Y;
            if(ball.Fail == true)
            {
                timer1.Enabled = false;
                MessageBox.Show("You Lose!");
                Application.Exit();
            }
            else if (Score == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("You Lose!");
                Application.Exit();
            }
            userScore.Text = $"Score: {Score}";
            cpuScore.Text = $"Score: {CpuScore}";
            drawBox.Image = bitmap;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                userPaddle.PaddleHitBox.Y -= userPaddle.Speed;
            }
            else if (e.KeyCode == Keys.Down)
            {
                userPaddle.PaddleHitBox.Y += userPaddle.Speed;
            }
        }
    }
}
