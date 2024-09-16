using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Form1 : Form
    {
        Bird bird;
        Pillar[] pillars;
        Graphics g;
        Image flappybirdimage;

        int speedOfPillars = 6;
        int acceleration = 2;
        int pillarEndindex = 0;
        int pillarScoreindex = 0;

        int pillarWidth = 70;
        int pillarHeight = 180;
        int pillarSpacing = 200;

        int playerscore;
        int scorePR = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set background
            BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Flappy_bird.Properties.Resources.background;

            DoubleBuffered = true;
            timer1.Enabled = false;

            flappybirdimage = Flappy_bird.Properties.Resources.flappy_bird;

            this.CenterToScreen();
        }

        private void StartGamebtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Hide();
            StartGamebtn.Enabled = false;
            StartGamebtn.Hide();
            HighScorelbl.Hide();

            bird = new Bird(ClientSize.Width / 4, ClientSize.Height / 2, 20);
            playerscore = 0;

            pillarEndindex = 0;
            pillarScoreindex = 0;

            pillars = new Pillar[6];
            Random rand = new Random();
            for (int i = 0; i < pillars.Length; i++)
            {
                pillars[i] = new Pillar(i * pillarSpacing + ClientSize.Width, rand.Next(50, ClientSize.Height - 230), pillarWidth, pillarHeight);
            }

            timer1.Enabled = true;
            Scorelbl.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Move();
            bird.ChangeYspeed(acceleration);
            Invalidate();
            for (int i = 0; i < pillars.Length; i++)
            {
                pillars[i].MovePillar(speedOfPillars);
                if (bird.hitbox.IntersectsWith(pillars[i].top_boundary) || bird.hitbox.IntersectsWith(pillars[i].bottom_boundary) || bird.hitbox.Top < 0 || bird.hitbox.Bottom > ClientSize.Height)
                {
                    timer1.Enabled = false;
                    if (playerscore > scorePR)
                    {
                        scorePR = playerscore;
                    }
                    
                    MessageBox.Show("game over");
                    ResetMenu();
                    break;
                }
            }

            //score points
            if (pillars[pillarScoreindex % 6].middle_boundary.Right < ClientSize.Width / 4) 
            {
                playerscore++;
                pillarScoreindex++;
            }

            //cycle infinte pillars;
            if (pillars[pillarEndindex % 6].middle_boundary.Right < 0)
            {
                Random rand = new Random();
                pillars[pillarEndindex % 6] = new Pillar(pillarSpacing * 6 + pillars[pillarEndindex % 6].middle_boundary.Left, rand.Next(50, ClientSize.Height - 230), pillarWidth, pillarHeight);
                pillarEndindex++;
            }

            //update score label during game
            Scorelbl.Text = Convert.ToString(playerscore);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (timer1.Enabled)
            {
                g = e.Graphics;
                //g.FillEllipse(Brushes.Gold, bird.x - bird.radius, bird.y - bird.radius, bird.radius * 2, bird.radius * 2);

                for (int i = 0; i < pillars.Length; i++)
                {
                    //g.FillRectangle(Brushes.Green, pillars[i].top_boundary);
                    //g.FillRectangle(Brushes.Green, pillars[i].bottom_boundary);

                    Bitmap Pipe = new (Flappy_bird.Properties.Resources.pipe, pillars[i].bottom_boundary.Width, pillars[i].bottom_boundary.Height);
                    Pipe.MakeTransparent();
                    g.DrawImage(Pipe, pillars[i].bottom_boundary);

                    
                    Pipe.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    g.DrawImage(Pipe, pillars[i].top_boundary);
                }

                float angleRad = -MathF.Atan2(-bird.vy, speedOfPillars + 15);
                float angleDeg = angleRad*(360/(2*MathF.PI));
                Bitmap btmp = new Bitmap(flappybirdimage, bird.radius*2, bird.radius*2);
                btmp.MakeTransparent();
                g.TranslateTransform(bird.x, bird.y);
                g.RotateTransform(angleDeg);
                g.TranslateTransform(-bird.x, -bird.y);

                g.DrawImage(btmp, bird.x - bird.radius, bird.y - bird.radius);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled)
            {
                if (e.KeyCode == Keys.Space)
                {
                    bird.vy = -18;
                }
            }
        }
        private void ResetMenu()
        {
            StartGamebtn.Enabled = true;
            StartGamebtn.Show();
            Titlelbl.Show();
            HighScorelbl.Show();
            Scorelbl.Hide();

            HighScorelbl.Text = Convert.ToString($"High score: {scorePR}");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    bird.vy = -18;
                }
            }
        }
    }
}
