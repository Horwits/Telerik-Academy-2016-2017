using System.Collections.Generic;

namespace LottaryTicket.System
{
    public interface ILottaryTicket
    {
        ICollection<Game> Games { get; }

        void AddGame(Game game);
        void PlayGame(Game game);
    }
}