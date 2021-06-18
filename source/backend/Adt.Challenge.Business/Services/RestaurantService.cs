using Adt.Challenge.Business.Interfaces.Repositories;
using Adt.Challenge.Business.Interfaces.Services;
using Adt.Challenge.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adt.Challenge.Business.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public Task<List<Restaurant>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetNameByHourMinute(string hourMinute)
        {
            try
            {
                var hourMinuteTime = Convert.ToDateTime(hourMinute).TimeOfDay;
                return this.GetNameByHourMinute(hourMinuteTime);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public Task<List<string>> GetNameByHourMinute(TimeSpan hourMinute)
        {
            try
            {
                return _restaurantRepository.GetNameByHourMinute(hourMinute);
            }
            catch (Exception ex)
            {   
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
