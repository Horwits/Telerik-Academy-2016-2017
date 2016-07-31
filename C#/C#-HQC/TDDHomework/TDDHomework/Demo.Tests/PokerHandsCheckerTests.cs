namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class PokerHandsCheckerTests
    {
        #region IsValidHand
        [Test]
        public void IsValidHand_ShouldReturnFalse_IfAHandWithLessThanFiveCardsIsPassed()
        {
            var handData = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades)
            };

            var hand = new Hand(handData);
            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ShouldReturnTrue_IfAValidHandIsPassed()
        {
            var handData = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            };

            var hand = new Hand(handData);
            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ShouldThrowArgumentNullException_IfAHandWithNullValueIsPassed()
        {
            Hand hand = null;
            var checker = new PokerHandsChecker();

            Assert.Throws<ArgumentNullException>(() => checker.IsValidHand(hand));
        }
        #endregion

        #region IsFlush
        [Test]
        public void IsFlush_ShouldReturnTrue_IfAllCardsAreFromOneCardSuit()
        {
            var handData = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            };

            var hand = new Hand(handData);
            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ShouldReturnFalse_IfCardsAreNotFromOneCardSuit()
        {
            var handData = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            };

            var hand = new Hand(handData);
            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ShouldThrowArgumentNullException_IfHandValueIsNull()
        {
            Hand hand = null;
            var checker = new PokerHandsChecker();

            Assert.Throws<ArgumentNullException>(() => checker.IsFlush(hand));
        }
        #endregion

        #region IsFourOfAKind
        [Test]
        public void IsFourOfAKind_ShouldReturnTrue_IfThereAreFourCardsFromOneCardFace()
        {
            var handData = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
            };

            var hand = new Hand(handData);
            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnFalse_IfThereAreNoFourCardsFromOneCardFace()
        {
            var handData = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            };

            var hand = new Hand(handData);
            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_ShouldThrowArgumentNullException_IfHandValueIsNull()
        {
            Hand hand = null;
            var checker = new PokerHandsChecker();

            Assert.Throws<ArgumentNullException>(() => checker.IsFourOfAKind(hand));
        }
        #endregion
    }
}