using Logic;
using NUnit.Framework;
using Interface;
using Moq;
using System.Collections.Generic;
using System;

namespace UnitTests
{
    public class UserUnitTests
    {
        private readonly Mock<IUserDAL> userDALMock = new Mock<IUserDAL>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void login_MockSetupUser_VerifyValues()
        {
            //Arrange
            UserDTO userDTO = new UserDTO
            {
                email = "testemail",
                password = "testpassword"
            };

            userDALMock.Setup(userDAL => userDAL.login(userDTO));
            User user = new User(userDALMock.Object);

            //Act
            user.login(userDTO);

            //Assert
            userDALMock.Verify(mock => mock.login(It.Is((UserDTO userDTO) =>
                userDTO.email == "testemail" &&
                userDTO.password == "testpassword"
            )));
        }
    }
}
