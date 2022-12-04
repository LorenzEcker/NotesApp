using NotesApp.Domain;

namespace NotesApp.Data
{

	public class NotesDb : INotesDb
	{
		private Dictionary<Guid, Note> db = new Dictionary<Guid, Note>();

		public List<Note> GetAllNotes()
		{
			return db.Values.ToList();
		}

		public Note? Get(Guid id)
		{
			try
			{
				return db[id];
			}
			catch
			{
				return null;
			}
		}

		public bool EditNote(Note note)
		{
			if (Exists(note))
			{
				note.Created = Get(note.Id)?.Created ?? DateTime.Now;
				DeleteNote(note.Id);
				note.LastModified = DateTime.Now;
				InsertNote(note);
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool InsertNote(Note newNote)
		{
			try
			{
				newNote.Id = Guid.NewGuid();
				newNote.Created = DateTime.Now;
				newNote.LastModified = DateTime.Now;
				db.Add(newNote.Id, newNote);
			}
			catch
			{
				return false;
			}
			return true;
		}

		public bool DeleteNote(Guid id)
		{
			return db.Remove(id);
		}

		public void DropNotes()
		{
			db.Clear();
		}

		public bool Exists(Note note)
		{
			return db.ContainsKey(note.Id);
		}
	}
}