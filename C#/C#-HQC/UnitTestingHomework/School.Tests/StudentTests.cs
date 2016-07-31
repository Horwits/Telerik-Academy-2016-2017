namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentName_IfEmptyValueIsPassed_ShouldThrowArgumentException()
        {
            var student = new Student();

            student.Name = string.Empty;
        }

        [TestMethod]
        public void StudentName_IfSomeStringIsPassedAsValue_ShouldHasTheSameStringValue()
        {
            var student = new Student();
            var studentName = "Pesho";

            student.Name = studentName;

            Assert.ReferenceEquals(student.Name, studentName);
        }

        [TestMethod]
        public void StudentUiniqueNumber_WhenValidNumberIsPassed_ShouldHaveTheSameValue()
        {
            var student = new Student();
            uint uniqueNum = 10010;

            student.UniqueNumber = uniqueNum;

            Assert.AreEqual(student.UniqueNumber, uniqueNum);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentUniqueNumber_IfInvalidValueIsPassed_ShouldThrowArgumentOutOfRangeException()
        {
            var student = new Student();
            uint uniqueNumber = 1;

            student.UniqueNumber = uniqueNumber;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentUniqueNumber_IfOverflowValueIsPassed_ShouldThrowArgumentOutOfRangeException()
        {
            var student = new Student();

            uint uniqueNumber = uint.MaxValue;
            uniqueNumber++;

            student.UniqueNumber = uniqueNumber;
        }
    }
}