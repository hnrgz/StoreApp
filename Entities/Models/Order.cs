using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Order
    {
        public int OrderId {get; set; }
        public ICollection<CartLine> Lines {get; set; } = new List<CartLine>();

        [Required(ErrorMessage = "Name is required.")]
        public String? Name {get; set; }

        [Required(ErrorMessage = "AdressLine1 is required.")]
        public String? AdressLine1 {get; set; }
        public String? AdressLine2 {get; set; }
        public String? AdressLine3 {get; set; }
        public String? City {get; set; }
        public bool GiftWrap {get; set; }
        public bool Shipped {get; set; }
        public DateTime OrderedAt {get; set; } = DateTime.Now;
    }
}