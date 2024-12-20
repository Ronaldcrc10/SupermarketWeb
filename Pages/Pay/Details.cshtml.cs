﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWeb.Data;
using SupermarketWeb.Models;

namespace SupermarketWeb.Pages.Pay
{
    public class DetailsModel : PageModel
    {
        private readonly SupermarketWeb.Data.SupermarketContext _context;

        public DetailsModel(SupermarketWeb.Data.SupermarketContext context)
        {
            _context = context;
        }

        public PayMode PayMode { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymode = await _context.PayMode.FirstOrDefaultAsync(m => m.Id == id);
            if (paymode == null)
            {
                return NotFound();
            }
            else
            {
                PayMode = paymode;
            }
            return Page();
        }
    }
}
