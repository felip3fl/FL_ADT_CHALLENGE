using Adt.Challenge.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adt.Challenge.Business.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
