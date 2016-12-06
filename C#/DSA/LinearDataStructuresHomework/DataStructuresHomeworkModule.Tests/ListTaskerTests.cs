using System;
using LinearDataStructuresHomework.Data;
using LinearDataStructuresHomework.Data.Contracts;
using Moq;

using NUnit.Framework;

namespace DataStructuresHomeworkModule.Tests
{
    [TestFixture]
    public class ListTaskerTests
    {
        [Test]
        public void FillList_Should_NotAddValuesToInnerList_When_EmptyLineIsPassed()
        {
            var line = Environment.NewLine;
            var mockedReadWriteProvider = new Mock<IReadWriteProvider>();
            mockedReadWriteProvider.Setup(m => m.ReadLine()).Returns(line);
            var listTasker = new ListTasker(mockedReadWriteProvider.Object);

            listTasker.Fill(5);

            Assert.AreEqual(listTasker.InnerCollectionCount, 0);
        }

        public void CalculateListValues_Should_ReturnCorrectSum_When_CorrectValuesArePassed()
        {
            var line = Environment.NewLine;
            var mockedReadWriteProvider = new Mock<IReadWriteProvider>();
            mockedReadWriteProvider.Setup(m => m.ReadLine()).Returns(line);
            var listTasker = new ListTasker(mockedReadWriteProvider.Object);

            listTasker.Fill(5);

            Assert.AreEqual(listTasker.InnerCollectionCount, 0);
        }
    }
}
