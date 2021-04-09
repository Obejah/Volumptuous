using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumptuous
{
    public partial class FlappyBird : Form
    {
        bool gameover = false;

        int gamespeed = 5;
        int pipespeed = 10;
        int gravity = 8;
        int scorer1 = 0;
        int scorer2 = 0;
        int scorer3 = 0;
        int score = 0;
        int lives = 3;
        int totalscore = 0;
        int idlespeed = 5;
        public FlappyBird()
        {
            InitializeComponent();
        }

        private void endgame()
        {
            if (gameover = true)
            {
                timer1.Stop();
             

            }
            timer1.Enabled = false;

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity -= gravity;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Lives: " + lives;

            Player.Top += gravity;
            //Pipe1.Left -= pipespeed;
            //Pipe2.Left -= pipespeed;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Pipe")

                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        lives = lives - 1;
                        timer1.Stop();
                        label2.Text = "press space to reset";
                    }
            }

            if (score == gamespeed)
            {
                pipespeed++;
                gamespeed = gamespeed + 2;
            }

            if (lives == 0)
            {
                gameover = true;
            }
        }

        private void idle_Tick(object sender, EventArgs e)
        {
            Player.Top -= idlespeed;
            if (Player.Top < 300)
            {
                idlespeed = -idlespeed;
            }
            Player.Top -= idlespeed;
            if (Player.Top < 600)
            {
                idlespeed = -idlespeed;
            }
            Ground.Left -= pipespeed;

            if(Ground.Left < -185)
            {
                Ground.Left = 0;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            idle.Stop();
            timer1.Start();
            Start.Hide();
            Leaderboards.Hide();
            Exit.Hide();
        }

        private void Volomptuous_Load(object sender, EventArgs e)
        {

        }
    }
}
