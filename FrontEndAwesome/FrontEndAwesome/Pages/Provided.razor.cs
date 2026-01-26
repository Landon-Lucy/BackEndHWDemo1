using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


    public class ProvidedBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<TestItem>? items { get; set; } //might be null

    //dummy values for now
        public bool loading = false;
    public string error = null;
    public bool showModal = false;
    public bool isEditing = false;
    public string modalName = "Test";

        protected override async Task OnInitializedAsync()
        {
            await LoadItems();
        }

        protected async Task LoadItems()
        {
            items = await Http.GetFromJsonAsync<List<TestItem>>("Test/items");
        }


        protected async Task SaveItem()
        {
        //check if editing or creating
        await Http.PostAsJsonAsync<TestItem>("Test/items", new TestItem());
        }

        protected async Task DeleteItem(int id)
        {
            await Http.DeleteFromJsonAsync<TestItem>($"Test/items/{id}");
        }

    protected async Task OpenCreateModal()
    {
        showModal = true;
        isEditing = false;
    }

    protected async Task OpenEditModal(TestItem item)
    {
        showModal = true;
        isEditing = true;
    }

    public void CloseModal()
    {
        showModal = false;
    }

}
