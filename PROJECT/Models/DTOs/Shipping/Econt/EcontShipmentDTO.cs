namespace Models.DTOs.Shipping.Econt
{
    public class EcontShipmentDTO: ShippingDetails
    {
        public ShippingLabelDTO Label { get; set; }
        public string Mode { get; set; }
    }
}
