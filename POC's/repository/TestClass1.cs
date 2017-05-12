namespace repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using repository.Models;
    using SQLite;

    public class TestClass1 : SQLiteConnection
    {
        static object syncObj = new object();

        public TestClass1(string path) : base(path)
        {

        }

        public List<Zones> GetZones()
        {
            lock (syncObj)
            {
                try
                {
                    var cmd = NewCommand();
                    cmd.CommandText = "SELECT ID,Name FROM Zone";
                    List<Zones> result = cmd.ExecuteQuery<Zones>();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
