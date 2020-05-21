using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Media;

namespace GameBot2048
{
    public partial class GameForm : Form        
    {
        Label[,] labels;
        static ArrayList arrList = new ArrayList();
        Random rand = new Random();
        public GameForm()
        {
            InitializeComponent();
            GameSettingsForm GameSettings = new GameSettingsForm();
            GameSettings.ShowDialog();
            labels = new Label[MyClass.Rows, MyClass.Columns];
            CreateMap();
            AddNewCells2Or4();
            AddNewCells2Or4();
            UpdateTemplate();
            timer1.Interval = MyClass.Speed;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        public void CreateMap()
                {
                    int sizeWidth = 60;
                    int sizeHeight = 60;
                    if (labels.GetLength(0) > 13)
                    {
                        sizeWidth = 45;
                        sizeHeight = 45;
                    }
                    Width = (MyClass.Columns * sizeWidth) + ((MyClass.Columns + 1) * 10) + 16;
                    Height = (MyClass.Rows * sizeHeight) + (MyClass.Rows + 1) * 10 + 119;
                    for (int i = 0; i < labels.GetLength(0); i++)
                    {
                        for (int j = 0; j < labels.GetLength(1); j++)
                        {
                            labels[i, j] = new Label();
                            labels[i, j].Location = new Point(10 + (sizeWidth + 10) * j, 90 + (sizeHeight + 10) * i);
                            labels[i, j].Size = new Size(sizeWidth, sizeHeight);
                            labels[i, j].Text = "";
                            labels[i, j].TextAlign = ContentAlignment.MiddleCenter;
                            this.Controls.Add(labels[i, j]);
                        }
                    }
                }
        public void UpdateTemplate()
        {
            for (int i = 0; i < labels.GetLength(0); i++)
            {
                for (int j = 0; j < labels.GetLength(1); j++)
                {
                    if (labels[i, j].Text == "")
                    {
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
                    }
                    if (labels[i, j].Text == "2")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "4")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(198)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "8")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(177)))), ((int)(((byte)(121)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "16")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(84)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "32")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(124)))), ((int)(((byte)(95)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "64")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "128")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(114)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "256")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(75)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "512")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "1024")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 12);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(186)))), ((int)(((byte)(20)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "2048")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 12);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "4096")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 12);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "8192")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 12);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "16384")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 10);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(68)))), ((int)(((byte)(61)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "32768")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 10);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "65536")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 10);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(229)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                    if (labels[i, j].Text == "131072")
                    {
                        labels[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 10);
                        labels[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(194)))));
                        labels[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
                    }
                }
            }
        }
        public void AddNewCells2Or4()
        {
            arrList.Clear();
            for (int i = 0; i < labels.GetLength(0); i++)
            {
                for (int j = 0; j < labels.GetLength(1); j++)
                {
                    if (labels[i, j].Text == "")
                    {
                        arrList.Add(i * labels.GetLength(1) + j + 1);
                    }
                }
            }

            if (arrList.Count > 0)
            {
                int randomCell = int.Parse(arrList[rand.Next(0, arrList.Count)].ToString());
                int i0 = (randomCell - 1) / labels.GetLength(1);
                int j0 = (randomCell - 1) - i0 * labels.GetLength(1);
                int random = rand.Next(1, 11);
                if (random <= 9)
                {
                    labels[i0, j0].Text = "2";
                }
                else
                {
                    labels[i0, j0].Text = "4";
                }
            }
            UpdateTemplate();
        }
        public bool FinishGame() 
        {
            for (int i = 0; i < labels.GetLength(0); i++)
            {
                for (int j = 0; j < labels.GetLength(1); j++)
                {
                    if (labels[i, j].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < labels.GetLength(1); k++)
                    {
                        if (labels[i, j].Text != "")
                        {
                            if (labels[i, j].Text == labels[i, k].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < labels.GetLength(1); i++)
            {
                for (int j = 0; j < labels.GetLength(0); j++)
                {
                    if (labels[j, i].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < labels.GetLength(0); k++)
                    {
                        if (labels[k, i].Text != "")
                        {
                            if (labels[j, i].Text == labels[k, i].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            return true;
        }
        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (FinishGame() == true)     
        //    {
        //        if (e.KeyCode == Keys.Up)
        //        {
        //            SwapUp();
        //        }
        //        if (e.KeyCode == Keys.Down)
        //        {
        //            SwapDown();
        //        }
        //        if (e.KeyCode == Keys.Left)
        //        {
        //            SwapLeft();
        //        }
        //        if (e.KeyCode == Keys.Right)
        //        {
        //            SwapRight();
        //        }
        //    }
        //     else
        //     {
        //         lblGameOver.Visible = true;	
		//		   btnNewGame.Visible = true;
		//		   btnNewGame.Enabled = true;
		//		   btnExit.Visible = true;
		//		   btnExit.Enabled = true;
		//		   timer1.Enabled = false;
        //         this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        //     }
        //}
        public void SwapUp() 
        {
            bool kTraKhoiTao = false;
            for (int i = 0; i < labels.GetLength(1); i++)
            {
                int oRong = 0;
                for (int j = 0; j < labels.GetLength(0); j++)
                {
                    if (labels[j, i].Text == "")
                    {
                        oRong++;
                    }
                    else
                    {
                        for (int m = j; m >= 0; m--)
                        {
                            if (labels[m, i].Text == "")
                            {
                                kTraKhoiTao = true;
                                break;
                            }
                        }
                        if (j + 1 < labels.GetLength(0))
                        {
                            bool ktra = true;

                            for (int k = j + 1; k < labels.GetLength(0); k++)
                            {
                                if (labels[k, i].Text != "")
                                {
                                    if (labels[j, i].Text == labels[k, i].Text)
                                    {
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(labels[j, i].Text) * 2).ToString();
                                        kTraKhoiTao = true;
                                        ktra = false;
                                        labels[j, i].Text = (int.Parse(labels[j, i].Text) * 2).ToString();
                                        if (oRong != 0)
                                        {
                                            labels[j - oRong, i].Text = labels[j, i].Text;
                                            labels[j, i].Text = "";

                                        }
                                        labels[k, i].Text = "";
                                        break;
                                    }
                                    break;
                                }
                            }
                            if (ktra == true && oRong != 0)
                            {    
                                labels[j - oRong, i].Text = labels[j, i].Text;
                                labels[j, i].Text = "";
                            }
                        }
                        else
                        {
                            if (oRong != 0)
                            {
                                labels[j - oRong, i].Text = labels[j, i].Text;
                                labels[j, i].Text = "";
                            }
                        }
                    }
                }
            }
            if (kTraKhoiTao == true)
            {
                AddNewCells2Or4();
                AddNewCells2Or4();
            }
        }
        public void SwapDown() 
        {
            bool kTraKhoiTao = false;
            for (int i = 0; i < labels.GetLength(1); i++)
            {
                int oRong = 0;
                for (int j = labels.GetLength(0)-1; j >= 0; j--)
                {
                    if (labels[j, i].Text == "")
                    {
                        oRong++;
                    }
                    else
                    {
                        for (int m = j + 1; m <= labels.GetLength(0) - 1; m++)
                        {
                            if (labels[m, i].Text == "")
                            {
                                kTraKhoiTao = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool ktra = true;

                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labels[k, i].Text != "")
                                {
                                    if (labels[j, i].Text == labels[k, i].Text)
                                    {
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(labels[j, i].Text) * 2).ToString();
                                        kTraKhoiTao = true;
                                        ktra = false;
                                        labels[j, i].Text = (int.Parse(labels[j, i].Text) * 2).ToString();
                                        if (oRong != 0)
                                        {
                                            labels[j + oRong, i].Text = labels[j, i].Text;
                                            labels[j, i].Text = "";
                                        }
                                        labels[k, i].Text = "";
                                        break;
                                    }
                                    break;
                                }
                            }
                            if (ktra == true && oRong != 0)
                            {
                                labels[j + oRong, i].Text = labels[j, i].Text;
                                labels[j, i].Text = "";
                            }
                        }
                        else
                        {
                            if (oRong != 0)
                            {
                                labels[j + oRong, i].Text = labels[j, i].Text;
                                labels[j, i].Text = "";
                            }
                        }
                    }
                }
            }
            if (kTraKhoiTao == true)
            {
                AddNewCells2Or4();
                AddNewCells2Or4();
            }
        }
        public void SwapLeft() 
        {
            bool kTraKhoiTao = false;
            for (int i = 0; i < labels.GetLength(0); i++)
            {
                int oRong = 0;
                for (int j = 0; j < labels.GetLength(1); j++)
                {
                    if (labels[i, j].Text == "")
                    {
                        oRong++;
                    }
                    else
                    {
                        for (int m = j - 1; m >= 0; m--)
                        {
                            if (labels[i, m].Text == "")
                            {
                                kTraKhoiTao = true;
                                break;
                            }
                        }
                        if (j + 1 < labels.GetLength(1))
                        {
                            bool ktra = true;
                            for (int k = j + 1; k < labels.GetLength(1); k++)
                            {
                                if (labels[i, k].Text != "")
                                {
                                    if (labels[i, j].Text == labels[i, k].Text)
                                    {
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(labels[i, j].Text) * 2).ToString();
                                        kTraKhoiTao = true;
                                        ktra = false;
                                        labels[i, j].Text = (int.Parse(labels[i, j].Text) * 2).ToString();
                                        if (oRong != 0)
                                        {
                                            labels[i, j - oRong].Text = labels[i, j].Text;
                                            labels[i, j].Text = "";
                                        }
                                        labels[i, k].Text = "";
                                        break;
                                    }
                                    break;
                                }
                            }
                            if (ktra == true && oRong != 0)
                            {
                                labels[i, j - oRong].Text = labels[i, j].Text;
                                labels[i, j].Text = "";
                            }
                        }
                        else
                        {
                            if (oRong != 0)
                            {
                                labels[i, j - oRong].Text = labels[i, j].Text;
                                labels[i, j].Text = "";
                            }
                        }
                    }
                }
            }
            if (kTraKhoiTao == true)
            {
                AddNewCells2Or4();
                AddNewCells2Or4();
            }
        }
        public void SwapRight() 
        {
            bool kTraKhoiTao = false;
            for (int i = 0; i < labels.GetLength(0); i++)
            {
                int oRong = 0;
                for (int j = labels.GetLength(1) - 1; j >= 0; j--)
                {
                    if (labels[i, j].Text == "")
                    {
                        oRong++;
                    }
                    else
                    {
                        for (int m = j + 1; m < labels.GetLength(1); m++)
                        {
                            if (labels[i, m].Text == "")
                            {
                                kTraKhoiTao = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool ktra = true;
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labels[i, k].Text != "")
                                {
                                    if (labels[i, j].Text == labels[i, k].Text)
                                    {
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(labels[i, j].Text) * 2).ToString();
                                        kTraKhoiTao = true;
                                        ktra = false;
                                        labels[i, j].Text = (int.Parse(labels[i, j].Text) * 2).ToString();
                                        if (oRong != 0)
                                        {
                                            labels[i, j + oRong].Text = labels[i, j].Text;
                                            labels[i, j].Text = "";
                                        }
                                        labels[i, k].Text = "";
                                        break;
                                    }
                                    break;
                                }
                            }
                            if (ktra == true && oRong != 0)
                            {
                                labels[i, j + oRong].Text = labels[i, j].Text;
                                labels[i, j].Text = "";
                            }
                        }
                        else
                        {
                            if (oRong != 0)
                            {
                                labels[i, j + oRong].Text = labels[i, j].Text;
                                labels[i, j].Text = "";

                            }
                        }
                    }
                }
            }
            if (kTraKhoiTao == true)
            {
                AddNewCells2Or4();
                AddNewCells2Or4();
            }
        }
		private void timer1_Tick(object sender, EventArgs e)
		{
				if (FinishGame() == false)
				{
					string lbScore2 = Convert.ToString(lblScore);
					SwapLeft();
					SwapDown();
                    if (lbScore2 == Convert.ToString(lblScore))
                    {
                        bool k = false;
                        for (int i = 0; i < labels.GetLength(0); i++)
                        {
                            for (int j = 0; j < labels.GetLength(1); j++)
                            {
                                if (labels[i, j].Text == "")
                                {
                                    k = true;
                                }
                                break;
                            }
                            break;
                        }
                        if (k == false)
                        {
                            SwapLeft();
                            SwapDown();
                            if (lbScore2 == Convert.ToString(lblScore))
                            {
                                SwapRight();
                                if (lbScore2 == Convert.ToString(lblScore))
                                {
                                    SwapUp();
                                }
                            }
                        }
                    }
				}
			else
			{
				lblGameOver.Visible = true;	
				btnNewGame.Visible = true;
				btnNewGame.Enabled = true;
				btnExit.Visible = true;
				btnExit.Enabled = true;
				timer1.Enabled = false;
			}
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int sizeWidth = (Width - 16 - (MyClass.Columns + 1) * 10) / MyClass.Columns;
            int sizeHeight = (Height - 119 - (MyClass.Rows + 1) * 10) / MyClass.Rows;
            for (int i = 0; i < labels.GetLength(0); i++)
            {
                for (int j = 0; j < labels.GetLength(1); j++)
                {
                    labels[i, j].Location = new Point(10 + (sizeWidth + 10) * j, 90 + (sizeHeight + 10) * i);
                    labels[i, j].Size = new Size(sizeWidth, sizeHeight);
                    this.Controls.Add(labels[i, j]);
                }
            }

            lblGameOver.Font = new Font(new FontFamily("Tahoma"), Width / 8);
            lblGameOver.Location = new Point(0, Height / 4);
            lblGameOver.Size = new System.Drawing.Size(Width, Height / 3);
            btnNewGame.Size = new System.Drawing.Size((Width / 2) - 22, 90);
            btnNewGame.Location = new Point(10, Height - 90 - 48);
            btnExit.Size = new System.Drawing.Size((Width / 2) - 22, 90);
            btnExit.Location = new Point(Width - ((Width / 2) - 22) - 25, Height - 90 - 48);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
	}
}

