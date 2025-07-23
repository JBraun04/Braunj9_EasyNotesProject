using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackBraun_EasyNotesProject
{
    public class LocalDBService
    {
        private const string DB_NAME = "demo_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDBService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<NoteData>();

        }

        public async Task<List<NoteData>> GetNoteData()
        {
            return await _connection.Table<NoteData>().ToListAsync();
        }
        public async Task<NoteData> GetById(int id)
        {
            return await _connection.Table<NoteData>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(NoteData notedata)
        {
            await _connection.InsertAsync(notedata);
        }

        public async Task Update(NoteData notedata)
        {
            await _connection.UpdateAsync(notedata);
        }

        public async Task Delete(NoteData notedata)
        {
            await _connection.DeleteAsync(notedata);
        }
    }
}
