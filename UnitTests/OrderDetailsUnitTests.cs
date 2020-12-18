using Logic;
using NUnit.Framework;
using Interface;
using Moq;
using System.Collections.Generic;

namespace UnitTests
{
    public class OrderDetailsUnitTests
    {
        private readonly Mock<IOrderDetailsDAL> orderDetailsDALMock = new Mock<IOrderDetailsDAL>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void insertOrderDetails_MockSetupOrderDetails_VerifyValues()
        {
            //Arrange
            OrderDetailsDTO orderDetailsDTO = new OrderDetailsDTO
            {
                dish_id = 2,
                order_id = 5,
                quantity = 1
            };

            orderDetailsDALMock.Setup(orderDetailsDAL => orderDetailsDAL.insertOrderDetails(orderDetailsDTO));
            OrderDetails orderDetails = new OrderDetails(orderDetailsDALMock.Object);

            //Act
            orderDetails.insertOrderDetails(orderDetailsDTO);

            //Assert
            orderDetailsDALMock.Verify(mock => mock.insertOrderDetails(It.Is((OrderDetailsDTO orderDetailsDTO) =>
                orderDetailsDTO.dish_id == 2 &&
                orderDetailsDTO.order_id == 5 &&
                orderDetailsDTO.quantity == 1
            )));
        }
    }
}
