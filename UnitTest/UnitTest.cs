using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CodingChallenge.Models;
using CodingChallenge.Controllers;
using CodingChallenge.Data;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_Cars()
        {
            //Arrange
            var mockRepo= new Mock<ICarsData>();
            
            mockRepo.Setup(repo => repo.GetAllCars())
                    .Returns(GetAllCarsTest());
            var controller = new CarsController(mockRepo.Object);

            //Act
            var result= controller.Cars();

            //Assert
            var output = ((CarViewModel)((ViewResult)result).Model).AllCars.ToArray();
            Assert.AreEqual(3, output.Length);
        } 
        [TestMethod]
        public void Test_Cars_Post()
        {
            //Arrange
            var mockRepo= new Mock<ICarsData>();
            mockRepo.Setup(repo => repo.GetAllCars())
                    .Returns(GetAllCarsTest());
            var controller = new CarsController(mockRepo.Object);

            //Act
            var result= controller.Cars(GetAllCarsTest().FirstOrDefault());

            //Assert
            var output = ((ViewResult)result).Model;
            Assert.IsNotNull(output);
            Assert.IsNotNull(((CarViewModel)output).Brand);
        }

        [TestMethod]
        public void Test_CarDetails()
        {
            //Arrange
            var mockRepo= new Mock<ICarsData>();
            mockRepo.Setup(repo => repo.GetAllCars())
                    .Returns(GetAllCarsTest());
            var controller = new CarsController(mockRepo.Object);

            //Act
            var result= controller.CarDetails(GetAllCarsTest().FirstOrDefault());

            //Assert
            var output = ((PartialViewResult)result).Model;
            Assert.IsNotNull(output);
            Assert.IsNotNull(((CarViewModel)output).Brand);
        }
        private List<CarViewModel> GetAllCarsTest() 
        {
            return new List<CarViewModel>{
                    new CarViewModel{
                        Id=1,
                        Brand= "Tata",
                        IsEcoFriendly= true,
                        Fuel = "Hybrid",
                        Models = new List<string>{"X1", "X2"}
                    },
                    new CarViewModel{
                        Id=2,
                        Brand= "Honda",
                        IsEcoFriendly= false,
                        Fuel = "Petrol",
                        Models = new List<string>{"X12", "X22"}
                    },
                    new CarViewModel{
                        Id=3,
                        Brand= "Hunydai",
                        IsEcoFriendly= true,
                        Fuel = "Hybrid",
                        Models = new List<string>{"X14", "X25"}

                    }
                };
        }   
    }
}
