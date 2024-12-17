using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    [SQLite.Table("Posts")]
    class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [SQLite.Column("quest"), Indexed, NotNull]
        public Quest? Quest { get; set; }

        private User? Owner { get; set; }

        public int? Rating { get; set; }
    }
}
