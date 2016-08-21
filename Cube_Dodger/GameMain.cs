using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cube_Dodger
{
    public partial class GameMain : Form
    {
        enum PlayerPosition
        {
            Left, Right
        }

        private int score;

        /* Localization (loc) of player */
        private int locXplayer;
        private int locYplayer;

        /* Position (pos) of enemy (cube) */
        private int posXenemy1;
        private int posYenemy1;
        private int posXenemy2;
        private int posYenemy2;
        private int posXenemy3;
        private int posYenemy3;
        private int posXenemy4;
        private int posYenemy4;

        private PlayerPosition playerPos;

        public GameMain()
        {
            InitializeComponent();

            Random randomPosEnemy = new Random();
            Cursor.Hide();
            score = 0;
            this.BackColor = System.Drawing.Color.White;

            /* Center of screen
            400 is width of playground
            50 is width of player's cube
            so
            400 / 2 = 200
            50 / 2 = 25
            200 - 25 = 175
            */
            locXplayer = 175;
            locYplayer = 550;

            /* Positions of enemies */
            posXenemy1 = randomPosEnemy.Next(10, 50);
            posYenemy1 = randomPosEnemy.Next(50, 150);
            posXenemy2 = randomPosEnemy.Next(120, 200);
            posYenemy2 = randomPosEnemy.Next(50, 150);
            posXenemy3 = randomPosEnemy.Next(300, 330);
            posYenemy3 = randomPosEnemy.Next(50, 150);
            posXenemy4 = randomPosEnemy.Next(200, 280);
            posYenemy4 = randomPosEnemy.Next(50, 150);

        }

        private void timerMoving_Enemy(object sender, EventArgs e)
        {
            Random randomPos = new Random();
            if (posYenemy1 < 700)
            {
                posYenemy1 += 4;
                /* Better is Rectangle.Intersect method */
                /*if((locYplayer >= posYenemy1 && locYplayer <= (posYenemy1 + sizeYenemy1)) && ((locXplayer + 50) >= posXenemy1 && (locXplayer + 50) <= (posXenemy1 + sizeXenemy1)) || locXplayer >= posXenemy1 && locXplayer <= (posXenemy1 + sizeXenemy1))
                {
                    //some code;
                } */
            }
            else if (posYenemy1 >= 700)
            {
                score += 1;
                posYenemy1 = randomPos.Next(50, 200);
                scoreDynamic_label.Text = score.ToString();
            }
            Invalidate();
        }

        private void timerMoving_Enemy2(object sender, EventArgs e)
        {
            Random randomPos = new Random();
            if (posYenemy2 < 700)
            {
                posYenemy2 += 3;
            }
            else if (posYenemy2 >= 700)
            {
                score += 1;
                posYenemy2 = randomPos.Next(50, 200);
                scoreDynamic_label.Text = score.ToString();
            }
            Invalidate();
        }

        private void timerMoving_Enemy3(object sender, EventArgs e)
        {
            Random randomPos = new Random();
            if (posYenemy3 < 700)
            {
                posYenemy3 += 5;
            }
            else if (posYenemy3 >= 700)
            {
                score += 1;
                posYenemy3 = randomPos.Next(50, 200);
                scoreDynamic_label.Text = score.ToString();
            }
            Invalidate();
        }

        private void timerMoving(object sender, EventArgs e)
        {
            Random randomColor = new Random();

            if(playerPos == PlayerPosition.Right)
            {
                if (locXplayer <= 335) /* 335 is X localization of right border */
                {
                    locXplayer += 3; /* How fast our player is */
                    dubstepTxt_label.Visible = false;
                }
                else
                {
                    dubstepTxt_label.Visible = true;
                    this.BackColor = Color.FromArgb(randomColor.Next(150, 255), randomColor.Next(150, 255), randomColor.Next(150, 255));
                }
            }
            else if(playerPos == PlayerPosition.Left)
            {
                if (locXplayer >= 0) /* 0 is X localization of left border */
                {
                    locXplayer -= 3; /* How fast our player is */
                    dubstepTxt_label.Visible = false;
                }
                else
                {
                    dubstepTxt_label.Visible = true;
                    this.BackColor = Color.FromArgb(randomColor.Next(150, 255), randomColor.Next(150, 255), randomColor.Next(150, 255));
                }
            }       
            
            Invalidate(); /* Start from beginning */
        }

        private void GameMain_Paint(object sender, PaintEventArgs e)
        {
            Random randomPos = new Random();

            Rectangle player = new Rectangle(locXplayer, locYplayer, 50, 50);
            Rectangle enemy1 = new Rectangle(posXenemy1, posYenemy1, 50, 70);
            Rectangle enemy2 = new Rectangle(posXenemy2, posYenemy2, 50, 50);
            Rectangle enemy3 = new Rectangle(posXenemy3, posYenemy3, 50, 60);

            //e.Graphics.FillRectangle(Brushes.Blue, locXplayer, locYplayer, 50, 50); /* Player's cube */
            e.Graphics.FillRectangle(Brushes.Blue, player);
            e.Graphics.FillRectangle(Brushes.Red, enemy1);
            e.Graphics.FillRectangle(Brushes.Red, enemy2);
            e.Graphics.FillRectangle(Brushes.Red, enemy3);

            if(player.IntersectsWith(enemy1))
            {
                EndMenu();
            }
            else if(player.IntersectsWith(enemy2))
            {
                EndMenu();
            }
            else if(player.IntersectsWith(enemy3))
            {
                EndMenu();
            }
        }

        private void GameMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                playerPos = PlayerPosition.Right;
            }
            else if(e.KeyCode == Keys.Left)
            {
                playerPos = PlayerPosition.Left;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Hide();

            GameMain formMain = new GameMain();
            formMain.ShowDialog();

            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndMenu()
        {
            btnQuit.Visible = true;
            btnRestart.Visible = true;
            Cursor.Show();
            timer1.Enabled = false;
            timerEnemy.Enabled = false;
            timerEnemy2.Enabled = false;
            timerEnemy3.Enabled = false;
            gameOverTxt_label.Visible = true;
        }


    }
}
