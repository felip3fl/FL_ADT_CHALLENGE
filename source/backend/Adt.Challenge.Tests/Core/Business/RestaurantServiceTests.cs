using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Adt.Challenge.Business.Services;
using Adt.Challenge.Business.Interfaces.Repositories;
using System.Threading.Tasks;
using Adt.Challenge.Business.Models;

namespace Adt.Challenge.Tests.Core.Business
{
    public class RestaurantServiceTests
    {
        [Fact]
        public void ShouldCreate_New_Object()
        {
            //arrange
            var restaurantRepositoryMock = Mock.Of<IRestaurantRepository>();

            //act
            var result = new RestaurantService(restaurantRepositoryMock);

            //assert
            result.Should().NotBeNull();
        }

        [Theory]
        [MemberData(nameof(ValidStringHourMinute))]
        public async Task ValidHourMinute_ShouldReturn_NotBeNull(string HourMinute)
        {
            //arrange
            var restaurantsName = new List<string>();

            var restaurantRepositoryMock = new Mock<IRestaurantRepository>() ;
            restaurantRepositoryMock
            .Setup(s => s.GetNameByHourMinute(It.IsAny<TimeSpan>())).ReturnsAsync(restaurantsName);
                    
            var restaurantService = new RestaurantService(restaurantRepositoryMock.Object);

            //act 
            var result = await restaurantService.GetNameByHourMinute(HourMinute);

            //assert
            result.Should().NotBeNull();

        }

        [Theory]
        [MemberData(nameof(InvalidStringHourMinute))]
        public async Task InvalidHourMinute_ShouldReturn_Null(string HourMinute)
        {
            //arrange
            var restaurantsName = new List<string>();

            var restaurantRepositoryMock = new Mock<IRestaurantRepository>();
            restaurantRepositoryMock
                .Setup(s => s.GetNameByHourMinute(It.IsAny<TimeSpan>())).ReturnsAsync(restaurantsName);

            var restaurantService = new RestaurantService(restaurantRepositoryMock.Object);

            //act 
            var result = await restaurantService.GetNameByHourMinute(HourMinute);

            //assert
            result.Should().BeNull();

        }

        public static IEnumerable<object[]> ValidStringHourMinute()
        {
            return new[]
            {
                new object[] { "01:00"},
                new object[] { "03:00"},
                new object[] { "05:02"},
                new object[] { "09:30"},
                new object[] { "12:00"},
                new object[] { "14:00"},
                new object[] { "15:32"},
                new object[] { "17:45"},
                new object[] { "19:00"},
                new object[] { "21:03"},
                new object[] { "22:02"},
                new object[] { "23:59"},
                new object[] { "13:23"},
                new object[] { "18:18"},
            };
        }

        public static IEnumerable<object[]> InvalidStringHourMinute()
        {
            return new[]
            {
                new object[] { "0"},
                new object[] { "2:000"},
                new object[] { "222:0"},
                new object[] { "2200"},
                new object[] { "1100"},
                new object[] { "0010"},
                new object[] { "11"},
                new object[] { "00:78"},
                new object[] { "24:00"},
                new object[] { "27:00"},
                new object[] { "12:61"},
            };
        }

    }
}
