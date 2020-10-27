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
using System.Linq.Expressions;
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
                    Name= "Name1",
                    Price= 100,
                    LocationId =  Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4d")},
                new Concert {
                    Id = Guid.Parse("5597b8a3-e404-4fff-828e-72d99d489d4c"),
                    Name= "Name2",
                    Price= 100,
                    LocationId =  Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4d")},
                new Concert {
                    Id = Guid.Parse("9597b8a3-e404-4fff-828e-72d99d489d4c"),
                    Name= "Name3",
                    Price= 100,
                    LocationId =  Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4d")},
                new Concert {
                    Id = Guid.Parse("0597b8a3-e404-4fff-828e-72d99d489d4c"),
                    Name= "Name4",
                    Price= 100,
                    LocationId =  Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4d")}
            };


            repositoryMock = new Mock<IRepository<Concert>>();
            unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.ConcertRepository).Returns(repositoryMock.Object);


            repositoryMock.Setup(x => x.GetAll<Concert>()).Returns(concerts);
            repositoryMock.Setup(x => x.GetByFilter<Concert>(x => x.Id == It.IsAny<Guid>()))
                .Returns((Guid id) => concerts.FirstOrDefault(x => x.Id == id));
           // concertLogic = new ConcertLogic(unitOfWorkMock.Object, concertSingerLogic);

        }

        [TestMethod]
        public void GetAllAConcertDtos_ShouldReturnAllDtosOfConcerts()
        {
            repositoryMock.Setup(x => x.GetAll<Concert>()).Returns(concerts);

            var expectedResult = concertLogic.GetAll();

            Assert.IsInstanceOfType(expectedResult, typeof(List<ConcertDto>));
            repositoryMock.Verify(r => r.GetAll<Concert>(), Times.Once);
        }

        [TestMethod]
        public void GetByIdArticle_ShouldCallRepositoryMethod()
        {
            repositoryMock.Setup(x => x.GetByFilter<Concert>(It.IsAny<Expression<Func<Concert, bool>>>()))
                .Returns(new Concert
                      {
                           Id = Guid.Parse("0597b8a3-e404-4fff-828e-72d99d489d4c"),
                           Name = "Name4",
                           Price = 100,
                           LocationId = Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4d")
                       });
            var expectedResult = concertLogic.GetById(Guid.Parse("0597b8a3-e404-4fff-828e-72d99d489d0c"));

            repositoryMock.Verify(r => r.GetByFilter<Concert>(It.IsAny<Expression<Func<Concert, bool>>>()), Times.Once);
        }


        [TestMethod]
        public void GetByIdArticle_ShouldReturnNullIfIdIsNonExistent()
        {
            repositoryMock.Setup(x => x.GetByFilter<Concert>(It.IsAny<Expression<Func<Concert, bool>>>()))
             .Returns(null as Concert);

            var expectedResult = concertLogic.GetById(Guid.Parse("0597b8a3-e404-4fff-828e-72d99d489d0c"));

            Assert.IsNull(expectedResult);
        }


        [TestMethod]
        public void AddArticle_ShouldCallRepositoryMethod()
        {
            var concert = new ConcertDto
            {
                Id = Guid.Parse("0597b8a3-e404-4fff-828e-72d99d489d4c"),
                Name = "Name4",
                Price = 100,
                LocationId = Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4d")
            };

            repositoryMock.Setup(x => x.Insert<Concert>(It.IsAny<Concert>()));

            var expectedResult = concertLogic.AddConcert(concert);

            repositoryMock.Verify(r => r.Insert<Concert>(It.IsAny<Concert>()), Times.Once);
        }

        public void AddArticle_ShouldCommitChanges()
        {
            var concert = new ConcertDto
            {
                Id = Guid.Parse("0597b8a3-e404-4fff-828e-72d99d489d4c"),
                Name = "Name4",
                Price = 100,
                LocationId = Guid.Parse("7597b8a3-e404-4fff-828e-72d99d489d4d")
            };

            repositoryMock.Setup(x => x.Insert<Concert>(It.IsAny<Concert>()));

            var expectedResult = concertLogic.AddConcert(concert);

            unitOfWorkMock.Verify(r => r.Commit(), Times.Once);
        }
    }
}
