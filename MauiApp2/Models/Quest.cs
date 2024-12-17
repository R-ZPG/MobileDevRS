using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    [SQLite.Table("Quests")]
    class Quest
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [SQLite.Column("content"), Indexed, NotNull]
        public string? Content { get; set; }

        public Theme? Theme1 { get; set; }

        public Theme? Theme2 { get; set; }
    }
}
