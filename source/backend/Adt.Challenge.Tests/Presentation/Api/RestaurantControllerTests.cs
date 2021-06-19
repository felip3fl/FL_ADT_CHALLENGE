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
            //act
            var controller = new RestaurantController(Mock.Of<IRestaurantService>());

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
    }
}
