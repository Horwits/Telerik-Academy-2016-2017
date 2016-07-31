namespace School.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CourseStudentsCount_WhenAddAStudent_CountShouldBePlusOne()
        {
            Student student = new Student();
            var course = new Course();

            course.AddStudent(student);

            Assert.AreEqual(1, course.StudentsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseAddStudent_WhenAddStudentWithNullValue_ShouldThrowArgumentNullException()
        {
            Student student = null;
            var course = new Course();

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CourseAddStudent_WhenAddMoreThan30Students_ShouldThrowArgumentOutOfRangeException()
        {
            Student student = new Student();
            var course = new Course();

            for (int i = 0; i < 32; i++)
            {
                course.AddStudent(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseRemoveStudent_WhenRemoveStudentWithNullValue_ShouldThrowArgumentNullException()
        {
            Student student = null;
            var course = new Course();

            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseRemoveStudent_WhenRemovingNonExistingStudent_ShouldThrowArgumentException()
        {
            Student pesho = new Student("Pesho");
            Student gosho = new Student("Gosho");
            var course = new Course();

            course.AddStudent(pesho);

            course.RemoveStudent(gosho);
        }

        [TestMethod]
        public void CourseRemoveStudent_WhenRemovingExistingStudent_Should()
        {
            Student pesho = new Student("Pesho");
            Student gosho = new Student("Gosho");
            var course = new Course();

            course.AddStudent(pesho);
            course.RemoveStudent(pesho);

            Assert.AreEqual(0, course.StudentsCount);
        }

        [TestMethod]
        public void CourseStudents_WhenIsCalled_ShouldReturnTheSameCountAsStudentsCountProp()
        {
            Student pesho = new Student("Pesho");
            Student gosho = new Student("Gosho");
            var course = new Course();

            course.AddStudent(pesho);
            course.RemoveStudent(pesho);
            var resultedCount = course.Students.Count();

            Assert.AreEqual(resultedCount, course.StudentsCount);
        }

    }
}
