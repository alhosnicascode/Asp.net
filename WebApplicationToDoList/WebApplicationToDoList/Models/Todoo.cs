using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationToDoList.Models
{
    public class Todoo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ProjectID { get; set; }
        [ForeignKey("ProjectID")]

        public Project project { get; set; }


        ModelBuilder.Entity<Todoo>().HasData(
            new Todoo{
            Id =1,
            Name="Ass",
            Description="fullday")}

    }
     
}
