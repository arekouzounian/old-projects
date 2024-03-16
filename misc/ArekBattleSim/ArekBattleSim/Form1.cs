using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArekBattleSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ArekBattleSim.Properties.Resources.fightStance1;
            myHP.Value = 100;
            oppHP.Value = 100;
        }
        Random gen = new Random();
        bool myTurn = true;
        private void punch_Click(object sender, EventArgs e)
        {
            if (myTurn)
            {
                pictureBox1.Image = ArekBattleSim.Properties.Resources.Punch;
                int currentOppHP = oppHP.Value - gen.Next(1, 13);
                if (currentOppHP <= 0)
                {
                    MessageBox.Show("You Win!");
                    Application.Exit();
                }
                else 
                {
                    oppHP.Value = currentOppHP;
                }
                myTurn = false;
            }
            CpuTimer.Enabled = true;
        }

        private void kick_Click(object sender, EventArgs e)
        {
            if (myTurn)
            {
                pictureBox1.Image = ArekBattleSim.Properties.Resources.Kick;
                int currentOppHP = oppHP.Value - gen.Next(1, 13);
                if (currentOppHP <= 0)
                {
                    MessageBox.Show("You Win!");
                    Application.Exit();
                }
                else
                {
                    oppHP.Value = currentOppHP;
                }
                myTurn = false;
            }
            CpuTimer.Enabled = true;
        }

        private void CpuTimer_Tick(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                int compChoice = gen.Next(1, 3);
                if (compChoice == 1)
                {
                    int currentHP = myHP.Value - gen.Next(1, 9);
                    if (currentHP <= 0)
                    {
                        MessageBox.Show("You Lose!");
                        Application.Exit();
                    }
                    else 
                    {
                        myHP.Value = currentHP;
                    }
                    pictureBox1.Image = ArekBattleSim.Properties.Resources.CPUPunch;
                    cpuDoneTimer.Enabled = true;

                    
                }
                else if (compChoice == 2)
                {
                    int currentHP = myHP.Value - gen.Next(1, 13);
                    if (currentHP <= 0)
                    {
                        MessageBox.Show("You Lose!");
                        Application.Exit();
                    }
                    else 
                    {
                        myHP.Value = currentHP;
                    }
                    pictureBox1.Image = ArekBattleSim.Properties.Resources.CPUKick;
                    cpuDoneTimer.Enabled = true;
                }
                
            }
            CpuTimer.Enabled = false;
        }

        private void cpuDoneTimer_Tick(object sender, EventArgs e)
        {
            cpuDoneTimer.Enabled = false;
            myTurn = true;
            pictureBox1.Image = ArekBattleSim.Properties.Resources.fightStance1;
        }
    }
}
