using System.Collections.Generic;
using LinearDataStructuresHomework.Data;
using LinearDataStructuresHomework.Data.Contracts;
using Moq;
using NUnit.Framework;

namespace DataStructuresHomeworkModule.Tests
{
    [TestFixture]
    public class StackTaskerTests
    {
        [Test]
        public void ReverseInnerStack_IsReturningCorrectResult_WhenCorrectValuesArePassed()
        {
            var mockedReadWriter = new Mock<IReadWriteProvider>();
            var stackTasker = new StackTasker(mockedReadWriter.Object);

            var matcher = new Stack<int>();
            matcher.Push(3);
            matcher.Push(2);
            matcher.Push(1);


            stackTasker.Fill(3);
            for (int i = 1; i < 3; i++)
            {
                var currentNum = i;
                mockedReadWriter.Setup(x => x.ReadLine()).Returns(() => currentNum.ToString());
            }

            var reversed = stackTasker.Reverse();

            Assert.That(matcher, Is.EquivalentTo(reversed));
        }
    }
}
