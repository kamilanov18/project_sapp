namespace Models.DTOs.Shipping.Econt
{
    public class ValidateAddressResponseDTO
    {
        public AddressDTO Address { get; set; }
        public string? ValidationStatus { get; set; }
    }
}
