using Adt.Challenge.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adt.Challenge.Business.Interfaces.Repositories
{
    public interface IRepositoryBase
    {
        Task<List<Restaurant>> GetAll(bool ignoreHeader);
    }
}
