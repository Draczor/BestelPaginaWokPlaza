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

        [Test]
        public void returnAllOrders_MockSetupOrder_AreEqual()
        {
            //Arrange
            DateTime currentDateTime = DateTime.Now;

            List<AllOrdersDTO> expectedOrders = new List<AllOrdersDTO>()
            {
                new AllOrdersDTO
                {
                    id = 1,
                    customer_id = 3,
                    total_price = 25,
                    payment_option = "Contant",
                    status = "Nieuw",
                    delivery_time = "17:00",
                    remarks = "Contactloos bezorgen",
                    dateTime = currentDateTime,
                    name = "Tom van Tommers",
                    street_housenr = "Kleinstraat 24",
                    postal_code = "6066AA",
                    place = "Hemeltje",
                    email = "tom@tommy.nl",
                    phone_number = "0612345678"
                },
                new AllOrdersDTO
                {
                    id = 2,
                    customer_id = 4,
                    total_price = 50.5m,
                    payment_option = "iDEAL",
                    status = "Nieuw",
                    delivery_time = "18:00",
                    remarks = "Contactloos bezorgen",
                    dateTime = currentDateTime,
                    name = "Bob van Bollen",
                    street_housenr = "Grootstraat 20",
                    postal_code = "6044AA",
                    place = "Polder",
                    email = "bob@bobby.nl",
                    phone_number = "0612345688"
                }
            };

            orderDALMock.Setup(orderDAL => orderDAL.returnAllOrders())
                .Returns(expectedOrders);

            Order order = new Order(orderDALMock.Object);
            List<AllOrdersDTO> actualOrders = order.returnAllOrders();

            //Act
            order.returnAllOrders();

            //Assert
            for (int i = 0; i < expectedOrders.Count; i++)
            {
                Assert.AreEqual(expectedOrders[i].name, actualOrders[i].name);
            }
        }
    }
}
