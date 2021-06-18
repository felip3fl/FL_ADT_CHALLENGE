using Adt.Challenge.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adt.Challenge.Business.Interfaces.Repositories
{
    public interface IRestaurantRepository
    {
        Task<List<String>> GetNameByHourMinute(TimeSpan hourMinute);
    }
}
