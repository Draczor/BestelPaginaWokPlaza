using Logic;
using NUnit.Framework;
using Interface;
using Moq;
using System.Collections.Generic;

namespace UnitTests
{
    public class CategoryUnitTests
    {
        private readonly Mock<ICategoryDAL> categoryDALMock = new Mock<ICategoryDAL>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void addCategory_MockSetupCategory_VerifyValues()
        {
            //Arrange
            CategoryDTO categoryDTO = new CategoryDTO
            {
                category_name = "Sushi",
            };

            categoryDALMock.Setup(categoryDAL => categoryDAL.addCategory(categoryDTO));
            Category category = new Category(categoryDALMock.Object);

            //Act
            category.addCategory(categoryDTO);

            //Assert
            categoryDALMock.Verify(mock => mock.addCategory(It.Is((CategoryDTO categoryDTO) => categoryDTO.category_name == "Sushi")));
        }

        [Test]
        public void getCategory_MockSetupCategoryList_AreEqual()
        {
            //Arrange
            List<CategoryDTO> expectedCategories = new List<CategoryDTO>()
            {
                new CategoryDTO
                {
                    category_name = "sushi"
                },
                new CategoryDTO
                {
                    category_name = "poke bowl"
                }
            };

            categoryDALMock.Setup(categoryDAL => categoryDAL.getCategory())
                .Returns(expectedCategories);

            Category category = new Category(categoryDALMock.Object);
            List<CategoryDTO> actualCategories = category.getCategory();

            //Act
            category.getCategory();

            //Assert
            for (int i = 0; i < expectedCategories.Count; i++)
            {
                Assert.AreEqual(expectedCategories[i].category_name, actualCategories[i].category_name);
            }
        }
    }
}
