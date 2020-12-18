using Logic;
using NUnit.Framework;
using Interface;
using Moq;
using System.Collections.Generic;
using System;

namespace UnitTests
{
    public class OrderUnitTests
    {
        private readonly Mock<IOrderDAL> orderDALMock = new Mock<IOrderDAL>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void placeOrder_MockSetupOrder_VerifyValues()
        {
            //Arrange
            DateTime currentDateTime = DateTime.Now;

            OrderDTO orderDTO = new OrderDTO
            {
                customer_id = 4,
                total_price = 40.90M,
                payment_option = "iDEAL",
                status = "Nieuw",
                delivery_time = "16:00",
                remarks = "Graag sambal erbij",
                dateTime = currentDateTime
            };

            orderDALMock.Setup(orderDAL => orderDAL.placeOrderAndReturnLastID(orderDTO));
            Order order = new Order(orderDALMock.Object);

            //Act
            order.placeOrder(orderDTO);

            //Assert
            orderDALMock.Verify(mock => mock.placeOrderAndReturnLastID(It.Is((OrderDTO orderDTO) => 
                orderDTO.customer_id == 4 &&
                orderDTO.total_price == 40.90M &&
                orderDTO.payment_option == "iDEAL" &&
                orderDTO.status == "Nieuw" &&
                orderDTO.delivery_time == "16:00" &&
                orderDTO.remarks == "Graag sambal erbij" &&
                orderDTO.dateTime == currentDateTime
            )));
        }
    }
}
