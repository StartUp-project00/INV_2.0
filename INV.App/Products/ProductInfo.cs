namespace INV.App.Products
{
    public class ProductInfo
    {
        public Guid Id { get; set; }
        public string Designation { get; set; }
        public string UnitMeasure { get; set; }
        public int Quantity { get; set; }
        public int TVA { get; set; }
        public Guid DefaultWareHouseId { get; set; }
        public string WareHouseName { get; set; }
    }
}
