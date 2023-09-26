using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 2 schermate:
 *  impostazioni per cambiare i pulsanti, volume, colori(forse);
 *  difficolta;
 */
namespace Tetris
{
    public partial class Form1 : Form
    {
        public PictureBox[,] pictureBox = new PictureBox[20, 10];
        public PictureBox[,] pictureBoxNB = new PictureBox[4, 3];
        public Random Block = new Random(); //7 blocks
        public int Bl;
        public int NextBlock;

        public int VelocityY = 1;
        public int PosXL;
        public int PosXR;
        public int X=0;
        public int OldY = 0;
        public int OldX = 0;
        public int PosY;
        public bool Empty = false;

        public bool KeyDown_Down = false;

        public int Score;
        public int Lines;
        public Form1() //30 pixel = 1;
        {
            InitializeComponent();
        }

        #region Movement
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.LButton)
            {
            }
            if (e.KeyCode == Keys.E || e.KeyCode == Keys.RButton)
            {
            }
            //
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (PosXL!= 0)
                {
                    X--;
                    PosXL--;
                    PosXR--;
                }
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if(PosXR!= 9)
                {
                    X++;
                    PosXL++;
                    PosXR++;
                }
            }
            //
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                timer1.Interval = 33;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Interval = 1000;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Empty)
            {
                X = 0; OldX = 0; OldY = 0;
                Bl = Block.Next(1, 8);
                switch (Bl)
                {
                    case 1:
                        PosXL = 5; PosXR = 5;
                        PosY = 3;
                        break;
                    case 2:
                        PosXL = 4; PosXR = 6;
                        PosY = 1;
                        break;
                    case 3:
                        PosXL = 4; PosXR = 6;
                        PosY = 1;
                        break;
                    case 4:
                        PosXL = 4; PosXR = 5;
                        PosY = 1;
                        break;
                    case 5:
                        PosXL = 4; PosXR = 6;
                        PosY = 1;
                        break;
                    case 6:
                        PosXL = 4; PosXR = 6;
                        PosY = 1;
                        break;
                    case 7:
                        PosXL = 4; PosXR = 6;
                        PosY = 1;
                        break;
                    default:
                        break;
                }
            }

            if (PosY == 19)
            {
                Empty = true;
            }
            else if (PosY >= 20)
            {
                Empty = false;
            }
            else if (pictureBox[PosY + 1, PosXL].BackColor != Color.Transparent || pictureBox[PosY + 1, PosXL + 1].BackColor != Color.Transparent || pictureBox[PosY + 1, PosXR].BackColor != Color.Transparent) 
            {
                Empty = true;
            }
            else
            {
                Empty = false;
            }

            if (Empty)
            {
                if (4 + OldX != -1)
                {
                    pictureBox[OldY, 4 + OldX].BackColor = Color.Transparent;
                    pictureBox[1 + OldY, 4 + OldX].BackColor = Color.Transparent;
                }    
                pictureBox[OldY, 5 + OldX].BackColor = Color.Transparent;
                if(6 + OldX != 10)
                {
                    pictureBox[OldY, 6 + OldX].BackColor = Color.Transparent;
                    pictureBox[1 + OldY, 6 + OldX].BackColor = Color.Transparent;
                }
                pictureBox[1 + OldY, 5 + OldX].BackColor = Color.Transparent;
                if(3 + OldY != 20)
                {
                    pictureBox[2 + OldY, 5 + OldX].BackColor = Color.Transparent;
                    pictureBox[3 + OldY, 5 + OldX].BackColor = Color.Transparent;
                }
                OldX = X;

                switch (Bl)
                {
                    case 1:
                        pictureBox[0 + PosY - 3, 5 + X].BackColor = Color.LightBlue;
                        pictureBox[1 + PosY - 3, 5 + X].BackColor = Color.LightBlue;
                        pictureBox[2 + PosY - 3, 5 + X].BackColor = Color.LightBlue;
                        pictureBox[3 + PosY - 3, 5 + X].BackColor = Color.LightBlue;
                        OldY = PosY - 3;
                        break;
                    case 2:
                        pictureBox[0 + PosY - 1, 4 + X].BackColor = Color.Blue;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Blue;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Blue;
                        pictureBox[1 + PosY - 1, 6 + X].BackColor = Color.Blue;
                        OldY = PosY - 1;
                        break;
                    case 3:
                        pictureBox[0 + PosY - 1, 6 + X].BackColor = Color.Orange;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Orange;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Orange;
                        pictureBox[1 + PosY - 1, 6 + X].BackColor = Color.Orange;
                        OldY = PosY - 1;
                        break;
                    case 4:
                        pictureBox[0 + PosY - 1, 4 + X].BackColor = Color.Yellow;
                        pictureBox[0 + PosY - 1, 5 + X].BackColor = Color.Yellow;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Yellow;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Yellow;
                        OldY = PosY - 1;
                        break;
                    case 5:
                        pictureBox[0 + PosY - 1, 5 + X].BackColor = Color.Green;
                        pictureBox[0 + PosY - 1, 6 + X].BackColor = Color.Green;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Green;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Green;
                        OldY = PosY - 1;
                        break;
                    case 6:
                        pictureBox[0 + PosY - 1, 4 + X].BackColor = Color.Purple;
                        pictureBox[0 + PosY - 1, 5 + X].BackColor = Color.Purple;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Purple;
                        pictureBox[1 + PosY - 1, 6 + X].BackColor = Color.Purple;
                        OldY = PosY - 1;
                        break;
                    case 7:
                        pictureBox[0 + PosY - 1, 5 + X].BackColor = Color.Red;
                        pictureBox[0 + PosY - 1, 4 + X].BackColor = Color.Red;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Red;
                        pictureBox[1 + PosY - 1, 6 + X].BackColor = Color.Red;
                        OldY = PosY - 1;
                        break;
                }
                PosY++;
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            int xl = 0, yl = 0;
            for(int y = 0;y < 20; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    pictureBox[y, x] = new PictureBox();
                    pictureBox[y, x].Size = new Size(30, 30);
                    pictureBox[y, x].Location = new Point(175+30*xl, 60+30*yl);
                    this.Controls.Add(pictureBox[y, x]);
                    xl++;
                }
                xl = 0; yl++;
            }
            xl = 0; yl = 0;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    pictureBoxNB[y, x] = new PictureBox();
                    pictureBoxNB[y, x].Size = new Size(30, 30);
                    pictureBoxNB[y, x].Location = new Point(35+30*xl,90+30*yl);
                    this.Controls.Add(pictureBoxNB[y, x]);
                    xl++;
                }
                xl = 0; yl++;
            }
        }
    }
}

