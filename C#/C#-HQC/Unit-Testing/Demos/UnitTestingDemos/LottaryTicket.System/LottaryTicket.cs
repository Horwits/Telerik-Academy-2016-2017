using System;
using System.Collections;
using System.Collections.Generic;

namespace LottaryTicket.System
{
    public class LottaryTicket : ILottaryTicket
    {
        private readonly ICollection<Game> games;

        public LottaryTicket()
        {
            games = new List<Game>();
        }

        public ICollection<Game> Games
        {
            get
            {
                return this.games;
            }
        }

        public void AddGame(Game game)
        {
            this.games.Add(game);
        }

        public void PlayGame(Game game)
        {
            Console.WriteLine($"The game {game} is played.");
            RemoveGame(game);
        }

        private void RemoveGame(Game game)
        {
            foreach (var g in this.games)
            {
                if (g.Equals(game))
                {
                    this.games.Remove(game);
                    return;
                }
            }
        }
    }
}
