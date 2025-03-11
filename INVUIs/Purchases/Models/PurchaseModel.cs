using INV.Domain.Entities.Budget;
using INV.Domain.Entities.Suppliers;

namespace INVUIs.Purchases.Models
{
    public class PurchaseModel
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public DateOnly Date { get; set; }
        public Supplier Supplier { get; set; }
        public Article Article { get; set; }
        public ServiceType ServiceType { get; set; }
        public BudgeType BudgeType { get; set; }
        public int DeliveryTime { get; set; }
        public List<PurchaseProductModel> ProductModels { get; set; } = new List<PurchaseProductModel>();

        public decimal TotalHT => ProductModels.Sum(p => p.Total);

        public decimal TotalTVA => ProductModels.Sum(p => p.Quantity * p.UnitPrice * p.TVA) / 100;

        public decimal TotalTTC => TotalHT + TotalTVA;
    }
}