using Models.DTOs.Internal.Products;
using Models.DTOs.Shipping;

namespace Models.DTOs.Internal.Orders
{
    public class OrderDetailsDTO
    {
        public int Id { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ProvidedAddress { get; set; }
        public IAddressDTO Address { get; set; }
        public List<ProductItemDTO> Products { get; set; }
    }
}
