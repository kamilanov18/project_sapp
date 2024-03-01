namespace Models.DTOs.Shipping.Econt
{
    public class CityDTO
    {
        public CountryDTO? Country { get; set; }
        public string? Name { get; set; }
        public string? PostCode { get; set; }
        public string? NameEn { get; set; }
        public string? RegionName { get; set; }
        public string? RegionNameEn { get; set; }
        public string? PhoneCode { get; set; }
        public LocationDTO? Location { get; set; }
        public bool? ExpressCityDeliveries { get; set; }
        public bool? Monday { get; set; }
        public bool? Tuesday { get; set; }
        public bool? Wednesday { get; set; }
        public bool? Thursday { get; set; }
        public bool? Friday { get; set; }
        public bool? Saturday { get; set; }
        public bool? Sunday { get; set; }
        public int? ServiceDays { get; set; }
        public int? ZoneId { get; set; }
        public string? ZoneName { get; set; }
        public string? ZoneNameEn { get; set; }
    }
}