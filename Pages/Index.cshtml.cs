using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Boabes_Roxana_Lab2.Data;
using Boabes_Roxana_Lab2.Models;

namespace Boabes_Roxana_Lab2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Boabes_Roxana_Lab2.Data.Boabes_Roxana_Lab2Context _context;

        public IndexModel(Boabes_Roxana_Lab2.Data.Boabes_Roxana_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
