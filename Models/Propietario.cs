using System.Text.Json.Serialization;
using Taller.Models;

public class Propietario
{   
    
    public int Id { get; set; }

    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string NumeroDeIdentificacion { get; set; }
    
    
    public required string FotoDePerfil { get; set; }
    public required string Direccion { get; set; }

    
    public required string Telefono { get; set; }

    
    public required string Correo { get; set; }
        

    [JsonIgnore]
    public virtual ICollection <Vehiculos>? Vehiculos { get; set; }
}
