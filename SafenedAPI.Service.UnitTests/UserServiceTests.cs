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
        private string username = "username";
        private string password = "password";
        
        [Fact]
        public void UserShouldLoginWithCorrectUsernameAndPassword()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(s => s.Login(username, password)).Returns(true);

            var userService = new UserService(userRepositoryMock.Object);
            var result = userService.Login(username, password);

            Assert.True(result);
        }

        [Fact]
        public void UserShouldNotLoginWithIncorrectUsernameAndPassword()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(s => s.Login(username, password)).Returns(true); ;

            var userService = new UserService(userRepositoryMock.Object);
            var result = userService.Login("user", "pwd");

            Assert.False(result);
        }
    }
}
