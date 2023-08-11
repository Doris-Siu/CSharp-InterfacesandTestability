namespace main
{
    public class Order
    {
        internal Shipment Shipment;

        public bool IsShipped { get; set; }
        public float TotalPrice { get; internal set; }
        public DateTime DatePlaced { get; internal set; }
    }
}