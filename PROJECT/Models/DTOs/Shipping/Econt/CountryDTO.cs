namespace Models.DTOs.Shipping.Econt
{
    public class CountryDTO
    {
        public int? Id { get; set; }
        public string? Code3 { get; set; }
        public string? Code2 { get; set; }
        public string? Name { get; set; }
        public string? NameEn { get; set; }
        public bool? IsEU { get; set; }
    }
}