/*
 long:
  pictureBoxNB[0, 1].BackColor = Color.LightBlue;
  pictureBoxNB[1, 1].BackColor = Color.LightBlue;
  pictureBoxNB[2, 1].BackColor = Color.LightBlue;
  pictureBoxNB[3, 1].BackColor = Color.LightBlue;
 
 l to the right:
  pictureBoxNB[1, 0].BackColor = Color.Blue;
  pictureBoxNB[2, 0].BackColor = Color.Blue;
  pictureBoxNB[2, 1].BackColor = Color.Blue;
  pictureBoxNB[2, 2].BackColor = Color.Blue;

 l to the left:
  pictureBoxNB[1, 2].BackColor = Color.Orange;
  pictureBoxNB[2, 0].BackColor = Color.Orange;
  pictureBoxNB[2, 1].BackColor = Color.Orange;
  pictureBoxNB[2, 2].BackColor = Color.Orange;

 square:
  pictureBoxNB[0, 0].BackColor = Color.Yellow;
  pictureBoxNB[0, 1].BackColor = Color.Yellow;
  pictureBoxNB[1, 0].BackColor = Color.Yellow;
  pictureBoxNB[1, 1].BackColor = Color.Yellow;

 z to the left:
  pictureBoxNB[1, 1].BackColor = Color.Green;
  pictureBoxNB[1, 2].BackColor = Color.Green;
  pictureBoxNB[2, 0].BackColor = Color.Green;
  pictureBoxNB[2, 1].BackColor = Color.Green;

 z to the right:
  pictureBoxNB[1, 0].BackColor = Color.Purple;
  pictureBoxNB[1, 1].BackColor = Color.Purple;
  pictureBoxNB[2, 1].BackColor = Color.Purple;
  pictureBoxNB[2, 2].BackColor = Color.Purple;

 t:
  pictureBoxNB[1, 1].BackColor = Color.Red;
  pictureBoxNB[2, 0].BackColor = Color.Red;
  pictureBoxNB[2, 1].BackColor = Color.Red;
  pictureBoxNB[2, 2].BackColor = Color.Red;
 */