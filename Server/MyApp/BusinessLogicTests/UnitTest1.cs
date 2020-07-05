using BusinessLogic.Abstractions;
using BusinessLogic.Implementations;
using DataAccess.Abstractions;
using DataAccess.Implementations;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit.Sdk;

namespace BusinessLogicTests
{
    [TestClass]
    public class ConcertLogicTest
    {
        private readonly List<Concert> concerts;

        private readonly IConcertLogic concertLogic;

        private readonly IConcertSingerLogic concertSingerLogic;


        private readonly Mock<IUnitOfWork> unitOfWorkMock;

        private readonly Mock<IRepository<Concert>> repositoryMock;


        public ConcertLogicTest()
        {
            concerts = new List<Concert>()
                {
                new Concert { 
                    Id = Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4c"),
                    Name= "Name",
                    Price= 100,
                    LocationId =  Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4d")}
            };

            repositoryMock = new Mock<IRepository<Concert>>();
            unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(x => x.ConcertRepository.GetAll<Concert>()).Returns(concerts);


            repositoryMock.Setup(x => x.GetAll<Concert>()).Returns(concerts);
            repositoryMock.Setup(x => x.GetByFilter<Concert>(x => x.Id == It.IsAny<Guid>()))
                .Returns((Guid id) => concerts.FirstOrDefault(x => x.Id == id));
            concertLogic = new ConcertLogic(unitOfWorkMock.Object, concertSingerLogic);

        }

        [TestMethod]
        public void GetAllAConcertDtos_ShouldReturnAllDtosOfConcerts()
        {
           
            var expectedResult = concertLogic.GetAll();

            Assert.IsInstanceOfType(expectedResult, typeof(List<ConcertDto>));
            repositoryMock.Verify(r => r.GetAll<Concert>(), Times.Once);
        }
    }
}
