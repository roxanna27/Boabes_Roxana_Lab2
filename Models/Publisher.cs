using Boabes_Roxana_Lab2.Migrations;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boabes_Roxana_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}