using DockerProject.Controllers;
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
            var sut = new UsersController();
            //Act
            var result = (OkObjectResult)await sut.Get();
            //Assert

            result.StatusCode.Should().Be(200);
        }
        [Fact]
        public async Task Get_onSucccess_InvokesUserService()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();
            var sut = new UsersController(mockUserService.Object);
            //Act
            var result = (OkObjectResult)await sut.Get();
            //Assert

            result.StatusCode.Should().Be(200);
        }
    }
}