using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy__Cockerel
{
    public partial class FlappyBird : Form
    {
        public FlappyBird()
        {
            InitializeComponent();
            startButton.TabStop = false;
            
        }
        // default pipe speed
        public int boruHizi = 8;

        //default gravity speed
        public int gravity =10;

        //score
        public  int skor = 0;

        bool start = false; // Oyun başlamadı

        private void gameTimerEvent(object sender, EventArgs e)
        {
           

            skor_label1.Text = "SCORE:" + skor;
            flappyBirdpictureBox.Top += gravity;
            boru_alt__pictureBox.Left -= boruHizi;
            boru_ust_pictureBox.Left -= boruHizi;
 

            if(boru_alt__pictureBox.Left<-150)
            {
                boru_alt__pictureBox.Left = 650;
                skor++;
            }

            if(boru_ust_pictureBox.Left<-150)
            {

                boru_ust_pictureBox.Left = 650;
                skor++;

            }

            if(flappyBirdpictureBox.Bounds.IntersectsWith(boru_alt__pictureBox.Bounds)|| flappyBirdpictureBox.Bounds.IntersectsWith(boru_ust_pictureBox.Bounds)|| flappyBirdpictureBox.Bounds.IntersectsWith(zemin_pictureBox.Bounds))
            {
                endGame();

            }
           

        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {

                gravity = -10;
            }
        }

        private void FlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }



        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            game_timer.Stop(); // stop the main timer
            skor_label1.Text = "GAME OVER";
            gameOverpictureBox.Visible = true;
        }

       

        private void FlappyBird_Load(object sender, EventArgs e)
        {
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            game_timer.Start();
            startButton.Enabled = false; // Butonun etkileşimini devre dışı bırak
            startButton.Visible = false;
        }
    }
}
