namespace Poker.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class HandTests
    {
        [Test]
        public void ToString_ShouldReturnStringWithTheHandCards()
        {
            // Arrange
            var curentHand = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades)
            };

            var hand = new Hand(curentHand);
            var handToString = string.Join(" ", curentHand);

            // Act and Assert
            Assert.AreEqual(handToString, hand.ToString());
        }
    }
}