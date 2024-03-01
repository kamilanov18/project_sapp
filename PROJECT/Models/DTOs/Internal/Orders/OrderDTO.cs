namespace Models.DTOs.Internal.Orders
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string ClientNames { get; set; }
        public bool IsPossibleDuplicate { get; set; }
        public string ClientAddress { get; set; }
        public string Products { get; set; }
        public string ProductCounts { get; set; }

    }
}
