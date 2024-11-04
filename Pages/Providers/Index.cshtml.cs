using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWeb.Data;
using SupermarketWeb.Models;

namespace SupermarketWeb.Pages.Providers
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketWeb.Data.SupermarketContext _context;

        public IndexModel(SupermarketWeb.Data.SupermarketContext context)
        {
            _context = context;
        }

        public IList<Provider> Provider { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Provider = await _context.Providers.ToListAsync();
        }
    }
}
