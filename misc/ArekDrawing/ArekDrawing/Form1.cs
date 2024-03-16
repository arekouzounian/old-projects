using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArekDrawing
{

    public partial class Form1 : Form
    {
        Graphics gfx;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = this.CreateGraphics();
        }
        // x, y, width, height
        //draw a house with a roof, door, and window
        private void Form1_Shown(object sender, EventArgs e)
        {
            //house
            gfx.DrawRectangle(Pens.Blue, 230, 200, 150, 100);
            //door
            gfx.DrawRectangle(Pens.Brown, 278, 250, 50, 50);
            //circle window
            gfx.DrawEllipse(Pens.Blue, 340, 230, 25, 25);
            gfx.DrawEllipse(Pens.Blue, 337, 228, 30, 30);
            //square window 
            gfx.DrawRectangle(Pens.Blue, 245, 230, 25, 25);
            gfx.DrawLine(Pens.Blue, 245.0F, 242.5F, 270.0F, 242.5F);
            gfx.DrawLine(Pens.Blue, 257.5F, 230.0F, 257.5F, 255.0F);
            //doorknob
            gfx.DrawEllipse(Pens.Brown, 314, 275, 10, 10);
            //roof
            //NOTE: Use the negative reciprocal of one line to make the other line
            gfx.DrawLine(Pens.Blue, 230.0F, 200.0F, 308.0F, 110.0F);
            gfx.DrawLine(Pens.Blue, 380.0F, 200.0F, 308.0F, 110.0F);
        }
    }
}
