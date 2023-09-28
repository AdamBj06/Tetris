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

        public int Score;
        public int Lines;

        public Form1() //30 pixel = 1;
        {
            InitializeComponent();
            NextBlock = Block.Next(1, 8);
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
                Bl = NextBlock;
                switch (Bl)
                {
                    case 1: //long
                        PosXL = 5; PosXR = 5;
                        PosY = 3; OldY = 3;
                        break;
                    case 2: //l right
                        PosXL = 4; PosXR = 6;
                        PosY = 1; OldY = 1;
                        break;
                    case 3: //l left
                        PosXL = 4; PosXR = 6;
                        PosY = 1; OldY = 1;
                        break;
                    case 4: //square
                        PosXL = 4; PosXR = 5;
                        PosY = 1; OldY = 1;
                        break;
                    case 5: //z right
                        PosXL = 4; PosXR = 6;
                        PosY = 1; OldY = 1;
                        break;
                    case 6: //z left
                        PosXL = 4; PosXR = 6;
                        PosY = 1; OldY = 1;
                        break;
                    case 7: //t
                        PosXL = 4; PosXR = 6;
                        PosY = 1; OldY = 1;
                        break;
                    default:
                        break;
                }

                pictureBoxNB[0, 0].BackColor = Color.Transparent;
                pictureBoxNB[0, 1].BackColor = Color.Transparent;
                pictureBoxNB[1, 0].BackColor = Color.Transparent;
                pictureBoxNB[1, 1].BackColor = Color.Transparent;
                pictureBoxNB[1, 2].BackColor = Color.Transparent;
                pictureBoxNB[2, 0].BackColor = Color.Transparent;
                pictureBoxNB[2, 1].BackColor = Color.Transparent;
                pictureBoxNB[2, 2].BackColor = Color.Transparent;
                pictureBoxNB[3, 1].BackColor = Color.Transparent;
                NextBlock = Block.Next(1, 8);
                switch (NextBlock) 
                {
                    case 1: //long
                        pictureBoxNB[0, 1].BackColor = Color.LightBlue;
                        pictureBoxNB[1, 1].BackColor = Color.LightBlue;
                        pictureBoxNB[2, 1].BackColor = Color.LightBlue;
                        pictureBoxNB[3, 1].BackColor = Color.LightBlue;
                        break;
                    case 2: //l right
                        pictureBoxNB[1, 0].BackColor = Color.Blue;
                        pictureBoxNB[2, 0].BackColor = Color.Blue;
                        pictureBoxNB[2, 1].BackColor = Color.Blue;
                        pictureBoxNB[2, 2].BackColor = Color.Blue;
                        break;
                    case 3: //l left
                        pictureBoxNB[1, 2].BackColor = Color.Orange;
                        pictureBoxNB[2, 0].BackColor = Color.Orange;
                        pictureBoxNB[2, 1].BackColor = Color.Orange;
                        pictureBoxNB[2, 2].BackColor = Color.Orange;
                        break;
                    case 4: //square
                        pictureBoxNB[0, 0].BackColor = Color.Yellow;
                        pictureBoxNB[0, 1].BackColor = Color.Yellow;
                        pictureBoxNB[1, 0].BackColor = Color.Yellow;
                        pictureBoxNB[1, 1].BackColor = Color.Yellow;
                        break;
                    case 5: //z right
                        pictureBoxNB[1, 1].BackColor = Color.Green;
                        pictureBoxNB[1, 2].BackColor = Color.Green;
                        pictureBoxNB[2, 0].BackColor = Color.Green;
                        pictureBoxNB[2, 1].BackColor = Color.Green;
                        break;
                    case 6: //z left
                        pictureBoxNB[1, 0].BackColor = Color.Purple;
                        pictureBoxNB[1, 1].BackColor = Color.Purple;
                        pictureBoxNB[2, 1].BackColor = Color.Purple;
                        pictureBoxNB[2, 2].BackColor = Color.Purple;
                        break;
                    case 7: //t
                        pictureBoxNB[1, 1].BackColor = Color.Red;
                        pictureBoxNB[2, 0].BackColor = Color.Red;
                        pictureBoxNB[2, 1].BackColor = Color.Red;
                        pictureBoxNB[2, 2].BackColor = Color.Red;
                        break;
                    default:
                        break;
                }
            }

            if (PosY >= 20)
            {
                Empty = false;
            }
            else if (Bl == 1)
            {
                if(pictureBox[PosY, PosXL].BackColor != Color.Transparent)
                {
                    Empty = false;
                }
                else
                {
                    Empty = true;
                }
            }
            else if (Bl == 5)
            {
                if (pictureBox[PosY, PosXL].BackColor != Color.Transparent || pictureBox[PosY, PosXL + 1].BackColor != Color.Transparent || pictureBox[PosY - 1, PosXR].BackColor != Color.Transparent)
                {
                    Empty = false;
                }
                else
                {
                    Empty = true;
                }
            }
            else if (Bl == 6)
            {
                if (pictureBox[PosY - 1, PosXL].BackColor != Color.Transparent || pictureBox[PosY, PosXR - 1].BackColor != Color.Transparent || pictureBox[PosY, PosXR].BackColor != Color.Transparent)
                {
                    Empty = false;
                }
                else
                {
                    Empty = true;
                }
            }
            else if (pictureBox[PosY, PosXL].BackColor != Color.Transparent || pictureBox[PosY, PosXR - 1].BackColor != Color.Transparent || pictureBox[PosY, PosXR].BackColor != Color.Transparent) 
            {
                Empty = false;
            }
            else
            {
                Empty = true;
            }

            if (Empty)
            {
                OldY++;
                switch (Bl)
                {
                    case 1: //long
                        pictureBox[0 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[2 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[3 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        break;
                    case 2: //l right
                        pictureBox[0 + OldY - 1, 4 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 4 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 6 + OldX].BackColor = Color.Transparent;
                        break;
                    case 3: //l left
                        pictureBox[0 + OldY - 1, 6 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 4 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 6 + OldX].BackColor = Color.Transparent;
                        break;
                    case 4: //square
                        pictureBox[0 + OldY - 1, 4 + OldX].BackColor = Color.Transparent;
                        pictureBox[0 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 4 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        break;
                    case 5: //z right
                        pictureBox[0 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[0 + OldY - 1, 6 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 4 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        break;
                    case 6: //z left
                        pictureBox[0 + OldY - 1, 4 + OldX].BackColor = Color.Transparent;
                        pictureBox[0 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 6 + OldX].BackColor = Color.Transparent;
                        break;
                    case 7: //t
                        pictureBox[0 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 4 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 5 + OldX].BackColor = Color.Transparent;
                        pictureBox[1 + OldY - 1, 6 + OldX].BackColor = Color.Transparent;
                        break;
                }

                switch (Bl)
                {
                    case 1: //long
                        pictureBox[0 + PosY - 3, 5 + X].BackColor = Color.LightBlue;
                        pictureBox[1 + PosY - 3, 5 + X].BackColor = Color.LightBlue;
                        pictureBox[2 + PosY - 3, 5 + X].BackColor = Color.LightBlue;
                        pictureBox[3 + PosY - 3, 5 + X].BackColor = Color.LightBlue;
                        OldY = PosY - 3;
                        OldX = X;
                        break;
                    case 2: //l right
                        pictureBox[0 + PosY - 1, 4 + X].BackColor = Color.Blue;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Blue;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Blue;
                        pictureBox[1 + PosY - 1, 6 + X].BackColor = Color.Blue;
                        OldY = PosY - 1;
                        OldX = X;
                        break;
                    case 3: //l left
                        pictureBox[0 + PosY - 1, 6 + X].BackColor = Color.Orange;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Orange;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Orange;
                        pictureBox[1 + PosY - 1, 6 + X].BackColor = Color.Orange;
                        OldY = PosY - 1;
                        OldX = X;
                        break;
                    case 4: //square
                        pictureBox[0 + PosY - 1, 4 + X].BackColor = Color.Yellow;
                        pictureBox[0 + PosY - 1, 5 + X].BackColor = Color.Yellow;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Yellow;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Yellow;
                        OldY = PosY - 1;
                        OldX = X;
                        break;
                    case 5: //z right
                        pictureBox[0 + PosY - 1, 5 + X].BackColor = Color.Green;
                        pictureBox[0 + PosY - 1, 6 + X].BackColor = Color.Green;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Green;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Green;
                        OldY = PosY - 1;
                        OldX = X;
                        break;
                    case 6: //z left
                        pictureBox[0 + PosY - 1, 4 + X].BackColor = Color.Purple;
                        pictureBox[0 + PosY - 1, 5 + X].BackColor = Color.Purple;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Purple;
                        pictureBox[1 + PosY - 1, 6 + X].BackColor = Color.Purple;
                        OldY = PosY - 1;
                        OldX = X;
                        break;
                    case 7: //t
                        pictureBox[0 + PosY - 1, 5 + X].BackColor = Color.Red;
                        pictureBox[1 + PosY - 1, 4 + X].BackColor = Color.Red;
                        pictureBox[1 + PosY - 1, 5 + X].BackColor = Color.Red;
                        pictureBox[1 + PosY - 1, 6 + X].BackColor = Color.Red;
                        OldY = PosY - 1;
                        OldX = X;
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
                    pictureBox[y, x].BackColor = Color.Transparent;
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
                    pictureBoxNB[y, x].BackColor = Color.Transparent;
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
