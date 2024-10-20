using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Boabes_Roxana_Lab2.Models;

namespace Boabes_Roxana_Lab2.Data
{
    public class Boabes_Roxana_Lab2Context : DbContext
    {
        public Boabes_Roxana_Lab2Context (DbContextOptions<Boabes_Roxana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Boabes_Roxana_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Boabes_Roxana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
