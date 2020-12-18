using Logic;
using NUnit.Framework;
using Interface;
using Moq;
using System.Collections.Generic;

namespace UnitTests
{
    public class DishUnitTests
    {
        private readonly Mock<IDishDAL> dishDALMock = new Mock<IDishDAL>();
        private readonly Mock<IDishCollectionDAL> dishCollectionDALMock = new Mock<IDishCollectionDAL>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void updateDish_MockSetupDish_VerifyValues()
        {
            //Arrange
            DishDTO dishDTO = new DishDTO
            {
                id = 1,
                name = "kip",
                category_id = 2,
                price = 10.5M,
                description = "met groenten"
            };

            dishDALMock.Setup(dishDAL => dishDAL.updateDish(dishDTO));
            Dish dish = new Dish(dishDALMock.Object);
            dish.id = dishDTO.id;
            dish.name = dishDTO.name;
            dish.category_id = dishDTO.category_id;
            dish.price = dishDTO.price;
            dish.description = dishDTO.description;

            //Act
            dish.updateDish();

            //Assert
            dishDALMock.Verify(mock => mock.updateDish(It.Is((DishDTO dishDTO) => dishDTO.id == 1 && dishDTO.name == "kip" && dishDTO.category_id == 2 && dishDTO.price == 10.5M && dishDTO.description == "met groenten")));
        }

        [Test]
        public void getDishList_MockSetupExpectedDishes_AreEqual()
        {
            //Arrange
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

            //Act
            dishCollection.getDishList();

            //Assert
            for (int i = 0; i < expectedDishes.Count; i++)
            {
                Assert.AreEqual(expectedDishes[i].name, actualDishes[i].name);
            }

        }

        [Test]
        public void getDishByID_MockSetupDishName_AreEqual()
        {
            //Arrange
            DishDTO expectedDish = new DishDTO
            {
                id = 2,
                name = "ossenhaas",
                category_id = 2,
                price = 10.5M,
                description = "met groenten"
            };

            dishCollectionDALMock.Setup(DishCollectionDAL => DishCollectionDAL.getDishById(2))
                .Returns(expectedDish);

            DishCollection dishCollection = new DishCollection(dishCollectionDALMock.Object);

            //Act
            Dish actualDish = dishCollection.getDishById(2);

            //Assert
            Assert.AreEqual(expectedDish.name, actualDish.name);
        }

        [Test]
        public void addDish_MockSetupDish_VerifyValues()
        {
            //Arrange
            DishDTO dishDTO = new DishDTO
            {
                name = "ossenhaas",
                category_id = 2,
                price = 10.5M,
                description = "met groenten"
            };

            dishCollectionDALMock.Setup(dishCollection => dishCollection.addDish(dishDTO));
            DishCollection dishCollection = new DishCollection(dishCollectionDALMock.Object);

            Dish dish = new Dish(dishDALMock.Object);
            dish.name = dishDTO.name;
            dish.category_id = dishDTO.category_id;
            dish.price = dishDTO.price;
            dish.description = dishDTO.description;

            //Act
            dishCollection.addDish(dish);

            //Assert
            dishCollectionDALMock.Verify(mock => mock.addDish(It.Is((DishDTO dishDTO) => dishDTO.name == "ossenhaas" && dishDTO.category_id == 2 && dishDTO.price == 10.5M && dishDTO.description == "met groenten")));
        }

        [Test]
        public void deleteDish_MockSetupDish_VerifyOnce()
        {
            //Arrange
            DishDTO dishDTO = new DishDTO
            {
                id = 2,
                name = "ossenhaas",
                category_id = 2,
                price = 10.5M,
                description = "met groenten"
            };

            dishCollectionDALMock.Setup(dishCollection => dishCollection.deleteDish(dishDTO.id));
            DishCollection dishCollection = new DishCollection(dishCollectionDALMock.Object);

            //Act
            dishCollection.deleteDish(dishDTO.id);

            //Assert
            dishCollectionDALMock.Verify(mock => mock.deleteDish(2), Times.Once());
        }
    }
}