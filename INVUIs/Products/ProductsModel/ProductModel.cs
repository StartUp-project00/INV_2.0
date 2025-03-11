using System.ComponentModel.DataAnnotations;

namespace INVUIs.Products.ProductsModel
{
    public class ProductModel
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Name Product is required")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "UnitMeasure is required")]
        public string UnitMeasure { get; set; }


        [Required(ErrorMessage = "TVA is required")]
        public int TVA { get; set; } = 19;

        [Required(ErrorMessage = "default warehouse  is required")]
        public Guid DefaultWareHouseId { get; set; } 
    }
}