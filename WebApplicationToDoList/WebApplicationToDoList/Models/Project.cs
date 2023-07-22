using System;
namespace WebApplicationToDoList.Models
{
	public class Project
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Time { get; set; }


		public Todoo todoo { get; set; }

		ModelBuilder.Entity<Project>().HasData(

			new Project{
            Id =1,
            Name="C#",
            Time=2)}

}
}