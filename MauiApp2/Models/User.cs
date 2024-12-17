using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    [SQLite.Table("Users")]
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [SQLite.Column("username"), Indexed, NotNull]
        public string? Username { get; set; }

        private string? Password { get; set; }

        public string? Status { get; set; }

        public int? Points { get; set; }

        public bool? ActiveUser { get; set; }
    }
}
