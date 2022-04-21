using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [MaxLength(50), Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
    }
}
