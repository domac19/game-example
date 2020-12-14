
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.littleGuy = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.littleGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // littleGuy
            // 
            this.littleGuy.Image = ((System.Drawing.Image)(resources.GetObject("littleGuy.Image")));
            this.littleGuy.Location = new System.Drawing.Point(61, 42);
            this.littleGuy.Name = "littleGuy";
            this.littleGuy.Size = new System.Drawing.Size(51, 52);
            this.littleGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.littleGuy.TabIndex = 0;
            this.littleGuy.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(1, 268);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(439, 60);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // bottomPipe
            // 
            this.bottomPipe.Image = ((System.Drawing.Image)(resources.GetObject("bottomPipe.Image")));
            this.bottomPipe.Location = new System.Drawing.Point(302, 208);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(100, 54);
            this.bottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomPipe.TabIndex = 2;
            this.bottomPipe.TabStop = false;
            // 
            // topPipe
            // 
            this.topPipe.Image = ((System.Drawing.Image)(resources.GetObject("topPipe.Image")));
            this.topPipe.Location = new System.Drawing.Point(302, 2);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(100, 68);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe.TabIndex = 3;
            this.topPipe.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(13, 12);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(99, 27);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTimerevent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(442, 330);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.littleGuy);
            this.Name = "Form1";
            this.Text = "Vježba";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.littleGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox littleGuy;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTime;
    }
}

