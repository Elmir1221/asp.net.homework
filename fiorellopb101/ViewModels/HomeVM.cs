using fiorellopb101.Models;
using fiorellopb101.Servioces.Interfaces;

namespace fiorellopb101.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
    }
}
