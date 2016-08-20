namespace Poker.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CardTests
    {
        [TestCase(CardFace.Ace, CardSuit.Diamonds)]
        [TestCase(CardFace.Eight, CardSuit.Clubs)]
        [TestCase(CardFace.King, CardSuit.Hearts)]
        [TestCase(CardFace.Seven, CardSuit.Spades)]
        public void ToString_ShouldReturnStringWithCardFaceAndCardSuit(CardFace face, CardSuit suit)
        {
            // Arrange
            var card = new Card(face, suit);
            var cardToString = $"{face} of {suit}";

            // Act and Assert
            Assert.AreEqual(cardToString, card.ToString());
        }
    }
}
