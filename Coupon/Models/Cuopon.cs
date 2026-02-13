using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Models
{
    public class Cuopon
    {
        [Key]
        public int CuoponId { get; set; }
        [Required]
        public string CuoponCode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
