using Logic;
using NUnit.Framework;
using Interface;
using Moq;
using System.Collections.Generic;

namespace UnitTests
{
    public class Tests
    {
        private readonly Mock<IDishDAL> dishDALMock = new Mock<IDishDAL>();
        private readonly Mock<IDishCollectionDAL> dishCollectionDALMock = new Mock<IDishCollectionDAL>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            //DishDTO dishDTO = new DishDTO { 
            //    id = 1,
            //    name = "kip",
            //    category_id = 2,
            //    price = 10.5M,
            //    description = "hallo"
            //};

            //Dish dish = new Dish(dishDALMock.Object);
            //dish.id = 1;
            //dish.name = "kip";
            //dish.category_id = 2;
            //dish.price = 10.5M;
            //dish.description = "hallo";

            //dishDALMock.Setup(DishDAL => DishDAL.updateDish(dishDTO));

            //dish.updateDish();

            //dishDALMock.Verify(DishDAL => DishDAL.updateDish(dishDTO), Times.Once());


            //Arrange
            DishDTO dishDTO = new DishDTO
            {
                id = 1,
                name = "kip",
                category_id = 2,
                price = 10.5M,
                description = "hallo"
            };

            dishDALMock.Setup(dishDAL => dishDAL.updateDish(dishDTO)).Verifiable();
            Dish dish = new Dish(dishDALMock.Object);
            dish.id = dishDTO.id;
            dish.name = dishDTO.name;
            dish.category_id = dishDTO.category_id;
            dish.price = dishDTO.price;
            dish.description = dishDTO.description;

            //Act
            dish.updateDish();

            //Assert
            dishDALMock.Verify(mock => mock.updateDish(dishDTO), Times.Once());
        }

        [Test]
        public void Test2()
        {
            List<DishDTO> expectedDishes = new List<DishDTO>()
            {
                new DishDTO
                {
                    name = "kip"
                },
                new DishDTO
                {
                    name = "ossenhaas"
                }
            };

            dishCollectionDALMock.Setup(DishCollectionDAL => DishCollectionDAL.getDishList())
                .Returns(expectedDishes);

            DishCollection dishCollection = new DishCollection(dishCollectionDALMock.Object);

            List<DishDTO> actualDishes = dishCollection.getDishList();


            dishCollection.getDishList();
            
            for (int i = 0; i < expectedDishes.Count; i++)
            {
                Assert.AreEqual(expectedDishes[i].name, actualDishes[i].name);
            }

        }
    }
}