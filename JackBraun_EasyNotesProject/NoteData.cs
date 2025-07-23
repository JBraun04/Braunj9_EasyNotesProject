using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackBraun_EasyNotesProject
{
    [Table("notes")]
    public class NoteData
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        [Column("note_title")]
        public string NoteTitle { get; set; }
        [Column("note_content")]
        public string NoteContent { get; set; }
    }
}
