using INV.Domain.Entities.Purchases;
using INV.Domain.Entities.Suppliers;

namespace INV.App.Purchases
{
    public class PurchaseOrderInfo
    {
        public Guid Id { set; get; }
        public string Number { set; get; }
        public DateOnly Date { set; get; }
        public Supplier Supplier { get; set; }
        public PurchaseStatus Status { get; set; }
    }
}