namespace Deck.Tests
{
    using System;

    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTest
    {
        [Test]
        public void GetNextCard_WhenListOfCardsCountIsZero_ShouldThrowInternalGameException()
        {
            var deck = new Deck();

            while (deck.CardsLeft != 0)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [TestCase(null)]
        public void ChangeTrumpCard_IfNullValueIsPassed_ShouldBeNull(Card newCard)
        {
            var deck = new Deck();

            deck.ChangeTrumpCard(newCard);

            Assert.IsNull(deck.TrumpCard);
        }

        [Test]
        public void CardsLeft_WhenCalledFirst_ShouldHave24Cards()
        {
            var deck = new Deck();

            var currentCardsLeft = deck.CardsLeft;

            Assert.AreEqual(24, currentCardsLeft);
        }

        [TestCase(4)]
        [TestCase(18)]
        [TestCase(21)]
        [TestCase(23)]
        public void GetNextCard_WhenInvoked_ShouldReturnDifferentCardEveryTime(int position)
        {
            var deck = new Deck();
            Card prevCard = null;

            while (deck.CardsLeft != position)
            {
                prevCard = deck.GetNextCard();
            }

            Assert.AreNotEqual(prevCard, deck.GetNextCard());
        }
    }
}
