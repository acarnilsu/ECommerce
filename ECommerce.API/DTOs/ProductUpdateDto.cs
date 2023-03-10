namespace ECommerce.API.DTOs
{
    public class ProductUpdateDto
    {
        public string Id { get; set; }
        public string? barcode { get; set; }  //unique değer
        public string? name { get; set; }
        public string? stock { get; set; }
        public string? price { get; set; }
        public string? imageUrl1 { get; set; }
    }
}
