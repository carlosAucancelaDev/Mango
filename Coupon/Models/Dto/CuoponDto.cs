namespace Mango.Services.CouponAPI.Models.Dto
{
    public class CuoponDto
    {
        public int CuoponId { get; set; }
        public string CuoponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
