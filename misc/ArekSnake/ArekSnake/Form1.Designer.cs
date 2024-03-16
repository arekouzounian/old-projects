namespace ArekSnake
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // drawBox
            // 
            this.drawBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawBox.Location = new System.Drawing.Point(0, 0);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(792, 513);
            this.drawBox.TabIndex = 0;
            this.drawBox.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score.ForeColor = System.Drawing.SystemColors.Control;
            this.score.Location = new System.Drawing.Point(702, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(61, 17);
            this.score.TabIndex = 1;
            this.score.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(792, 513);
            this.Controls.Add(this.score);
            this.Controls.Add(this.drawBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.Label score;
    }
}

