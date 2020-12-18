using Logic;
using NUnit.Framework;
using Interface;
using Moq;
using System.Collections.Generic;

namespace UnitTests
{
    public class CustomerUnitTests
    {
        private readonly Mock<ICustomerDAL> customerDALMock = new Mock<ICustomerDAL>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void addCustomer_MockSetupCustomer_VerifyValues()
        {
            //Arrange
            CustomerDTO customerDTO = new CustomerDTO
            {
                name = "Lei",
                street_housenr = "Straat 13",
                postal_code = "6085DL",
                place = "Horn",
                email = "442142@student.fontys.nl",
                phone_number = "0622978837"
            };

            customerDALMock.Setup(customerDAL => customerDAL.addCustomerAndReturnLastID(customerDTO));
            Customer customer = new Customer(customerDALMock.Object);

            //Act
            customer.addCustommer(customerDTO);

            //Assert
            customerDALMock.Verify(mock => mock.addCustomerAndReturnLastID(It.Is((CustomerDTO customerDTO) => 
                customerDTO.name == "Lei" &&
                customerDTO.street_housenr == "Straat 13" &&
                customerDTO.postal_code == "6085DL" &&
                customerDTO.place == "Horn" &&
                customerDTO.email == "442142@student.fontys.nl" &&
                customerDTO.phone_number == "0622978837"
            )));
        }

    }
}
