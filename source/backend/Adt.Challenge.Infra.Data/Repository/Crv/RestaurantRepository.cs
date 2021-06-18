using Adt.Challenge.Business.Interfaces.Repositories;
using Adt.Challenge.Business.Models;
using Adt.Challenge.Infra.Data.Repository.Crv.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt.Challenge.Infra.Data.Repository.Crv
{
    public class RestaurantRepository : IRestaurantRepository, IRepositoryBase 
    { 
        private readonly string SourceAddress = AppDomain.CurrentDomain.BaseDirectory + @"Repository\Crv\Source\restaurant-hours.csv";

        public async Task<List<string>> GetNameByHourMinute(TimeSpan hourMinutetime)
        {
            var restaurants = await this.GetAll(true);

            var restaurantsByHourMinute = (from student in restaurants
                                           where student.TimeOpen <= hourMinutetime
                                           && student.TimeClosed >= hourMinutetime
                                           select student.Name).ToList();

            return restaurantsByHourMinute;
        }

        public async Task<List<Restaurant>> GetAll(bool ignoreHeader)
        {
            var cvsData = await System.IO.File.ReadAllLinesAsync(SourceAddress);
            var restaurants = new List<Restaurant>();

            foreach (string line in cvsData)
            {
                if (ignoreHeader)
                {
                    ignoreHeader = false;
                    continue;
                }

                var csvLine = line.Split(',');
                var openHourstime = csvLine[(int)HeaderRestaurantRepositoryEnum.OpenHours].Split('-');

                restaurants.Add(new Restaurant
                {
                    Name = csvLine[(int)HeaderRestaurantRepositoryEnum.RestaurantName].ToString(),
                    TimeOpen = Convert.ToDateTime(openHourstime[0]).TimeOfDay,
                    TimeClosed = Convert.ToDateTime(openHourstime[1]).TimeOfDay,
                    Active = true
                });
            }

            return restaurants;
        }
    }
}
