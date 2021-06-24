using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Adt.Challenge.Infra.Data.Repository.Crv;

namespace Adt.Challenge.Tests.Infra.Data
{
    public class RestaurantRepositoryTests
    {
        [Theory]
        [MemberData(nameof(ValidHourMinuteQuantity))]
        public async Task ValidHourMinute_ShouldReturn_restaurantsQuantity(TimeSpan HourMinute, int quantityExpected)
        {
            //arrange
            var sut = new RestaurantRepository();

            //act 
            var result = await sut.GetNameByHourMinute(HourMinute);

            //assert
            result.Count.Should().Be(quantityExpected);
        }

        public static IEnumerable<object[]> ValidHourMinuteQuantity()
        {
            return new[]
            {
                new object[] { new TimeSpan(00,00,00), 0 },
                new object[] { new TimeSpan(01,00,00), 0 },
                new object[] { new TimeSpan(02,00,00), 0 },
                new object[] { new TimeSpan(03,00,00), 0 },
                new object[] { new TimeSpan(04,00,00), 0 },
                new object[] { new TimeSpan(05,00,00), 0 },
                new object[] { new TimeSpan(06,00,00), 0 },
                new object[] { new TimeSpan(07,00,00), 0 },
                new object[] { new TimeSpan(08,00,00), 0 },
                new object[] { new TimeSpan(09,00,00), 14 },
                new object[] { new TimeSpan(10,00,00), 15 },
                new object[] { new TimeSpan(11,00,00), 39 },
                new object[] { new TimeSpan(12,00,00), 51 },
                new object[] { new TimeSpan(13,00,00), 51 },
                new object[] { new TimeSpan(14,00,00), 51 },
                new object[] { new TimeSpan(15,00,00), 51 },
                new object[] { new TimeSpan(16,00,00), 51 },
                new object[] { new TimeSpan(17,00,00), 51 },
                new object[] { new TimeSpan(18,00,00), 37 },
                new object[] { new TimeSpan(19,00,00), 37 },
                new object[] { new TimeSpan(20,00,00), 37 },
                new object[] { new TimeSpan(21,00,00), 37 },
                new object[] { new TimeSpan(22,00,00), 32 },
                new object[] { new TimeSpan(23,00,00), 16 },
            };
        }
    }
}
