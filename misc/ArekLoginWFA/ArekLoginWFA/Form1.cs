using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArekLoginWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account[] accounts = new Account[3];
        Account loggedInAccount;
        string Case = "login";
        public double moneyAdded = 0;
        public double moneyTaken = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            accounts[0] = new Account("user123", "pass123", 66.17);
            accounts[1] = new Account("user234", "pass234", 123.45);
            accounts[2] = new Account("user345", "pass345", 1000);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //create a for loop and check if the username field contains text that matches 
            //that of an array of usernames, same for password
            bool fail = true;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].Login(userField.Text, passField.Text))
                {
                    loggedInAccount = accounts[i];
                    MessageBox.Show("Login Successful!");
                    loginPanel.Visible = false;
                    loggedInPanel.Visible = true;
                    loggedInPanel.BringToFront();
                    moneyAmtStr.Text = "Money Amount: $" + loggedInAccount.Money;
                    fail = false;
                    break;
                }
            }
            if (fail == true)
            {
                MessageBox.Show("Login Failed!");
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            deWiPanel.Visible = true;
            deWiPanel.BringToFront();
            loggedInPanel.Visible = false;
            deWiLabel.Text = "How much money would you like to deposit?";
            deWiMoneyAmt.Text = "Money Amount: $" + loggedInAccount.Money;
            Case = "deposit";
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            deWiPanel.Visible = true;
            deWiPanel.BringToFront();
            loggedInPanel.Visible = false;
            deWiLabel.Text = "How much money would you like to withdraw?";
            deWiMoneyAmt.Text = "Money Amount: $" + loggedInAccount.Money;
            Case = "withdraw";
        }
        private void submitAmt_Click(object sender, EventArgs e)
        {
            if (Case == "deposit")
            {
                moneyAdded = double.Parse(textBox1.Text);
                loggedInAccount.Deposit(moneyAdded);
                moneyAmtStr.Text = "Money Amount: $" + loggedInAccount.Money;
                MessageBox.Show("Deposit Successful!");
                loggedInPanel.Visible = true;
                loggedInPanel.BringToFront();
                deWiPanel.Visible = false;
            }
            else if (Case == "withdraw")
            {
                moneyTaken = double.Parse(textBox1.Text);
                loggedInAccount.Withdraw(moneyTaken);
                moneyAmtStr.Text = "Money Amount: $" + loggedInAccount.Money;
                MessageBox.Show("Withdrawal Successful!");
                loggedInPanel.Visible = true;
                loggedInPanel.BringToFront();
                deWiPanel.Visible = false;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //loggedInPanel.Visible = false;
            //deWiPanel.Visible = false;
            loginPanel.Visible = true;
            loginPanel.BringToFront();
            userField.Text = "";
            passField.Text = "";
            registerButton.Visible = true;
        }
        //Account[] newAccount = new Account[accounts.Length + 1];
        private void registerButton_Click(object sender, EventArgs e)
        {
            bool duplicateFound = false;
            for (int i = 0; i < accounts.Length; i++)
            {
                if(userField.Text == accounts[i].Username)
                {
                    duplicateFound = true;
                    break;
                }
            }

            //if duplicate found
            if (duplicateFound == true)
            {
                MessageBox.Show("Registration Failed! Username is taken.");
            }
            else if (duplicateFound == false)
            {
                label2.Visible = true;
                label1.Visible = false;
                button1.Visible = true;
                registerButton.Visible = false;
                Account[] newAccount = new Account[accounts.Length + 1];
                for (int i = 0; i < accounts.Length; i++)
                {
                    newAccount[i] = accounts[i];
                }
                newAccount[newAccount.Length - 1] = new Account(userField.Text, passField.Text, 0);
                accounts = newAccount;
                loginPanel.Visible = true;
                loginPanel.BringToFront();
            }
        }
    }
}
