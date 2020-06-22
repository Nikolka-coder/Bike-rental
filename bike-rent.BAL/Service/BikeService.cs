using BikeRent.BLL.Interface;
using BikeRent.DAL.Models;
using BikeRent.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BikeRent.BLL.Service
{
    public class BikeService: IBikeService
    {
        private readonly IBikeRepository _bikeRepository;
        public BikeService(IBikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public async Task<List<Bike>> GetAllBikesAsync() => await _bikeRepository.GetAll().ToListAsync();

      
        public async Task<Bike> GetBikeByIdAsync(int bikeId) => await _bikeRepository.GetByIdAsync(bikeId);

        public async Task AddBikeAsync(Bike bike) => await _bikeRepository.CreateAsync(bike);

        public async Task DeleteBikeAsync(int bikeId) => await _bikeRepository.DeleteAsync(bikeId);

        public async Task EditBikeAsync(Bike bike) => await _bikeRepository.UpdateAsync(bike);
    }
}
