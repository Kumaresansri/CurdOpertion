using System.ComponentModel.DataAnnotations;

namespace CollectionData.Model
{
	public class Student
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string? Name { get; set; }
		public string? Address { get; set; }
		public string? PhoneNo { get; set; }	
	}
}
