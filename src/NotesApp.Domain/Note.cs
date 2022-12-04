using System.ComponentModel.DataAnnotations;

namespace NotesApp.Domain
{
	public class Note : BaseEntity
	{
		[Required]
		public string Message { get; set; } = "";
		[Required]
		public string Author { get; set; } = "";
		[Required]
		public string Subject { get; set; } = "";
	}
}
