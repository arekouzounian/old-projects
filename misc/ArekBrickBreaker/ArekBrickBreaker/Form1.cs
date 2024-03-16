using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArekBrickBreaker
{
    public partial class BrickBreakerWindow : Form
    {
        public BrickBreakerWindow()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics gfx;
        Ball ball;
        Paddle paddle;
        List<Brick> bricks;
        int lives = 3;
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = $"Lives: {lives}";
            bitmap = new Bitmap(drawBox.Width, drawBox.Height);
            gfx = Graphics.FromImage(bitmap);
            ball = new Ball((drawBox.Width/2) - (14), drawBox.Height - 60, 18, 7, 7, Brushes.White);
            int width = 54;
            paddle = new Paddle((drawBox.Width/2)-(width/2), (drawBox.Height - 20), width, 8, 7, 7, Brushes.White);
            bricks = new List<Brick>();
            //printing the bricks 
            int dy = 10;
            int dx = 7;
            for (int column = 0; column < 6; column++)
            {
                //for loop for each column 
                for (int row = 0; row < 12; row++)  
                {
                    //for loop for each row
                    bricks.Add(new Brick(dx, dy, 40, 25, Brushes.Red));
                    dx += 45;
                }
                dy += 30; 
                dx = 7;
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateWindow();
            Draw();
        }

        public void UpdateWindow()
        {
            ball.Move(ClientSize);

            if(ball.Hitbox.IntersectsWith(paddle.Hitbox))
            {
                ball.Yspeed = -Math.Abs(ball.Yspeed);
            }
            for(int b = 0; b < bricks.Count; b++)
            {
                if (ball.Hitbox.IntersectsWith(bricks[b].Hitbox))
                {
                    ball.Yspeed *= -1;
                    bricks.Remove(bricks[b]);
                    b--; 
                }
            }

            //code for losing 
            if (ball.Hitbox.Y > ClientSize.Height)
            {
                lives--;
                ball.Hitbox.X = (drawBox.Width / 2) - 14;
                ball.Hitbox.Y = drawBox.Height - 60;
                paddle.Hitbox.X = (drawBox.Width / 2) - (paddle.Hitbox.Width / 2);
                paddle.Hitbox.Y = (drawBox.Height - 20);
                label2.Text = $"Lives: {lives}";
                if (lives == 0)
                {
                    timer1.Enabled = false;
                    panel1.Visible = true;
                    panel1.BringToFront();
                }
            }
        }

        public void Draw()
        {
            //erase
            gfx.Clear(BackColor);

            for (int i = 0; i < bricks.Count; i++)
            {
                bricks[i].Draw(gfx);
            }
            paddle.Draw(gfx);
            ball.Draw(gfx);
            drawBox.Image = bitmap;

        }

        private void BrickBreakerWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                paddle.Hitbox.X += paddle.Xspeed;
            }
            if(e.KeyCode == Keys.Left)
            {
                paddle.Hitbox.X -= paddle.Xspeed;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
