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
    public Integrante(){
       
    }
        
    
}