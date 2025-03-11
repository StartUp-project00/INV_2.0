using INV.App.Products;
using INV.Domain.Entities.Products;
using Microsoft.AspNetCore.Components;
using INVUIs.Products.ProductsModel;

namespace INVUIs.Products
{
    public partial class ProductsList
    {
        [Parameter] public EventCallback<ProductModel> OnCommand { get; set; }
        [Inject] public NavigationManager navigationManager { set; get; }
        [Inject] IProductService ProductService { get; set; }
        [Parameter] public List<ProductInfo> Products { get; set; }


        public async Task navigatepage(Guid id) => Navigation.NavigateTo($"products/new/{id}");
      
        //private ProductModel commandshow = new ProductModel();

        private bool CommandSelected = false;
   
        private Product newProduct = new Product();
        private bool showForm = false;

        private async Task SaveProduct()
        {

            Console.WriteLine("SaveProduct called");
            await ProductService.CreateProduct(newProduct);
            newProduct = new Product();
            StateHasChanged();
            showForm = false;

        }
        private void EditProduct(ProductInfo product)
        {
            //newProduct = ;
            //showForm = true;
        }
        private void DeleteProduct(Guid productId)
        {
            var productToRemove = Products.FirstOrDefault(p => p.Id == productId);
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
            }
        }
    

    }







} 