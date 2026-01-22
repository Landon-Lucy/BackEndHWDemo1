using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


namespace FrontEndAwesome.Pages
{
    public class HomeBase: ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }
    
        public List<Example>?  example { get; set; } //might be null

        protected override async Task OnInitializedAsync()
        {
            await LoadExample();
        }

        protected async Task LoadExample()
        {
            example = await Http.GetFromJsonAsync<List<Example>>( "Example/items" );
        }
    }
}
