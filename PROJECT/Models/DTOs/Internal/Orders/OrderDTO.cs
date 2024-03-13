using Models.DTOs.Internal.Products;

namespace Models.DTOs.Internal.Orders
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string ClientNames { get; set; }
        public bool IsPossibleDuplicate { get; set; }
        public string ClientAddress { get; set; }
        public List<ProductItemDTO> Products { get; set; }

    }
}
