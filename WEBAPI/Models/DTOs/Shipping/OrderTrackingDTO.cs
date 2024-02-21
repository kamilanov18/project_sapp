namespace Models.DTOs.Shipping
{
    public class OrderTrackingDTO
    {
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
