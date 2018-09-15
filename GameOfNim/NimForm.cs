using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfNim
{
    public partial class GamePanel : Form
    {
        private Player playerOne, playerTwo, currentPlayer;
        private List<Player> playersList = new List<Player>(2);

        private const int maxRows = 4;
        private const int maxCols = 7;

        private GameBoard gameBoard = new GameBoard(maxRows);

        int marblesSelectedCount = 0;  // Total number of marbles selected in current turn
        int gameCount = 0;             // counts number of games played
        int rowID;                     // row number of row just slected by current player
        int currentMarbles = 28;

        private Button[,] newButton = new Button[maxRows, maxCols];
        private Button[] newRowButton = new Button[maxRows];


        public GamePanel()
        {
            InitializeComponent();
        }

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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlGameBoard.Enabled = true;
            pnlGameBoard.Visible = true;

            txtCurrentTurn.Text = playerOne.getPlayerName();

            createBoard();

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Marbles in row:" + rowID + " = " + gameBoard.checkRowCount(rowID).ToString());
            MessageBox.Show("Selected Row:" + rowID);

            if (marblesSelectedCount == 0)
            {
                MessageBox.Show("Please take at least one marble.", "Error");
            }
            else
            {
                gameBoard.takeMarbles(rowID, marblesSelectedCount);
                MessageBox.Show("Marbles in row:" + rowID + " = " + gameBoard.checkRowCount(rowID).ToString());
                if (txtCurrentTurn.Text.Equals(playerOne.getPlayerName()))
                {
                    txtCurrentTurn.Text = playerTwo.getPlayerName();
                }
                else
                {
                    txtCurrentTurn.Text = playerOne.getPlayerName();
                }
            }
            

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
                    newButton[row,col].Enabled = false;
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
            // Set up the board with the 16 marbles
            newButton[0, maxCols / 2].Text = "X";
            for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
            {
                newButton[1, i].Text = "X";
            }
            for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
            {
                newButton[2, i].Text = "X";
            }
            for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
            {
                newButton[3, i].Text = "X";
            }
        } // end createBoard

        private void RowButton_Click(object sender, EventArgs e)
        {
            rowID = convertCharToInt(((Button)sender).Name[6]);
            // MessageBox.Show("Row Button [" + (rowID+1) + "] has been selected!");
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

    public class Player
    {
        private string playerName;
        private int numWins;

        public Player(string playerName, int numWins)
        {
            this.playerName = playerName;
            this.numWins = 0;
        }

        public string getPlayerName()
        {
            return playerName; 
        }

        public string clearPlayerName()
        {
            return playerName = null; 
        }
        
        public int incrementNumWins()
        {
            return numWins++;
        }
    }

    public class GameBoard
    {
        private int numMarbles;
        private int[] marblesByRow;

        public GameBoard(int maxRows)
        {
            numMarbles = 16;
            marblesByRow = new int[] { 1, 3, 5, 7 };

        }
        // Take a marble from a row
        public void takeMarbles(int rowID, int totalMarblesSelected)
        {
            int marblesInRow = 0;
            if (rowID == 0)
            {
                marblesInRow = marblesByRow[0];
                marblesByRow[0] = marblesInRow - totalMarblesSelected;
            }
            if (rowID == 1)
            {
                marblesInRow = marblesByRow[1];
                marblesByRow[1] = marblesInRow - totalMarblesSelected;
            }
            if (rowID == 2)
            {
                marblesInRow = marblesByRow[2];
                marblesByRow[2] = marblesInRow - totalMarblesSelected;
            }
            if (rowID == 3)
            {
                marblesInRow = marblesByRow[3];
                marblesByRow[3] = marblesInRow - totalMarblesSelected;
            }
            /*
            for (int i = 0; i < totalMarblesSelected; i++)
            {
                if (intRow == 1)
                {
                    marbleCount = marblesByRow[0] - 1;
                    marblesByRow[0] = marbleCount;
                }
                if (intRow == 2)
                {
                    marbleCount = marblesByRow[1] - 1;
                    marblesByRow[1] = marbleCount;
                }
                if (intRow == 3)
                {
                    marbleCount = marblesByRow[2] - 1;
                    marblesByRow[2] = marbleCount;
                }
                if (intRow == 4)
                {
                    marbleCount = marblesByRow[3] - 1;
                    marblesByRow[3] = marbleCount;
                }
            }*/
            totalMarblesSelected = 0;
        }

        // Check total marbles in a row
        public int checkRowCount(int rowID)
        {
            int marblesInRow = 0;
            if (rowID == 0)
            {
                marblesInRow = marblesByRow[0];
                return marblesInRow;
            }
            else if (rowID == 1)
            {
                marblesInRow = marblesByRow[1];
                return marblesInRow;
            }
            else if (rowID == 2)
            {
                marblesInRow = marblesByRow[2];
                return marblesInRow;
            }
            else if (rowID == 3)
            {
                marblesInRow = marblesByRow[3];
                return marblesInRow;
            }
            else
            {
                return 0; 
            }
        }
        // Check total marbles on board and return information on conditions 
        public int checkTotal()
        {
            if(numMarbles == 0)
            {
                // End Game: player who went loses
                return 0;
            }
            else if (numMarbles == 1)
            {
                // End Game: current player wins
                return 1;
            }
            else
            {
                // Continue Game
                return -1;
            }
        }
    }
}
