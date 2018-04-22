using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ToDoRazorApp.Models;

namespace ToDoRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        private const string Baseurl = "http://localhost:3002/api/todos";
        public List<Todo> Todos { get; set; }

        public async Task OnGetAsync()
        {
            Todos = await GetTodos();
        }

        public async Task<List<Todo>> GetTodos()
        {
            var client = new HttpClient();

            var content = await client.GetStringAsync(Baseurl);
            var todos = JsonConvert.DeserializeObject<List<Todo>>(content);

            return todos;
        }
    }
}