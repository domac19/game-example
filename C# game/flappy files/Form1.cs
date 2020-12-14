using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerevent(object sender, EventArgs e)
        {
            littleGuy.Top += gravity;
            bottomPipe.Left -= pipeSpeed;
            topPipe.Left -= pipeSpeed;
            scoreText.Text = "Score:" + score;
            
            if(bottomPipe.Left < -50)
                {
                bottomPipe.Left = 800;
                score++;
                }
            if (topPipe.Left < -80)
            {
                topPipe.Left = 950;
                score++;
            }
            if (littleGuy.Bounds.IntersectsWith(bottomPipe.Bounds) ||
                (littleGuy.Bounds.IntersectsWith(topPipe.Bounds) ||
                (littleGuy.Bounds.IntersectsWith(ground.Bounds))))
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 15;
            }
            if(littleGuy.Top < -25)
            {
                endGame();
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;

            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;

            }
        }
        private void endGame()
        {
            gameTime.Stop();
            scoreText.Text += "GAME OVER !!!";
        }
    }
}
