
using fiorellopb101.Data;
using fiorellopb101.Servioces.Interfaces;
using fiorellopb101.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace fiorellopb101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderServices _sliderServices;
        public HomeController(ISliderServices sliderServices)
        {
            _sliderServices = sliderServices;
        }

        public async Task< IActionResult> Index()
        {
            HomeVM model = new()
            {
                Sliders = await _sliderServices.GetAllasync(),
                SliderInfo = await _sliderServices.GetSliderInfoAsync()
            };
            return View(model);
        }
      
    }
}