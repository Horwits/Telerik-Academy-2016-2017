namespace LottarySystemTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using LottaryTicket.System;
    using System.Diagnostics;

    [TestClass]
    public class LottaryTicketTest
    {
        [TestMethod]
        public void TestAddGameMethod()
        {
            var ticket = new LottaryTicket();

            ticket.AddGame(Game.Fortune);

            Assert.AreEqual(1, ticket.Games.Count, $"The method returns {ticket.Games.Count} instead of {1}");
        }
    }
}
