using System.ComponentModel.DataAnnotations;

namespace DotNet.LaptopStore.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Book ID is required")]
        public int LaptopId { get; set; }

        public virtual Laptop? Laptop { get; set; }

        [Required(ErrorMessage = "Cart ID is required")]
        public int CartId { get; set; }

        public virtual Cart? Cart { get; set; }
    }
}
