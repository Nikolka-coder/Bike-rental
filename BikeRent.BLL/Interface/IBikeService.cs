using BikeRent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BikeRent.BLL.Interface
{
    public interface IBikeService
    {
        Task<List<Bike>> GetAllBikesAsync();
        Task<Bike> GetBikeByIdAsync(int bikeId);
        Task AddBikeAsync(Bike bike);
        Task EditBikeAsync(Bike bike);
        Task DeleteBikeAsync(int bikeId);
    }
}
