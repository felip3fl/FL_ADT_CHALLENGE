using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adt.Challenge.Business.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
