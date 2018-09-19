namespace GameOfNim
{
    // Player Class that stores the number of wins and name of each player
    // Author: Zachary Goncalves
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

        public int getNumWins()
        {
            return numWins;
        }
    }
}
