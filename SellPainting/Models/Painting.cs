using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;

namespace SellPainting.Models
{
    public class Painting
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NickName { get; set; }    
        public DateTime UploadDate { get; set; } = DateTime.Now;
        public string PictureUrl {  get; set; }
        public int CategoryId {  get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        public double Price {  get; set; }
        [ValidateNever]
        public string IdArtists {  get; set; }
        [ForeignKey("IdUser")]
        [ValidateNever]
        public ApplicationUser User { get; set; }
        public bool Valid { get; set; }
    }
}
