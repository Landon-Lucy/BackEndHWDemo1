using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


namespace FrontEndAwesome.Pages
{
    public class ProvidedBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<TestItem>? items { get; set; } //might be null

        protected override async Task OnInitializedAsync()
        {
            await LoadItems();
        }

        protected async Task LoadItems()
        {
            items = await Http.GetFromJsonAsync<List<TestItem>>("Test/items");
        }


        SaveItem()
        {

        }

        protected async Task DeleteItem(int id)
        {
            items = await Http.DeleteFromJsonAsync<List<TestItem>>("Test/items");
        }

        OpenCreateModal()
        {

        }

        OpenEditModal(TestItem item)
        {

        }

        CloseModal()
        {

        }

    }
}
