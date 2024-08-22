using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SellPainting.Models.ViewModels
{
    public class SellPaintingVM
    {
        public Painting Painting { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
