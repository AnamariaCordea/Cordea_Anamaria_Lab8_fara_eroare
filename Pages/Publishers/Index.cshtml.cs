using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cordea_Anamaria_Lab8.Data;
using Cordea_Anamaria_Lab8.Models;

namespace Cordea_Anamaria_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Cordea_Anamaria_Lab8.Data.Cordea_Anamaria_Lab8Context _context;

        public IndexModel(Cordea_Anamaria_Lab8.Data.Cordea_Anamaria_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
