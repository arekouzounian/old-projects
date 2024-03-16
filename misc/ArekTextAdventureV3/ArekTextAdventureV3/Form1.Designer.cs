namespace ArekTextAdventureV3
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
            this.label1 = new System.Windows.Forms.Label();
            this.backOut = new System.Windows.Forms.Button();
            this.runIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Enter a Dark Alley.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backOut
            // 
            this.backOut.Location = new System.Drawing.Point(331, 320);
            this.backOut.Name = "backOut";
            this.backOut.Size = new System.Drawing.Size(94, 29);
            this.backOut.TabIndex = 2;
            this.backOut.Text = "Back Out";
            this.backOut.UseVisualStyleBackColor = true;
            this.backOut.Click += new System.EventHandler(this.backOut_Click);
            // 
            // runIn
            // 
            this.runIn.Location = new System.Drawing.Point(431, 320);
            this.runIn.Name = "runIn";
            this.runIn.Size = new System.Drawing.Size(97, 29);
            this.runIn.TabIndex = 3;
            this.runIn.Text = "Run In";
            this.runIn.UseVisualStyleBackColor = true;
            this.runIn.Click += new System.EventHandler(this.runIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArekTextAdventureV3.Properties.Resources.alley;
            this.pictureBox1.Location = new System.Drawing.Point(285, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(842, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runIn);
            this.Controls.Add(this.backOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backOut;
        private System.Windows.Forms.Button runIn;
        private System.Windows.Forms.Timer timer1;
    }
}

