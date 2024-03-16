namespace ArekBattleSim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.punch = new System.Windows.Forms.Button();
            this.kick = new System.Windows.Forms.Button();
            this.myHP = new System.Windows.Forms.ProgressBar();
            this.oppHP = new System.Windows.Forms.ProgressBar();
            this.CpuTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cpuDoneTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attacks:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Battle!";
            // 
            // punch
            // 
            this.punch.Location = new System.Drawing.Point(323, 374);
            this.punch.Name = "punch";
            this.punch.Size = new System.Drawing.Size(80, 28);
            this.punch.TabIndex = 2;
            this.punch.Text = "Punch";
            this.punch.UseVisualStyleBackColor = true;
            this.punch.Click += new System.EventHandler(this.punch_Click);
            // 
            // kick
            // 
            this.kick.Location = new System.Drawing.Point(487, 374);
            this.kick.Name = "kick";
            this.kick.Size = new System.Drawing.Size(80, 28);
            this.kick.TabIndex = 3;
            this.kick.Text = "Kick";
            this.kick.UseVisualStyleBackColor = true;
            this.kick.Click += new System.EventHandler(this.kick_Click);
            // 
            // myHP
            // 
            this.myHP.Location = new System.Drawing.Point(192, 24);
            this.myHP.Name = "myHP";
            this.myHP.Size = new System.Drawing.Size(100, 23);
            this.myHP.TabIndex = 5;
            this.myHP.Value = 100;
            // 
            // oppHP
            // 
            this.oppHP.Location = new System.Drawing.Point(605, 24);
            this.oppHP.Name = "oppHP";
            this.oppHP.Size = new System.Drawing.Size(100, 23);
            this.oppHP.TabIndex = 6;
            this.oppHP.Value = 100;
            // 
            // CpuTimer
            // 
            this.CpuTimer.Interval = 1000;
            this.CpuTimer.Tick += new System.EventHandler(this.CpuTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ArekBattleSim.Properties.Resources.fightStance1;
            this.pictureBox1.Location = new System.Drawing.Point(192, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 257);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cpuDoneTimer
            // 
            this.cpuDoneTimer.Interval = 1000;
            this.cpuDoneTimer.Tick += new System.EventHandler(this.cpuDoneTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.oppHP);
            this.Controls.Add(this.myHP);
            this.Controls.Add(this.kick);
            this.Controls.Add(this.punch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Battle Simulator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button punch;
        private System.Windows.Forms.Button kick;
        private System.Windows.Forms.ProgressBar myHP;
        private System.Windows.Forms.ProgressBar oppHP;
        private System.Windows.Forms.Timer CpuTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer cpuDoneTimer;
    }
}

