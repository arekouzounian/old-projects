using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RecursiveBacktrackingMazeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand;
        Maze myMaze;
        Graphics gfx;

        private void button2_Click(object sender, EventArgs e)
        {
            gfx = this.CreateGraphics();
            gfx.Clear(Color.CornflowerBlue);
            rand = new Random();
            myMaze = new Maze(75, 50, 10, new Point(200, 100));
            myMaze.drawMaze(gfx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            myMaze.RecursiveBacktrack(rand);
            myMaze.drawMaze(gfx);
            //Thread.Sleep(3000);
            //myMaze.rightHandRuleSolver(gfx);
            label1.Visible = true;
        }
        //Once maze can be solved, create a game where you start at the top, and you can move around
        //there's a 'hint' button you can press that runs A* but only reveals the path until the next vertex/fork in the road 

    }
}