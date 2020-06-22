using BikeRent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BikeRent.DAL.Repositories.Interfaces
{
    public interface IBikeRepository : IGenericRepository<Bike>
    {
        Task<List<Bike>> GetBikes();
    }
}
