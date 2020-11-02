using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Checkers
{
    public class GameManager
    {
        private readonly Random r_RandomGenerator;
        private Board m_GameBoard;
        private Player m_Player1;
        private Player m_Player2;
        private Move m_Move;
        private Checker m_MyChecker;

        public delegate void AnotherRoundEventHandler(bool i_Answer, EventArgs i_Args);

        public event AnotherRoundEventHandler OnAnotherRound;

        public enum ePlayerType
        {
            Human = 1,
            PC = 2
        }

        public enum eGameResult
        {
            Player1Win = 1,
            Player2Win = 2,
            Tie = 3
        }

        public GameManager(GameSettingsForm i_GameSettingsForm)
        {
            m_Move = new Move();
            r_RandomGenerator = new Random();
            play(i_GameSettingsForm);
        }

        private static void calculateSumOfPointsForPlayers(ref Player io_Player1, ref Player io_Player2)
        {
            io_Player1.NumOfPoints += io_Player1.NumOfPawns + (4 * io_Player1.NumOfKings);
            io_Player2.NumOfPoints += io_Player2.NumOfPawns + (4 * io_Player2.NumOfKings);
        }

        private void initializePlayer1(GameSettingsForm i_GameSettingsForm)
        {
            string userName = i_GameSettingsForm.Player1Name;
            m_Player1 = new Player(userName, 0, Cell.eCellSign.PawnX, Cell.eCellSign.KingX)
            {
                Turn = true
            };
        }

        private void initializePlayer2(GameSettingsForm i_GameSettingsForm)
        {
            string userName;
            ePlayerType opponent = i_GameSettingsForm.AskOpponent;

            if (opponent == ePlayerType.Human)
            {
                userName = i_GameSettingsForm.Player2Name;
            }
            else
            {
                userName = "PC";
            }

            m_Player2 = new Player(userName, 0, Cell.eCellSign.PawnO, Cell.eCellSign.KingO)
            {
                Turn = false
            };
        }

        private void initializeBoard(Board.eBoardDimension i_BoardDimension)
        {
            m_GameBoard = new Board(i_BoardDimension);
        }

        public void ButtonClicked(Point i_Location, EventArgs i_Event)
        {
            // if m_Move.IsEmpty -> We are in the first click
            if (m_Move.IsEmpty())
            {
                m_Move.Source = i_Location;
            }
            else
            {
                m_Move.Destination = i_Location;
                if (m_Player1.Turn)
                {
                    if (isLegalMove(m_Player1, m_Move))
                    {
                        giveTurnTo(ref m_Player1, ref m_Player2, m_Move);

                        if (m_Player2.Name == "PC" && !m_Player1.CanEatMore(m_GameBoard, m_Move.Source))
                        {
                            m_Move = choosePcMove(m_Player2);
                            if (!m_Move.IsEmpty())
                            {
                                ButtonClicked(m_Move.Destination, i_Event);
                            }
                        }
                    }
                }
                else
                {
                    if (isLegalMove(m_Player2, m_Move))
                    {
                        giveTurnTo(ref m_Player2, ref m_Player1, m_Move);
                    }
                }

                Player currentPlayer = m_Player1.Turn ? m_Player1 : m_Player2;

                if (isGameOver(currentPlayer))
                {
                    m_MyChecker.UpdateBoard();
                    GameOver(determineGameResult());
                }

                m_Move.MakeEmpty();
                m_MyChecker.UpdateBoard();
            }
        }

        public void GameOver(eGameResult i_Result)
        {
            DialogResult dialogResult;
            if (i_Result == eGameResult.Player1Win)
            {
                 dialogResult = MessageBox.Show($@"{m_Player1.Name} Won! {Environment.NewLine} Another Round?", "Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (i_Result == eGameResult.Player2Win)
            {
                dialogResult = MessageBox.Show($@"{m_Player2.Name} Won! {Environment.NewLine} Another Round?", "Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                dialogResult = MessageBox.Show($@"Tie! {Environment.NewLine} Another Round?", "Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (dialogResult == DialogResult.Yes)
            {
                calculateSumOfPointsForPlayers(ref m_Player1, ref m_Player2);
                m_MyChecker.ScorePlayer1 = m_Player1.NumOfPoints;
                m_MyChecker.ScorePlayer2 = m_Player2.NumOfPoints;

                OnAnotherRound?.Invoke(true, EventArgs.Empty);
            }
            else
            {
                m_MyChecker.Close();
            }
        }

        private bool noMoveLeft(Player i_Player)
        {
            return !i_Player.PossibleEatingMoves(m_GameBoard).Any() && !i_Player.PossibleNonEatingMoves(m_GameBoard).Any();
        }

        private bool isGameOver(Player i_CurrentPlayer)
        {
            return noMoveLeft(i_CurrentPlayer);
        }

        private eGameResult determineGameResult()
        {
            eGameResult gameResult;

            if (noMoveLeft(m_Player1) && noMoveLeft(m_Player2))
            {
                gameResult = eGameResult.Tie;
            }
            else if (noMoveLeft(m_Player1))
            {
                gameResult = eGameResult.Player2Win;
            }
            else
            {
                gameResult = eGameResult.Player1Win;
            }

            return gameResult;
        }

        private void anotherRoundClicked(bool i_Answer, EventArgs i_Event)
        {
            initializeBoard(m_GameBoard.Dimension);
            distributePawnsToPlayers(m_GameBoard.Dimension);
            m_MyChecker.Board = m_GameBoard;
            m_Player1.Turn = true;
            m_Player2.Turn = false;
            m_MyChecker.UpdateBoard();
        }

        private void play(GameSettingsForm i_GameSettingsForm)
        {
            initializePlayer1(i_GameSettingsForm);
            initializePlayer2(i_GameSettingsForm);
            initializeBoard(i_GameSettingsForm.Dimension);
            distributePawnsToPlayers(m_GameBoard.Dimension);
            m_MyChecker = new Checker(m_GameBoard);
            m_MyChecker.OnClick += ButtonClicked;
            OnAnotherRound += anotherRoundClicked;
            m_MyChecker.Player1Label.Text = m_Player1.Name;
            m_MyChecker.Player2Label.Text = m_Player2.Name;
            m_MyChecker.ShowDialog();
        }

        private void distributePawnsToPlayers(Board.eBoardDimension i_BoardDimension)
        {
            m_Player1.NumOfPawns = m_Player2.NumOfPawns = ((int)i_BoardDimension / 2) * (((int)i_BoardDimension - 2) / 2);
            m_Player1.NumOfKings = m_Player2.NumOfKings = 0;
        }

        private bool isLegalMove(Player i_Player, Move i_Move)
        {
            bool moveIsLegal;

            List<Move> possibleEatingMoves = i_Player.PossibleEatingMoves(m_GameBoard);
            List<Move> possibleNonEatingMoves = i_Player.PossibleNonEatingMoves(m_GameBoard);

            if (possibleEatingMoves.Count > 0)
            {
                moveIsLegal = isMoveInList(possibleEatingMoves, i_Move);
            }
            else if (possibleNonEatingMoves.Count > 0)
            {
                moveIsLegal = isMoveInList(possibleNonEatingMoves, i_Move);
            }
            else
            {
                moveIsLegal = false;
            }

            if (!moveIsLegal)
            {
                if (i_Move.Source != i_Move.Destination)
                {
                    MessageBox.Show(@"Invalid move!");
                }
            }

            return moveIsLegal;
        }

        private bool isMoveInList(List<Move> i_List, Move i_Move)
        {
            bool moveWasFound = false;

            foreach (Move move in i_List)
            {
                if (move.Source.X == i_Move.Source.X && move.Source.Y == i_Move.Source.Y &&
                    move.Destination.X == i_Move.Destination.X && move.Destination.Y == i_Move.Destination.Y)
                {
                    moveWasFound = true;
                    break;
                }
            }

            return moveWasFound;
        }

        private Move choosePcMove(Player i_Player)
        {
            List<Move> possibleEatingMoves = i_Player.PossibleEatingMoves(m_GameBoard);
            List<Move> possibleNonEatingMoves = i_Player.PossibleNonEatingMoves(m_GameBoard);
            Move pcMove;
            int indexInList;

            if (possibleEatingMoves.Count > 0)
            {
                indexInList = r_RandomGenerator.Next(possibleEatingMoves.Count);
                pcMove = possibleEatingMoves[indexInList];
            }
            else if (possibleNonEatingMoves.Count > 0)
            {
                indexInList = r_RandomGenerator.Next(possibleNonEatingMoves.Count);
                pcMove = possibleNonEatingMoves[indexInList];
            }
            else
            {
                pcMove = new Move();
            }

            return pcMove;
        }

        private void giveTurnTo(ref Player io_Player, ref Player io_Opponent, Move i_Move)
        {
            m_GameBoard.MovePawn(i_Move, io_Player);

            if (io_Player.AteOpponent(i_Move))
            {
                int colIndexToRemove = m_GameBoard.CalculateColIndexOfCellToRemove(i_Move);
                int rowIndexToRemove = m_GameBoard.CalculateRowIndexOfCellToRemove(i_Move);

                if (m_GameBoard.m_Grid[rowIndexToRemove, colIndexToRemove].Sign == io_Opponent.PawnSign)
                {
                    io_Opponent.NumOfPawns--;
                }
                else
                {
                    io_Opponent.NumOfKings--;
                }

                m_GameBoard.m_Grid[rowIndexToRemove, colIndexToRemove].PawnInCell = false;

                if (!io_Player.CanEatMore(m_GameBoard, m_Move.Destination))
                {
                    io_Opponent.Turn = true;
                    io_Player.Turn = false;
                }
                else
                {
                    m_Move.Source = m_Move.Destination;
                    m_Move.Destination = destinationInEatingSerie(io_Player, m_Move.Source);

                    if (io_Player.Name == "PC")
                    {
                        ButtonClicked(m_Move.Destination, EventArgs.Empty);
                    }
                }
            }
            else
            {
                io_Opponent.Turn = true;
                io_Player.Turn = false;
            }
        }

        private Point destinationInEatingSerie(Player i_Player, Point i_LocationOfCurrentEatingPawn)
        {
            List<Move> possibleEatingMoves = i_Player.PossibleEatingMoves(m_GameBoard);

            Point newDestinationInEatingSerie = new Point();

            foreach (Move eatingMove in possibleEatingMoves)
            {
                if (eatingMove.Source == i_LocationOfCurrentEatingPawn)
                {
                    newDestinationInEatingSerie = eatingMove.Destination;
                    break;
                }
            }

            return newDestinationInEatingSerie;
        }
    }
}