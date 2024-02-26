namespace Models.DTOs.Shipping.Econt
{
    public class CityDTO
    {
        public CountryDTO Country { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
    }
}