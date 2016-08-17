using System;
using NUnit.Framework;
using InversionOfControlExample;
using System.Collections.Generic;
using Moq;

namespace Tests
{
    [TestFixture]
    public class CustomersServiceTests
    {
        [Test]
        public void CreateCustomer_ShouldCallCustomersRepositoryAddMethod_WhenTheMEthodIsCalledWithValidParameters()
        {
            // Arrange
            var repository = new Mock<ICustomerRepositiory>();

            var service = new CustomerService(repository.Object);

            // Act
            service.CreateCustomer("Ivan", 1);

            // Assert
            // Verify that the add method can get any of ICustomer 
            repository.Verify(
                x => x.Add(
                    It.IsAny<ICustomer>()),
                Times.Once());
        }

        [Test]
        public void CreateCustomer_ShouldThrowCreateCustomerException_WhenRepositoryThrowsAddCustomerException()
        {
            // Arrange
            var repositoryMock = new Mock<ICustomerRepositiory>();
            repositoryMock.Setup(
                x =>
                    x.Add(It.IsAny<ICustomer>()))
                        .Throws<AddCustomerException>();

            var customerService = new CustomerService(repositoryMock.Object);

            // Act and Assert
            var exc = Assert.Throws<CreateCustomerException>(() => customerService.CreateCustomer("dsada", 1));

            Assert.IsInstanceOf<AddCustomerException>(exc.InnerException);
        }

        [Test]

        public void Test()
        {
            var repositoryMock = new Mock<ICustomerRepositiory>();
            var customerService = new CustomerService(repositoryMock.Object);

            var students = new[]
            {
                new {Name = "Tosho", Id = 1},
                new {Name = "Pesho", Id = 1},
                new {Name = "Gosho", Id = 1},
                new {Name = "Sasho", Id = 1},
                new {Name = "Misho", Id = 1},

            };

            foreach (var student in students)
            {
                customerService.CreateCustomer(student.Name, student.Id);
            }

            repositoryMock.Verify(x => x.Add(It.IsAny<ICustomer>()),
                Times.Exactly(students.Length));
        }
    }

    //class FakeCustomersRepository : ICustomerRepositiory
    //{
    //    private bool isAddMethodCalled;

    //    public FakeCustomersRepository()
    //    {
    //        this.isAddMethodCalled = false;
    //    }

    //    public bool IsAddMethodCalled
    //    {
    //        get
    //        {
    //            return this.isAddMethodCalled;
    //        }
    //    }

    //    public void Add(Customer customer)
    //    {
    //        this.isAddMethodCalled = true;
    //        //throw new AddCustomerException();
    //    }

    //    public IEnumerable<ICustomer> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
