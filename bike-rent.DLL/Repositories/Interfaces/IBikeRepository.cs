using bike_rent.DLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bike_rent.DLL.Repositories.Interfaces
{
    public interface IBikeRepository : IGenericRepository<Bike>
    {
        Task<List<Bike>> GetBikes();
    }
}
