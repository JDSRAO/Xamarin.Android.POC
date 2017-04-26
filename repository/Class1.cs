using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net;

namespace repository
{
    public class Class1 : SQLiteConnection
    {
        SQLiteConnection db;
        string path = "";

        public Class1(string path) : base(path)
        {

        }
    }
}
