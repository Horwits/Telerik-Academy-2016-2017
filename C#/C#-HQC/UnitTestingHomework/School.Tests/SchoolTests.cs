namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolName_IfNullValueIsPassed_ShouldThrowArgumentException()
        {
            var school = new School();

            school.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolName_IfEmptyValueIsPassed_ShouldThrowArgumentException()
        {
            var school = new School();

            school.Name = string.Empty;
        }

        [TestMethod]
        public void SchoolName_WhenCorrectValueIsPassed_ShouldActPropperly()
        {
            var school = new School();
            var name = "SchoolName";

            school.Name = name;

            Assert.AreEqual(school.Name, name);
        }
    }
}
