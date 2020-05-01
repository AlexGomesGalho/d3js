using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PING_PONG
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;   //Speed of the ball
        public int speed_Top = 4;
        public int points = 0;    //Scored points is zero

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();             //Hide the cursor 

            this.FormBorderStyle = FormBorderStyle.None; //Remove any border
            this.TopMost = true;        //Bring the form to front
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Racket.Top = PlayGround.Bottom - (PlayGround.Bottom / 10);      //Set the postion of the racket


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2); //set the center of the racket to the position of the cursor 
            Ball.Left += speed_left;     //Move the ball
            Ball.Top += speed_Top;

            if (Ball.Bottom >= Racket.Top && Ball.Bottom <= Racket.Bottom && Ball.Left >= Racket.Left && Ball.Right <=Racket.Right) //Racket collission
            {
                speed_Top += 2;
                speed_left += 2;
                speed_Top = -speed_Top;    //Change Direction
                points += 1;
            }

            if(Ball.Left <= PlayGround.Left)
            {
                speed_left = -speed_left;
            }
            if (Ball.Right >= PlayGround.Right)
            {
                speed_left = -speed_left;
            }
            if (Ball.Top <= PlayGround.Top)
            {
                speed_Top = -speed_Top;
            }
           if(Ball.Bottom >= PlayGround.Bottom)
            {
                timer1.Enabled = false; //Ball is out Stop the game
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { this.Close(); } //Press Escape to Quit
        }
    }
}
