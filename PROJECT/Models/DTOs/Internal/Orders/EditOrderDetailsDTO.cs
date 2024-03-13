using Models.DTOs.Shipping.Econt;

namespace Models.DTOs.Internal.Orders
{
    public class EditOrderDetailsDTO
    {
        public int Id { get; set; }
        public AddressDTO Address { get; set; }
    }
}
