using Moq;
using SafenedAPI.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SafenedAPI.Service.UnitTests
{
    
    public class UserServiceTests
    {
        [Fact]
        public void UserShouldLoginWithCorrectUsernameAndPassword()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(s => s.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var userService = new UserService(userRepositoryMock.Object);
            var result = userService.Login("username", "password");

            Assert.True(result);
        }
    }
}
