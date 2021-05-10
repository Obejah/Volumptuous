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
        int gravity = 10;
        int score = 0;
        int lives = 3;
        int totalscore = 0;
        int idlespeed = 5;
        int i;


        Random rndHeight = new Random();

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
            
            if (e.KeyCode == Keys.E)
            {
                gravity = 10;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                gravity = -10;
            }
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Lives: " + lives;
            Scores.Text = "" + score;

            Player.Top += gravity;
            PipeTop1.Left -= pipespeed;
            PipeBottom1.Left -= pipespeed;
            PipeTop2.Left -= pipespeed;
            PipeBottom2.Left -= pipespeed;
            Ground.Left -= pipespeed;

            if (Ground.Left < -185)
            {
                Ground.Left = 0;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Pipe")

                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                    totalscore = totalscore + score;
                    lives = lives - 1;
                    timer1.Stop();
                    label2.Text = "press space to reset";
                    score = 0;
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
            if(Player.Top < -100)
            {
                Player.Top = -99;
            }
            if (PipeTop1.Left < -30)
            {
                PipeTop1.Height = rndHeight.Next(200, 600);
                PipeTop1.Left = 700;
            }
            if(PipeBottom1.Left < -30)
            {
                PipeBottom1.Left = 700;
                PipeBottom1.Top = PipeTop1.Bottom + 155;
                score++;
            }
            if (PipeTop2.Left < -30)
            {
                PipeTop2.Height = rndHeight.Next(200, 600);
                PipeTop2.Left = 700;
            }
            if (PipeBottom2.Left < -30)
            {
                PipeBottom2.Left = 700;
                PipeBottom2.Top = PipeTop2.Bottom + 155;
                score++;
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
            Start.Enabled = false;
            Leaderboards.Enabled = false;
            Exit.Enabled = false;
            PipeBottom1.Location = new Point(677, 361);
            PipeTop1.Location = new Point(677, -122);
            PipeTop1.Height = rndHeight.Next(200, 600);/*makes the height of the first pipes random*/
            PipeBottom1.Top = PipeTop1.Bottom + 155;
            PipeTop2.Height = rndHeight.Next(200, 600);/*makes the height of the first pipes random*/
            PipeBottom2.Top = PipeTop2.Bottom + 155;
            PipeTop1.Visible = true;
            PipeBottom1.Visible = true;
        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PipeBottom2_Click(object sender, EventArgs e)
        {

        }
    }
}
