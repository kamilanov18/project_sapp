namespace Models.DTOs.Shipping.Econt
{
    public class ShippingLabelDTO
    {
        public ClientDTO SenderClient { get; set; }
        public ClientDTO ReceiverClient { get; set; }
        public AddressDTO SenderAddress { get; set; }
        public AddressDTO ReceiverAddress { get; set; }
        public int PackCount { get; set; }
        public string ShipmentType { get; set; }
        public int Weight { get; set; }
        public string ShipmentDescription { get; set; }
    }
}
