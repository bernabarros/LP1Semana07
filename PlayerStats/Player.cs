using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highscore;
        private int playedGames;
        private int wonGames;
        public string Name{ get; }
        public float HighScore
        {
            get
            {
                return highscore;
            }
            set
            {
                if(value>highscore)
                {
                    highscore = value;
                }
            }
        }
        public float WinRate
        {
            get
            {
                if(playedGames>0)
                {
                    return (float)wonGames/playedGames;
                }
                else 
                {
                    return 0;
                }
            }
        }
        public void PlayGame(bool win)
        {
            if(win == true)
            {
                wonGames++;
            }
            playedGames++;
        }
        public Player(string name)
        {
            Name = name;
            HighScore=0;
            playedGames=0;
            wonGames=0;
        }
    }
}