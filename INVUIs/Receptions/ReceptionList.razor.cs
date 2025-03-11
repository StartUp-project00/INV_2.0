using INV.App.Receipts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using INVUIs.Receptions.Models;

namespace INVUIs.Receptions
{
    public partial class ReceptionList
    {
        [Parameter] public EventCallback<ReceptionModel> OnCommand { get; set; }
        [Parameter] public List<ReceiptInfo> Receptions { get; set; }
        [Parameter] public RenderFragment Pills { get; set; }
        [Inject] public NavigationManager navigationManager { set; get; }

        public async Task navigatepage(Guid id) => Navigation.NavigateTo($"receptions/new/{id}");

        private ReceptionModel commandshow = new ReceptionModel();

        public EditContext editContext { get; set; }
        private bool CommandSelected = false;
    }
}