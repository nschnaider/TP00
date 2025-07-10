using System.Data.SqlClient;
using Dapper;
using NewtonSoft.Json;
public class Integrante{
    [JsonProperty]
    public string Nombre {get; set;}
    [JsonProperty]
    public int Password {get; set;}
    [JsonProperty]
    public int Edad {get; set;}
    [JsonProperty]
    public DateTime Fecha {get; set;}
    [JsonProperty]
    public int Tiempo {get; set;}
    [JsonProperty]
    public string Direccion {get; set;}
    [JsonProperty]
    public int Telefono {get; set;}
}