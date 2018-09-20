/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 1: Game of Nim
 * Written by: Zachary Goncalves with game board generation code provided by Professor Frank Friedman
 * 
 * Description:
 * This project is a simulation of the Game of Nim, in which players must not be the last player to take the last button
 * This simulation keeps track of two players, the number of games played between these players, and the number of games
 * each player has won.
 */ 

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfNim
{
    public partial class GamePanel : Form
    {
        private Player playerOne, playerTwo;
        private List<Player> playersList = new List<Player>(2);

        private const int maxRows = 4;
        private const int maxCols = 7;
        
        private GameBoard gameBoard = new GameBoard(maxRows);

        int marblesSelectedCount = 0;  // Total number of marbles selected in current turn
        int gameCount = 0;             // counts number of games played
        int rowID;                     // row number of row just slected by current player

        private Button[,] newButton = new Button[maxRows, maxCols];
        private Button[] newRowButton = new Button[maxRows];


        public GamePanel()
        {
            InitializeComponent();
        }
        // Takes in player name for first player and enables second player name input
        private void btnFirstPlayerOK_Click(object sender, EventArgs e)
        {
            if (txtFirstPlayerName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a name for player one.", "Error");
            }
            else
            {
                lblSecondPlayerName.Enabled = true;
                lblSecondPlayerName.Visible = true;

                txtSecondPlayerName.Enabled = true;
                txtSecondPlayerName.Visible = true;

                btnSecondPlayerOK.Enabled = true;
                btnSecondPlayerOK.Visible = true;

                playerOne = new Player(txtFirstPlayerName.Text, 0);

            }
        }
        // Takes second player name and validates that player names are different. If not, requires new names. Shows play game btn.
        private void btnSecondPlayerOK_Click(object sender, EventArgs e)
        {
            if (txtSecondPlayerName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a name for player two.", "Error");
            }
            else
            {
                playerTwo = new Player(txtSecondPlayerName.Text, 0);

                if (playerOne.getPlayerName().Equals(playerTwo.getPlayerName()))
                {
                    MessageBox.Show("Please enter different player names", "Error");
                    lblSecondPlayerName.Enabled = false;
                    lblSecondPlayerName.Visible = false;

                    txtSecondPlayerName.Enabled = false;
                    txtSecondPlayerName.Visible = false;

                    btnSecondPlayerOK.Enabled = false;
                    btnSecondPlayerOK.Visible = false;

                    lblReadyMessage.Enabled = false;
                    lblReadyMessage.Visible = false;
                    btnPlay.Enabled = false;
                    btnPlay.Visible = false;

                    playerOne.clearPlayerName();
                    playerTwo.clearPlayerName();

                    txtFirstPlayerName.Focus();
                }
                else
                {
                    lblReadyMessage.Enabled = true;
                    lblReadyMessage.Visible = true;
                    btnPlay.Enabled = true;
                    btnPlay.Visible = true;
                }
            }
        }
        // Displays panel with game board and generates game board
        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlGameBoard.Enabled = true;
            pnlGameBoard.Visible = true;

            txtCurrentTurn.Text = playerOne.getPlayerName();
            gameCount++;
            createBoard();
        }
        // Handles end of turn logic
        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            if (marblesSelectedCount == 0)
            {
                MessageBox.Show("Please take at least one marble.", "Error");
            }
            else
            {
                gameBoard.takeMarbles(rowID, marblesSelectedCount);
            }

            // Reset row button style and enabled attribute for buttons.
            if (marblesSelectedCount != 0)
            {
                for (int row = 0; row < maxRows; row++)
                {
                    newRowButton[row].BackColor = Button.DefaultBackColor;
                    if (gameBoard.checkRowCount(row) != 0)
                    {
                        newRowButton[row].Enabled = true;
                    }
                    else if (gameBoard.checkRowCount(row) == 0)
                    {
                        newRowButton[row].Enabled = false;
                    }
                    for (int col = 0; col < maxCols; col++)
                    {
                        newButton[row, col].Enabled = false;
                    }
                }
            }
            // Check Game Status
            int gameStatus = gameBoard.checkTotal();

            if(gameStatus == 0)
            {
                // End Game: player who went loses
                if (txtCurrentTurn.Text.Equals(playerOne.getPlayerName()))
                {
                    playerTwo.incrementNumWins();
                    MessageBox.Show(playerTwo.getPlayerName() + " Wins!", "Game Over");
                    MessageBox.Show(playerTwo.getPlayerName() + " has won " + playerTwo.getNumWins() + " games.", "Game Over");
                }
                else
                {
                    playerOne.incrementNumWins();
                    MessageBox.Show(playerOne.getPlayerName() + " Wins!", "Game Over");
                    MessageBox.Show(playerOne.getPlayerName() + " has won " + playerOne.getNumWins() + " games.", "Game Over");
                }
                pnlGameBoard.Enabled = false;
                btnPlayAgain.Visible = true;
                btnPlayAgain.Enabled = true;
                txtGamesPlayed.Text = gameCount.ToString();
            }
            else if(gameStatus == 1)
            {
                // End Game: current player wins
                if (txtCurrentTurn.Text.Equals(playerOne.getPlayerName()))
                {
                    playerOne.incrementNumWins();
                    MessageBox.Show(playerOne.getPlayerName() + " Wins!", "Game Over");
                    MessageBox.Show(playerOne.getPlayerName() + " has won " + playerOne.getNumWins() + " games.", "Game Over");
                }
                else
                {
                    playerTwo.incrementNumWins();
                    MessageBox.Show(playerTwo.getPlayerName() + " Wins!", "Game Over");
                    MessageBox.Show(playerTwo.getPlayerName() + " has won " + playerTwo.getNumWins() + " games.", "Game Over");
                }
                pnlGameBoard.Enabled = false;
                btnPlayAgain.Visible = true;
                btnPlayAgain.Enabled = true;
                txtGamesPlayed.Text = gameCount.ToString();
            }
            else
            {
                // Continue Game
                if (txtCurrentTurn.Text.Equals(playerOne.getPlayerName()))
                {
                    txtCurrentTurn.Text = playerTwo.getPlayerName();
                }
                else
                {
                    txtCurrentTurn.Text = playerOne.getPlayerName();
                }
            }

            marblesSelectedCount = 0;
        } 

        private void createBoard()
        {
            // Dynamically Creates a 4x7 grid and associated row buttons  
            pnlGameBoard.Visible = true;

            Size size = new Size(50, 50);
            Point loc = new Point(0, 0);
            int padding = 10;
            int topMargin = 70;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                // For each new row, insert at left the Row i Button
                loc.Y = (topMargin + 10) + row * (size.Height + padding);
                int rowBtnExtraLeftPadding = 15;
                newRowButton[row] = new System.Windows.Forms.Button();
                newRowButton[row].Location = new Point(rowBtnExtraLeftPadding, loc.Y);
                newRowButton[row].Size = new Size(75, 23);
                newRowButton[row].Text = "Row " + (row + 1) + " -->";
                newRowButton[row].Enabled = true;
                newRowButton[row].Visible = true;
                newRowButton[row].Name = "rowBtn" + row;
                newRowButton[row].Click += new EventHandler(RowButton_Click);

                // Add row button to the form
                pnlGameBoard.Controls.Add(newRowButton[row]);

                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 100;
                for (int col = 0; col < maxCols; col++)
                {
                    newButton[row, col] = new System.Windows.Forms.Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col *(size.Width + padding), loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Text = "";
                    newButton[row, col].Enabled = false;
                    newButton[row, col].Visible = true;
                    newButton[row, col].Name = "btn" + row + col;

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlGameBoard.Controls.Add(newButton[row, col]);
                } // end for col
            } // end for row

            lblCurrentTurn.Visible = true;
            txtCurrentTurn.Visible = true;
            // Set up the board with the 16 marbles (I use a match)
            newButton[0, maxCols / 2].BackgroundImage = Properties.Resources.match2;
            for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
            {
                newButton[1, i].BackgroundImage = Properties.Resources.match2; ;
            }
            for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
            {
                newButton[2, i].BackgroundImage = Properties.Resources.match2;
            }
            for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
            {
                newButton[3, i].BackgroundImage = Properties.Resources.match2;
            }
        } // end createBoard

        private void RowButton_Click(object sender, EventArgs e)
        {
            rowID = convertCharToInt(((Button)sender).Name[6]);
            ((Button)sender).BackColor = System.Drawing.Color.Orange;
            for (int i = 0; i < maxRows; i++)
            {
                newRowButton[i].Enabled = false;
            }

            if (rowID == 0)
            {
                newButton[rowID, maxCols / 2].Enabled = true;
            }
            if (rowID == 1)
            {
                for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
                {
                    newButton[rowID, i].Enabled = true;
                }
            }
            if (rowID == 2)
            {
                for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
                {
                    newButton[rowID, i].Enabled = true;
                }
            }
            if (rowID == 3)
            {
                for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
                {
                    newButton[rowID, i].Enabled = true;
                }
            }
            btnEndTurn.Enabled = true;
        }

        // Resets the game board
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            gameBoard.resetGame();
            for (int i = 0; i < newRowButton.Length; i++)
            {
                pnlGameBoard.Controls.Remove(newRowButton[i]);
                for (int col = 0; col < maxCols; col++)
                {
                    pnlGameBoard.Controls.Remove(newButton[i, col]);
                }
            }
            pnlGameBoard.Enabled = true;
            gameCount++;
            createBoard();
            txtCurrentTurn.Text = playerOne.getPlayerName();
        }
        // Closes the form
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Event Handler for all Marble buttons
        private void Button_Click(object sender, EventArgs e)
        {
            marblesSelectedCount++;
            ((Button)sender).Visible = false;
        }

        int convertCharToInt(Char c)
        {
            return ((int)(c) - (int)('0'));
        }
    }
   
}
