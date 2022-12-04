using NotesApp.Domain;

namespace NotesApp.Data
{
	public interface INotesDb
	{
		bool DeleteNote(Guid id);
		bool EditNote(Note note);
		Note? Get(Guid id);
		List<Note> GetAllNotes();
		bool InsertNote(Note newNote);
		bool Exists(Note note);
		void DropNotes();
	}
}
