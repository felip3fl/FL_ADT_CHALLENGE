using System;
using System.Collections.Generic;
using System.Text;
using Adt.Challenge.Api.Controllers.V1;
using Adt.Challenge.Business.Interfaces.Services;
using Moq;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Adt.Challenge.Business.Models;

namespace Adt.Challenge.Tests.Presentation.Api
{
    public class RestaurantControllerTests
    {
        [Fact]
        public void Should_Create_New_Object()
        {
            //arrange
            var mockRestaurantService = Mock.Of<IRestaurantService>();

            //act
            var controller = new RestaurantController(mockRestaurantService);

            //assert
            controller.Should().NotBeNull();
        }

        [Fact]
        public async Task InvalidHourMinute_ShouldReturn_NotFound()
        {
            //arrange
            var hourMinute = "00";
            var restaurantController = new RestaurantController(Mock.Of<IRestaurantService>());

            //act
            var result = await restaurantController.GetNameByHourMinute(hourMinute);

            //assert
            result
                .Should().BeOfType<NotFoundObjectResult>()
                .Which.Value.Should().Be(hourMinute);
        }

        [Fact]
        public async Task ValidHourMinute_ShouldReturn_Ok()
        {
            //arrange
            var hourMinute = "00:12";
            var expectedReturn = new List<string>();
            var service = new Mock<IRestaurantService>();
            service
                .Setup(x => x.GetNameByHourMinute(It.IsAny<string>()))
                .ReturnsAsync(expectedReturn);

            var controller = new RestaurantController(service.Object);

            //act
            var result = await controller.GetNameByHourMinute(hourMinute);

            //assert
            result.Should().BeOfType<OkObjectResult>().Which.Value.Should().Be(expectedReturn);
        }

    }
}
