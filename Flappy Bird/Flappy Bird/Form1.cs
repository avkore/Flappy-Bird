using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        

        int PipeSpeed = 7;
        int Gravity = 10;
        int Score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += Gravity;
            BottomPipe.Left -= PipeSpeed;
            TopPipe.Left -= PipeSpeed;
            BottomPipe1.Left -= PipeSpeed;
            TopPipe1.Left -= PipeSpeed;
            Star.Left -= PipeSpeed;
            label1.Text = "Score -> " + Score.ToString();
            

            if (Star.Right < 0)
            {
                Random Obj1 = new Random();
                Star.Left = Obj1.Next(650, 800);
                Star.Top = Obj1.Next(100, 500);
                Star.Visible = true;
            }

            if (Star.Bounds.IntersectsWith(TopPipe.Bounds) ||
               Star.Bounds.IntersectsWith(BottomPipe.Bounds) ||
               Star.Bounds.IntersectsWith(TopPipe1.Bounds) ||
               Star.Bounds.IntersectsWith(BottomPipe1.Bounds) ||
               Star.Bounds.IntersectsWith(Ground.Bounds))
                Star.Visible = false;

            if(Bird.Bounds.IntersectsWith(Star.Bounds))
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\avkor\source\repos\Flappy Bird\FlappyBirdResources/sfx_point.wav");
                player1.Play();

                Random Obj1 = new Random();
                Score += 5;
                Star.Left = Obj1.Next(650, 800);
                Star.Top = Obj1.Next(100, 500);
            }
               

            if (BottomPipe.Right < 0)
            {
                Random Obj1 = new Random();
                BottomPipe.Height = Obj1.Next(190, 250);
                BottomPipe.Left = Obj1.Next(450, 480);
                Score++;
            }

            if (BottomPipe1.Right < 0)
            {
                Random Obj1 = new Random();
                BottomPipe1.Height = Obj1.Next(190, 250);
                BottomPipe1.Left = Obj1.Next(450, 480);
                Score++;
            }


            if (TopPipe.Right < 0)
            {
                Random Obj1 = new Random();
                TopPipe.Height = Obj1.Next(150, 220);
                TopPipe.Left = Obj1.Next(450, 490);
            }

            if (TopPipe1.Right < 0)
            {
                Random Obj1 = new Random();
                TopPipe1.Height = Obj1.Next(150, 220);
                TopPipe1.Left = Obj1.Next(450, 490);
            }


            if (Bird.Bounds.IntersectsWith(TopPipe.Bounds) || 
               Bird.Bounds.IntersectsWith(BottomPipe.Bounds) ||
               Bird.Bounds.IntersectsWith(Ground.Bounds))
                EndGame();

            if(Bird.Top < -2)
                EndGame();

        }

        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                Gravity = -9;
            }
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                Gravity = 10;
            }

        }

        private void EndGame()
        {
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\avkor\source\repos\Flappy Bird\FlappyBirdResources/Game_Over.wav");
            player1.Play();
            Game_Over.Visible = true;
            Bird.Hide();
            GameTimer.Stop();
        }
    }
}
