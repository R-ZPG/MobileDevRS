using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    [SQLite.Table("Themes")]
    class Theme
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [SQLite.Column("name"), Indexed, NotNull]
        public string? Name { get; set; }
    }
}
