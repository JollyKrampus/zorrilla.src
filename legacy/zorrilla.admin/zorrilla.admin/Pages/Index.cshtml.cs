using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using zorrilla.admin.Data;

namespace zorrilla.admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ZorrillaDbContext _context;

        public IndexModel(ZorrillaDbContext context)
        {
            _context = context;
        }

        public List<Client> Clients { get; set; }

        public async Task OnGetAsync()
        {
            Clients = await _context.Clients.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(Client newClient)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clients.Add(newClient);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }


        [BindProperty]
        public Client NewClient { get; set; }
    }
}
