using System;
using System.Windows.Forms;

namespace Checkers
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        public string Player1Name
        {
            get { return Player1TextBox.Text; }
        }

        public string Player2Name
        {
            get { return Player2TextBox.Text; }
        }

        public Board.eBoardDimension Dimension
        {
            get
            {
                Board.eBoardDimension dimension;

                if (smallDim.Checked)
                {
                    dimension = Board.eBoardDimension.Small;
                }
                else if (mediumDim.Checked)
                {
                    dimension = Board.eBoardDimension.Medium;
                }
                else
                {
                    dimension = Board.eBoardDimension.Large;
                }

                return dimension;
            }
        }

        public GameManager.ePlayerType AskOpponent
        {
            get
            {
                GameManager.ePlayerType opponentType;

                if (Player2CheckBox.Checked)
                {
                    opponentType = GameManager.ePlayerType.Human;
                }
                else
                {
                    opponentType = GameManager.ePlayerType.PC;
                }

                return opponentType;
            }
        }

        private void radioButton2_CheckedChanged(object i_Sender, EventArgs i_Event)
        {
        }

        private void textBox1_TextChanged(object i_Sender, EventArgs i_Event)
        {
        }

        private void Done_Click_1(object i_Sender, EventArgs i_Event)
        {
            Close();
            new GameManager(this);
        }

        private void Player2CheckBox_CheckedChanged_1(object i_Sender, EventArgs i_Event)
        {
            Player2TextBox.Enabled = Player2CheckBox.Checked;
        }

        private void Player1TextBox_TextChanged_1(object i_Sender, EventArgs i_Event)
        {
            if (Player1TextBox.Text.Length != 0)
            {
                Done.Enabled = true;
            }
            else
            {
                Done.Enabled = false;
            }
        }
    }
}