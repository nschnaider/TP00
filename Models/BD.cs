using System.Data.SqlClient;
using Dapper;
public class BD
{
    private static string connectionString = @"Server=localhost; DataBase = TP00;Integrated Security = True;TrustServerCertificate=True;";

    public static Integrante Login(string nombre, string password)
    {
        string passwordEncriptada = Encriptador.Encriptar(password);
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Integrantes WHERE Nombre = @Nombre AND Password = @Password";
            return db.QueryFirstOrDefault<Integrante>(query, new { Nombre = nombre, Password = passwordEncriptada });
        }
    }

    public static void Registrar(Integrante nuevo)
    {
        nuevo.Password = Encriptador.Encriptar(nuevo.Password);
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            string insert = "INSERT INTO Integrantes (Nombre, Password, Edad, Fecha, Tiempo, Direccion, Telefono) " +
                            "VALUES (@Nombre, @Password, @Edad, @Fecha, @Tiempo, @Direccion, @Telefono)";
            db.Execute(insert, nuevo);
        }
    }
}
