using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2
{
    public static class Constants
    {
        private const string DBFileName = "SQLiteDB.db3";

        public static string DatabasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
