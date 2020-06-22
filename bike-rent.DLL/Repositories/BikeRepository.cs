using BikeRent.DAL.Models;
using BikeRent.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BikeRent.DAL.Repositories
{
    public class BikeRepository : GenericRepository<Bike>, IBikeRepository
    {
        public BikeRepository(AppDbContext appDbContext)
            :base(appDbContext)
        { }

        public async Task<List<Bike>> GetBikes() => await GetAll().ToListAsync();
        
    }
}
