using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArekTextAdventureV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string state = "begin";


        private void backOut_Click(object sender, EventArgs e)
        {
            if (state == "load")
            {
                label1.Text = "You Enter a Dark Alley.";
                pictureBox1.Image = ArekTextAdventureV3.Properties.Resources.alley;
                backOut.Text = "Back Out";
                backOut.Location = new Point(331, 320);
                backOut.Size = new Size(94, 29);
                runIn.Text = "Run in";
                runIn.Location = new Point(431, 320);
                runIn.Size = new Size(94, 29);
                state = "begin";
            }
            else if (state == "begin")
            {

                label1.Text = "You try to back out of the alley, but find that a Brick wall has solidified behind you, blocking your way. \nAs you go into the alley, you notice a hole.";

                //setting it up for the next use of the button
                pictureBox1.Image = ArekTextAdventureV3.Properties.Resources.hole;
                backOut.Size = new Size(105, 30);
                runIn.Size = new Size(120, 30);
                runIn.Text = "Try to jump over it";
                backOut.Location = new Point(320, 320);
                backOut.Text = "Climb into the hole";
                state = "brick wall";
            }
            else if (state == "brick wall")
            {
                label1.Text = "You Climb into the hole, and find you are in a room with a single chair. Sitting in the Chair, you find you are instantly transported onto an empty street. As you walk down the road, you find a house. Inside, you find a table with a single mirror, facedown.";
                // setting it up for the other one 
                pictureBox1.Image = ArekTextAdventureV3.Properties.Resources.mirror;
                backOut.Text = "Pick it up";
                runIn.Text = "Leave the House";
                state = "block";
            }
            else if (state == "block")
            {
                label1.Text = "You pick up the mirror, and in a flash of light you are transported back to the alley, but the brick wall has been removed. You are free.";
                pictureBox1.Image = ArekTextAdventureV3.Properties.Resources.gameover;
                backOut.Text = "Play Again";
                runIn.Text = "Exit";
                state = "exit";
            }
            else if (state == "exit")
            {
                //label1.Text = "You try to back out of the alley, but find that a Brick wall has solidified behind you, blocking your way. \nAs you go into the alley, you notice a hole.";

                ////setting it up for the next use of the button
                //pictureBox1.Image = ArekTextAdventureV3.Properties.Resources.hole;
                //backOut.Size = new Size(105, 30);
                //runIn.Size = new Size(120, 30);
                //runIn.Text = "Try to jump over it";
                //backOut.Location = new Point(320, 320);
                //backOut.Text = "Climb into the hole";
                //state = "brick wall";
                state = "load";

            }

        }

        private void runIn_Click(object sender, EventArgs e)
        {

            if (state == "begin")
            {
                label1.Text = "You run blindly into the alley and fall down into a hole. Getting up, you realize you are in a room with a single chair. Sitting in the Chair, you find you are instantly transported onto an empty street. As you walk down the road, you find a house. Inside, you find a table with a single mirror, facedown.";
                backOut.Text = "Pick it up";
                runIn.Text = "Leave the House";
                state = "block";
            }
            else if (state == "brick wall")
            {
                label1.Text = "You try to jump over the hole, but find that it is too big. As you get up from falling in the hole, you find a single chair. \nSitting in the chair, you are instantly transported onto an empty street. Walking along the street, you find a single house, and inside you find a single mirror, facedown.";
                pictureBox1.Image = ArekTextAdventureV3.Properties.Resources.mirror;
                // setting it up for the next use 
                backOut.Text = "Pick it up";
                runIn.Text = "Leave the House.";
                state = "block";
            }
            else if (state == "block")
            {
                label1.Text = "You turn around to leave, but find that the door and the rest of the house has disappeared, trapping you inside. As you pick up the mirror there is a brilliant flash of light, and you are teleported back in front of the alley from before, only now the brick wall barricading you has been removed. You're free.";
                pictureBox1.Image = ArekTextAdventureV3.Properties.Resources.gameover;
                backOut.Text = "Play Again";
                runIn.Text = "Exit";
                state = "exit";
            }
            else if (state == "exit")
            {
                Application.Exit();
            }

        }


    }
}