using bike_rent.DLL.Models;
using bike_rent.DLL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bike_rent.DLL.Repositories
{
    public class BikeRepository : GenericRepository<Bike>, IBikeRepository
    {
        public BikeRepository(AppDbContext appDbContext)
            :base(appDbContext)
        { }

        public async Task<List<Bike>> GetBikes() => await GetAll().ToListAsync();
        
    }
}
