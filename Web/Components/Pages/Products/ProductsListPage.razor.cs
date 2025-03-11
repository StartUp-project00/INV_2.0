using INV.App.Products;
using Microsoft.AspNetCore.Components;

namespace INV.Web.Components.Pages.Products;

public partial class ProductsListPage
{
    [Inject] public IProductService ProductService { get; set; }

    private List<ProductInfo> products;

    protected override async Task OnInitializedAsync()
    {

        // var result = await ProductService.SelectProducts();
        try
        {
            products = await ProductService.GetProducts();
            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
    
}