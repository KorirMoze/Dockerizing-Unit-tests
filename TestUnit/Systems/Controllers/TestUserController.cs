using DockerProject.Controllers;
using DockerProject.Models;
using DockerProject.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TestUnit.Systems.Controllers
{
    public class TestUserController
    {
        [Fact]
        public async Task Get_onSuccess_ReturnsCode200()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();

            var sut = new UsersController(mockUserService.Object);
            //Act
            var result = (OkObjectResult)await sut.Get();
            //Assert

            result.StatusCode.Should().Be(200);
        }
        [Fact]
        public async Task Get_onSucccess_InvokesUserServiceExactlyOnce()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();
            mockUserService
                .Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());

            var sut = new UsersController(mockUserService.Object);
            //Act
            var result = await sut.Get();
            //Assert
            mockUserService.Verify(
                service => service.GetAllUsers(), 
                Times.Once());
        }
        [Fact]
        public async Task Get_onSuccess_ReturnsListofUsers()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();

            mockUserService
                .Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());

            var sut = new UsersController(mockUserService.Object);
            //Act
            var result = await sut.Get();
            //Assert
            mockUserService.Verify(
                service => service.GetAllUsers(),
                Times.Once());
        }
    }
}