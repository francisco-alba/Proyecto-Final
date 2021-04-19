using System;
using System.Data.SqlClient;

namespace cli
{
    class Program
    {
        private readonly static string connectionString = "Data Source=****;Initial Catalog=****;User ID=****;Password=****;";
        static void Main(string[] args)
        {
            // Insertar();
            // Eliminar();
             Mostrar();
        }
        static void Insertar()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Empleados] ([Id],[Nombre],[Edad]) VALUES (NEWID(),'Pepe Pepe',15);", con);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Insertado");

            con.Close();
        }
        static void Eliminar()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM [Empleados] WHERE [Id] = 'e0267f65-b7e5-4942-9125-ace950f1363';", con);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Eliminado");

            con.Close();
        }
        static void Mostrar()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT [Id], [Nombre], [Edad] FROM [Empleados];", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Id: " + dr["Id"]);
                Console.WriteLine("Nombre: " + dr["Nombre"]);
                Console.WriteLine("Edad: " + dr["Edad"]);
            }

            con.Close();
        }
    }
}
