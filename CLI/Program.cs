using System;
using system.Data.SqlClient;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
         SqlConnection con = new SqlConnection("Data Source=unitec-db.database.windows.net;Initial Catalog=clases;User ID=loginAlumno;Password=Pa$$word;");
         con.open();

         Console.WriteLine("ok");
        }
    }
}
