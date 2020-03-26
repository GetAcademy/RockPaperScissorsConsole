using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Game
    {
        public int GetWinner(PlayChoice player1choice, PlayChoice player2choice)
        {
            var isEqual = player1choice == player2choice;
            var winnerIs1 = player1choice == PlayChoice.Paper && player2choice == PlayChoice.Rock
                    || player1choice == PlayChoice.Rock && player2choice == PlayChoice.Scissors
                    || player1choice == PlayChoice.Scissors && player2choice == PlayChoice.Paper;
            return isEqual ? 0 : winnerIs1 ? 1 : 2;
        }

        public PlayChoice GetChoice(int n)
        {
            return (PlayChoice)n;
        }
    }
}
