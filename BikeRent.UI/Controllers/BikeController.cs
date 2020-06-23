using System.Linq;
using System.Threading.Tasks;
using BikeRent.BLL.Interface;
using BikeRent.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeRent.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BikeController : ControllerBase
    {

        private readonly IBikeService _bikeService;

        public BikeController(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }

        //[HttpGet]
        //public async Task<IActionResult> Index() => View((await _bikeService.GetAllBikesAsync()).OrderBy(m => m.Id));

        //[HttpGet]
        //public async Task<IActionResult> Create() => await Task.Run(() => View());

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Bike bike)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _bikeService.AddBikeAsync(bike);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(bike);
        //}

        //[HttpGet]
        //public async Task<IActionResult> Edit(int bikeId) =>
        //    await _bikeService.GetBikeByIdAsync(bikeId) is var bike == null
        //        ? (IActionResult)NotFound()
        //        : View(bike);

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Bike bike)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _bikeService.EditBikeAsync(bike);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(bike);
        //}

        //[HttpGet]
        //public async Task<IActionResult> Delete(int bikeId) =>
        //    await _bikeService.GetBikeByIdAsync(bikeId) is var bike == null
        //        ? (IActionResult)NotFound()
        //        : View(bike);

        //[HttpPost, ActionName("Delete")]
        ////[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmedAsync(int bikeId)
        //{
        //    await _bikeService.DeleteBikeAsync(bikeId);
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
