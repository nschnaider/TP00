using System.Data.SqlClient;
using Dapper;
using Newtonsoft.Json;
public class Integrante{
    [JsonProperty]
    public string Nombre {get; set;}
    [JsonProperty]
    public string Password {get; set;}
    [JsonProperty]
    public string Edad {get; set;}
    [JsonProperty]
    public DateTime Fecha {get; set;}
    [JsonProperty]
    public string Tiempo {get; set;}
    [JsonProperty]
    public string Direccion {get; set;}
    [JsonProperty]
    public string Telefono {get; set;}
    public Integrante(string nombre, string password, string edad, DateTime fecha, string tiempo, string direccion, string telefono){
        this.Nombre = nombre;
        this.Password = password;
        this.Edad = edad;
        this.Fecha = fecha;
        this.Tiempo = tiempo;
        this.Direccion = direccion;
        this.Telefono = telefono;
    }
        
    
}