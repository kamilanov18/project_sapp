namespace Models.DTOs.Shipping.Econt
{
    public class AddressDTO
    {
        public CityDTO City { get; set; }
        public string Street { get; set; }
        public string Num { get; set; }
        public string? Other { get; set; }
    }
}
