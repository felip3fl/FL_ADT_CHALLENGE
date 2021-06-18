using Adt.Challenge.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adt.Challenge.Business.Interfaces.Services
{
    public interface IRestaurantService : IServiceBase<Restaurant> 
    {
        Task<List<string>> GetNameByHourMinute(string hourMinute);
    }
}
