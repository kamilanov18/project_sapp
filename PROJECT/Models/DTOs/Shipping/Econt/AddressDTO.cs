namespace Models.DTOs.Shipping.Econt
{
    public class AddressDTO
    {
        public int? Id { get; set; }
        public CityDTO? City { get; set; }
        public string? Street { get; set; }
        public string? Num { get; set; }
        public string? Other { get; set; }
        public LocationDTO? Location { get; set; }
        public string? FullAddress { get; set; }
        public string? FullAddressEn { get; set; }
        public string? Quarter { get; set; }
        public string? Zip { get; set; }
        public string? Hezid { get; set; }
    }
}
