using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    public partial class Form2 : Form
    {
        Timer gameTimer = new Timer();

        int ballspeed = 6;
        int ballDx = 1;
        int ballDy = 1;
        int lives = 5;
        int score = 0;

        bool do_this_once = false;
        bool gameover = false;        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            picBall.Left = (ClientRectangle.Width - picBall.Width) / 2;
            picBall.Top = 375;

            LblLives.Text = Convert.ToString(lives);
            lblscore.Text = Convert.ToString(score);
        }


        private void movePaddle(int newXposition)
        {
            if (newXposition < 0)
                newXposition = 0;
            else if (newXposition > ClientRectangle.Width - picPaddle.Width)
                newXposition = ClientRectangle.Width - picPaddle.Width;

            picPaddle.Left = newXposition;
        }

        private void moveBall(int newXpos, int newYpos)
        {
            picBall.Left = newXpos;
            picBall.Top = newYpos;
        }


        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            movePaddle(e.X);
        }

        private void picBall_Click(object sender, EventArgs e)
        {

        }



        private void picPaddle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            picBall.Left = picBall.Left + ballspeed * ballDx;
            picBall.Top = picBall.Top + ballspeed * ballDy;

            if (picBall.Left < 0 || picBall.Left > ClientRectangle.Width - picBall.Width)
                ballDx = -ballDx;
            if (picBall.Top < 0 || picBall.Top > ClientRectangle.Height - picBall.Height)
                ballDy = -ballDy;

            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds))
            {
                ballDy = -ballDy;
            }


            if (BrickBlue1.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlue1.Bounds))
                {
                   if (picBall.Bounds.IntersectsWith(BrickBlue1.Bounds))
                        ballDy = -ballDy;

                    BrickBlue1.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickBlue2.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlue2.Bounds))
                {                     
                    if (picBall.Bounds.IntersectsWith(BrickBlue2.Bounds))
                        ballDy = -ballDy;

                    BrickBlue2.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }
            if (BrickBlue3.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlue3.Bounds))
                {
                    if (picBall.Bounds.IntersectsWith(BrickBlue3.Bounds))
                        ballDy = -ballDy;

                    BrickBlue3.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickBlue4.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlue4.Bounds))
                {                     
                    if (picBall.Bounds.IntersectsWith(BrickBlue4.Bounds))
                        ballDy = -ballDy;

                    BrickBlue4.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickBlue5.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlue5.Bounds))
                {
                    if (picBall.Bounds.IntersectsWith(BrickBlue5.Bounds))
                        ballDy = -ballDy;

                    BrickBlue5.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }
            if (BrickRed1.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickRed1.Bounds))
                {                    
                    if (picBall.Bounds.IntersectsWith(BrickRed1.Bounds))
                        ballDy = -ballDy;

                    BrickRed1.Visible = false;

                    score = (score + 20);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickRed2.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickRed2.Bounds))
                {                 
                    if (picBall.Bounds.IntersectsWith(BrickRed2.Bounds))
                        ballDy = -ballDy;

                    BrickRed2.Visible = false;

                    score = (score + 20);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickRed2.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickRed2.Bounds))
                {
                    if (picBall.Bounds.IntersectsWith(BrickRed2.Bounds))
                        ballDy = -ballDy;

                    BrickRed2.Visible = false;

                    score = (score + 20);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickRed3.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickRed3.Bounds))
                {                    
                    if (picBall.Bounds.IntersectsWith(BrickRed3.Bounds))
                        ballDy = -ballDy;

                    BrickRed3.Visible = false;

                    score = (score + 20);
                    lblscore.Text = Convert.ToString(score);
                }

            }

            if (BrickRed4.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickRed4.Bounds))
                {                     
                   if (picBall.Bounds.IntersectsWith(BrickRed4.Bounds))
                        ballDy = -ballDy;

                    BrickRed4.Visible = false;

                    score = (score + 20);
                    lblscore.Text = Convert.ToString(score);
                }

            }

            if (BrickRed5.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickRed5.Bounds))
                { 
                    if (picBall.Bounds.IntersectsWith(BrickRed5.Bounds))
                        ballDy = -ballDy;

                    BrickRed5.Visible = false;

                    score = (score + 20);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickGreen1.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickGreen1.Bounds))
                {                     
                    if (picBall.Bounds.IntersectsWith(BrickGreen1.Bounds))
                        ballDy = -ballDy;

                    BrickGreen1.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickGreen2.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickGreen2.Bounds))
                {                    
                    if (picBall.Bounds.IntersectsWith(BrickGreen2.Bounds))
                        ballDy = -ballDy;

                    BrickGreen2.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickGreen3.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickGreen3.Bounds))
                {
                    if (picBall.Bounds.IntersectsWith(BrickGreen3.Bounds))
                        ballDy = -ballDy;

                    BrickGreen3.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickGreen4.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickGreen4.Bounds))
                {
                   if (picBall.Bounds.IntersectsWith(BrickGreen4.Bounds))
                        ballDy = -ballDy;

                    BrickGreen4.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickGreen5.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickGreen5.Bounds))
                {
                    if (picBall.Bounds.IntersectsWith(BrickGreen5.Bounds))
                        ballDy = -ballDy;

                    BrickGreen5.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickYellow1.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickYellow1.Bounds))
                {
                    if (picBall.Bounds.IntersectsWith(BrickYellow1.Bounds))
                        ballDy = -ballDy;

                    BrickYellow1.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickYellow2.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickYellow2.Bounds))
                {
                    if (picBall.Bounds.IntersectsWith(BrickYellow2.Bounds))
                        ballDy = -ballDy;

                    BrickYellow2.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }


            if (BrickYellow3.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickYellow3.Bounds))
                {                     
                    if (picBall.Bounds.IntersectsWith(BrickYellow3.Bounds))
                        ballDy = -ballDy;

                    BrickYellow3.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickYellow4.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickYellow4.Bounds))
                {                    
                    if (picBall.Bounds.IntersectsWith(BrickYellow4.Bounds))
                        ballDy = -ballDy;

                    BrickYellow4.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickYellow5.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickYellow5.Bounds))
                {                    
                    if (picBall.Bounds.IntersectsWith(BrickYellow5.Bounds))
                        ballDy = -ballDy;

                    BrickYellow5.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickBlack1.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlack1.Bounds))
                {
                    if (picBall.Bounds.IntersectsWith(BrickBlack1.Bounds))
                        ballDy = -ballDy;

                    BrickBlack1.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickBlack2.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlack2.Bounds))
                {                    
                    if (picBall.Bounds.IntersectsWith(BrickBlack2.Bounds))
                        ballDy = -ballDy;

                    BrickBlack2.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickBlack3.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlack3.Bounds))
                {                     
                    if (picBall.Bounds.IntersectsWith(BrickBlack3.Bounds))
                        ballDy = -ballDy;

                    BrickBlack3.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickBlack4.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlack4.Bounds))
                {                     
                    if (picBall.Bounds.IntersectsWith(BrickBlack4.Bounds))
                        ballDy = -ballDy;

                    BrickBlack4.Visible = false;

                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);
                }
            }

            if (BrickBlack5.Visible == true)
            {
                if (picBall.Bounds.IntersectsWith(BrickBlack5.Bounds)) 
                {                       
                     if (picBall.Bounds.IntersectsWith(BrickBlack5.Bounds))
                        ballDy = -ballDy;

                    BrickBlack5.Visible = false;
                    
                    score = (score + 10);
                    lblscore.Text = Convert.ToString(score);

                }
            }

            if (true/*do_this_once == false*/)
            {
                if (score == 50 && do_this_once == false)
                {

                    lives = lives + 1;
                    LblLives.Text = Convert.ToString(lives);
                    do_this_once = true;
                }


                if (lives <= 0 && gameover == false)
                {                     
                    Gameover();
                    picBall.Visible = false;
                    gameover = true;
                }


                if (score >= 300 && gameover == false)
                {
                    Gameover();
                    picBall.Visible = false;
                    gameover = true;
                } 

            }

            Point pt = picBall.Location;

            if (pt.Y > ClientRectangle.Height - picBall.Height)
            {
                moveBall((ClientRectangle.Width - picBall.Width) / 2, 375);
                lives -= 1;
                LblLives.Text = Convert.ToString(lives);

            }
                              
    }

        private void Gameover()
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
