using NotesApp.Domain;

namespace NotesApp.Service
{
    public interface INotesService
    {
        bool DeleteNote(Guid id);
        bool EditNote(Note note);
        Note? Get(Guid id);
        List<Note> GetAllNotes();
        bool InsertNote(Note newNote);
    }
}
