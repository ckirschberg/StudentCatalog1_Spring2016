using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentCatalog3.Repositories;
using Moq;
using StudentCatalog2.Controllers;
using StudentCatalog3.Models;

namespace StudentCatalog3.Tests
{
    [TestClass]
    public class TestStudentController
    {
        [TestMethod]
        public void Test_StudentsControllerCreate_CallsInsertOrUpdate()
        {
            //Arrange
            Mock<IStudentRepository> mockStudentRepo = 
                new Mock<IStudentRepository>();

            StudentsController controller =
                new StudentsController(mockStudentRepo.Object);

            Student s1 = new Student
            {
                Firstname = "Serkan",
                Lastname = "Oruc",
                Email = "serkan@oruc.dk",
                MobilePhone = "12313212"
            };

            //Act
            controller.Create(s1);

            //Assert
            mockStudentRepo.Verify(a => a.InsertOrUpdate(s1));
        }
    }
}
