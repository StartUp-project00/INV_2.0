namespace INVUIs.Purchases.Models
{
    public class PurchaseProductModel
    {
        public Guid ProductId { get; set; }
        public string Designation { get; set; }
        public int TVA { get; set; }
        public string UnitMeasure { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total => Quantity * UnitPrice;
    }
}