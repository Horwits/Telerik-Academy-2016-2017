using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand");
            }

            var isValid = hand.Cards.Count == 5;
            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand");
            }

            CardFace currentFace = hand.Cards[0].Face, nextFace;
            var counter = 1;
            for (int i = 0, j = 1; j < 5; i++, j++)
            {
                nextFace = hand.Cards[j].Face;
                if (currentFace == nextFace)
                {
                    counter++;
                    if (counter == 4)
                    {
                        return true;
                    }

                    continue;
                }
                else
                {
                    j = i + 1;
                    if (i > 1)
                    {
                        return false;
                    }

                    counter = 1;
                }
            }

            return true;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand");
            }

            var currentSuit = hand.Cards[0].Suit;
            foreach (var card in hand.Cards)
            {
                if (card.Suit != currentSuit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
