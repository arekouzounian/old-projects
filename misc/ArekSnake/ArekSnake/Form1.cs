using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArekSnake
{
    // Lose when off the screen -> if snake's X and Y is out of parameter(drawbox), application.exit
    // Dont allow snake reversing -> if the direction the snake is going is the opposite of the key pressed, don't allow
    // Grid snap the food -> make the random gen a multiple of the grid size

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Random gen = new Random();
        Snake snake;
        Food food;
        Graphics gfx;
        int highScore = 0;
        bool hasMoved = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            int genX = gen.Next(0, drawBox.Width / 18) * 18;
            int genY = gen.Next(0, drawBox.Height / 18) * 18;
            snake = new Snake(180, 180, Brushes.White);
            food = new Food(genX, genY, 18, Brushes.White);
            bitmap = new Bitmap(drawBox.Width, drawBox.Height);
            gfx = Graphics.FromImage(bitmap);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateWindow();
            Draw(gfx);
            // if dead = true
        }
        
        private void UpdateWindow()
        {
            hasMoved = true;
            snake.Update(food, ClientSize);
            score.Text = "Score: " + snake.userScore;
            if (snake.userScore > highScore)
            {
                highScore = snake.userScore;
            }
            if (snake.Dead)
            {
                timer1.Enabled = false;
                MessageBox.Show("You Lose! \nHigh Score: " + highScore);
                Reset();

            }
        }

        public void Reset()
        {
            snake.snakePieces.RemoveRange(1, (snake.snakePieces.Count -1));
            snake.Head.X = 180;
            snake.Head.Y = 180;
            snake.Dead = false;
            snake.userScore = 0;
            timer1.Enabled = true;
            snake.Head.direction = SnakePart.Direction.None;
            food.X = gen.Next(0, drawBox.Width / 18) * 18;
            food.Y = gen.Next(0, drawBox.Height / 18) * 18;
        }
        
        public void Draw(Graphics gfx)
        {
            gfx.Clear(BackColor);
            gfx.FillEllipse(Brushes.White, food.Hitbox);
            food.Draw(gfx);
            snake.Draw(gfx);
            drawBox.Image = bitmap;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!hasMoved) return;

            hasMoved = false;
            if(e.KeyCode == Keys.Right)
            {
                if(snake.Head.direction != SnakePart.Direction.Left)
                {
                    snake.Head.direction = SnakePart.Direction.Right;
                }
            }
            if(e.KeyCode == Keys.Left)
            {
                if(snake.Head.direction != SnakePart.Direction.Right)
                {
                    snake.Head.direction = SnakePart.Direction.Left;
                } 
            }
            if(e.KeyCode == Keys.Up)
            {
                if (snake.Head.direction != SnakePart.Direction.Down)
                {
                    snake.Head.direction = SnakePart.Direction.Up;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if (snake.Head.direction != SnakePart.Direction.Up)
                {
                    snake.Head.direction = SnakePart.Direction.Down;
                }
            }
        }
    }
}
