using Notely.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notely.Repositories
{
    public interface INoteRepository
    {
        Note FindNoteById(long id);
        IEnumerable<Note> GetAllNotes();
        void SaveNote(Note noteModel);
        void EditNote(Note noteModel);
        void DeleteNote(Note noteModel);

    }
}
