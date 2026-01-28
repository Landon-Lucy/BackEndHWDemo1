using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


    public class ProvidedBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<TestItem>? items { get; set; } //might be null

    public bool loading = false;
    public string error = null;
    public bool showModal = false;
    public bool isEditing = false;
    public string modalName = "";
    public int idToEdit = 0;

    protected override async Task OnInitializedAsync()
        {
            loading = true;
            await LoadItems();
            loading = false;
    }

        protected async Task LoadItems()
        {
            items = await Http.GetFromJsonAsync<List<TestItem>>("Test/items");
        }


        protected async Task SaveItem()
        {
        //check if editing or creating
        if (isEditing)
        {
            TestItem newItem = new TestItem
            {
                Name = modalName,
                Id = idToEdit
            };
            //update existing item
            await Http.PutAsJsonAsync($"Test/items/{idToEdit}", newItem);
        }
        else
        {
            //create new item
            TestItem newItem = new TestItem
            {
                Name = modalName
            };
            await Http.PostAsJsonAsync("Test/items", newItem);
        }

        showModal = false;
        modalName = "";

        loading = true;
        await LoadItems();
        loading = false;
    }


        protected async Task DeleteItem(int id)
        {
        await Http.DeleteAsync($"Test/items/{id}");
        await LoadItems();
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
        modalName = item.Name;
        idToEdit = item.Id;
    }

    public void CloseModal()
    {
        showModal = false;
        modalName= "";
    }

}
