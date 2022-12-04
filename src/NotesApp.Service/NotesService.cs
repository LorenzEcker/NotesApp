using NotesApp.Data;
using NotesApp.Domain;

namespace NotesApp.Service
{
	public class NotesService : INotesService
	{
		private INotesDb Db { get; set; }

		public NotesService(INotesDb db)
		{
			Db = db;
		}

		public bool DeleteNote(Guid id)
		{
			return Db.DeleteNote(id);
		}

		public bool EditNote(Note note)
		{
			return Db.EditNote(note);
		}

		public Note? Get(Guid id)
		{
			return Db.Get(id);
		}

		public List<Note> GetAllNotes()
		{
			return Db.GetAllNotes();
		}

		public bool InsertNote(Note newNote)
		{
			return Db.InsertNote(newNote);
		}
	}
}
