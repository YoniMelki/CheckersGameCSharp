using System;
using System.Drawing;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Checker : Form
    {
        private readonly int r_ButtonSize = 50;
        private Board m_MyBoard;
        private Label m_Player1;
        private Label m_Player2;
        public Button[,] m_BtnGrid;

        public delegate void OnClickEvenHandler(Point i_ButtonLocation, EventArgs i_Args);

        public new event OnClickEvenHandler OnClick;

        public Checker(Board i_Board)
        {
            m_MyBoard = i_Board;
            m_BtnGrid = new Button[m_MyBoard.Size, m_MyBoard.Size];
            m_MyBoard.OnBoardChange += BoardChanged;
            InitializeComponent();
            populateGrid();
            UpdateBoard();
        }

        public Board Board
        {
            get { return m_MyBoard; }
            set { m_MyBoard = value; }
        }

        public Button[,] Grid
        {
            get { return m_BtnGrid; }
        }

        public Label Player1Label
        {
            get { return m_Player1; }
            set { m_Player1 = value; }
        }

        public Label Player2Label
        {
            get { return m_Player2; }
            set { m_Player2 = value; }
        }

        public int ScorePlayer1
        {
            get { return int.Parse(Player1Score.Text); }
            set { Player1Score.Text = value.ToString(); }
        }

        public int ScorePlayer2
        {
            get { return int.Parse(Player2Score.Text); }
            set { Player2Score.Text = value.ToString(); }
        }

        private void populateGrid()
        {
            for (int i = 0; i < m_MyBoard.Size; i++)
            {
                for (int j = 0; j < m_MyBoard.Size; j++)
                {
                    m_BtnGrid[i, j] = new Button
                    {
                        Height = r_ButtonSize,
                        Width = r_ButtonSize
                    };
                    m_BtnGrid[i, j].Click += Grid_Button_Click;
                    Controls.Add(m_BtnGrid[i, j]);
                    m_BtnGrid[i, j].Location = new Point(j * r_ButtonSize, (i * r_ButtonSize) + 50);
                    m_BtnGrid[i, j].Tag = new Point(j, i);

                    if ((i % 2 == 0 && j % 2 == 1) || (i % 2 == 1 && j % 2 == 0))
                    {
                        m_BtnGrid[i, j].BackColor = Color.NavajoWhite;
                    }
                    else
                    {
                        m_BtnGrid[i, j].BackColor = Color.SaddleBrown;
                        m_BtnGrid[i, j].Enabled = false;
                    }
                }
            }
        }

        private void Grid_Button_Click(object i_Sender, EventArgs i_Event)
        {
            Button clickedButton = i_Sender as Button;
            Point currentLocation = (Point)clickedButton.Tag;

            clickedButton.BackColor = Color.LightBlue;

            OnClick?.Invoke(currentLocation, EventArgs.Empty);
        }

        public void BoardChanged(object i_Sender, EventArgs i_Event)
        {
            UpdateBoard();
        }

        public void UpdateBoard()
        {
            for (int i = 0; i < m_MyBoard.Size; i++)
            {
                for (int j = 0; j < m_MyBoard.Size; j++)
                {
                    if (m_MyBoard.Grid[i, j].PawnInCell)
                    {
                        if (m_MyBoard.Grid[i, j].Sign == Cell.eCellSign.PawnX)
                        {
                            Grid[i, j].BackgroundImage = Properties.Resources.whitePawn;
                        }
                        else if (m_MyBoard.Grid[i, j].Sign == Cell.eCellSign.PawnO)
                        {
                            Grid[i, j].BackgroundImage = Properties.Resources.blackPawn;
                        }
                        else if (m_MyBoard.Grid[i, j].Sign == Cell.eCellSign.KingX)
                        {
                            Grid[i, j].BackgroundImage = Properties.Resources.whiteKing;
                        }
                        else if (m_MyBoard.Grid[i, j].Sign == Cell.eCellSign.KingO)
                        {
                            Grid[i, j].BackgroundImage = Properties.Resources.blackKing;
                        }
                    }
                    else if (m_MyBoard.Grid[i, j].Sign == Cell.eCellSign.Empty)
                    {
                        Grid[i, j].BackgroundImage = null;
                        Grid[i, j].Text = @" ";
                    }

                    if (Grid[i, j].BackColor == Color.LightBlue)
                    {
                        Grid[i, j].BackColor = Color.NavajoWhite;
                    }
                }
            }
        }

        private void Checker_Load(object i_Sender, EventArgs i_Event)
        {
        }

        private void label2_Click(object i_Sender, EventArgs i_Event)
        {
        }

        private void Player1_Click(object i_Sender, EventArgs i_Event)
        {
        }

        private void label4_Click(object i_Sender, EventArgs i_Event)
        {
        }
    }
}
