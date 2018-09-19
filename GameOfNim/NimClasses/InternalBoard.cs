using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim
{
    // Internal Board class that processes the state of the game
    // Author: Zachary Goncalves
    public class GameBoard
    {
        private int numMarbles;
        private int[] marblesByRow;

        public GameBoard(int maxRows)
        {
            setAttributes();
        }
        public void resetGame()
        {
            setAttributes(); 
        }

        public void setAttributes()
        {
            numMarbles = 16;
            marblesByRow = new int[] { 1, 3, 5, 7 };
        }

        public int getMarblesOnBoard()
        {
            return numMarbles;
        }

        // Take a marble from a row
        public void takeMarbles(int rowID, int totalMarblesSelected)
        {
            int marblesInRow = 0;
            if (rowID == 0)
            {
                marblesInRow = marblesByRow[0];
                marblesByRow[0] = marblesInRow - totalMarblesSelected;
                numMarbles -= totalMarblesSelected;
            }
            if (rowID == 1)
            {
                marblesInRow = marblesByRow[1];
                marblesByRow[1] = marblesInRow - totalMarblesSelected;
                numMarbles -= totalMarblesSelected;
            }
            if (rowID == 2)
            {
                marblesInRow = marblesByRow[2];
                marblesByRow[2] = marblesInRow - totalMarblesSelected;
                numMarbles -= totalMarblesSelected;
            }
            if (rowID == 3)
            {
                marblesInRow = marblesByRow[3];
                marblesByRow[3] = marblesInRow - totalMarblesSelected;
                numMarbles -= totalMarblesSelected;
            }
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
            if (numMarbles == 0)
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