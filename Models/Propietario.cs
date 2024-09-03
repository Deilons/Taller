using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.Models;

public class Propietario
{   
    [Key]
    public int Id { get; set; }

    [MinLength(5, ErrorMessage = "El nombre debe tener al menos 5 caracteres")]
    [MaxLength(125, ErrorMessage = "El nombre debe tener como maximo 50 caracteres")]
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string NumeroDeIdentificacion { get; set; }
    
    [MinLength(5, ErrorMessage = "La foto de perfil debe tener al menos 5 caracteres")]
    [MaxLength(125, ErrorMessage = "La foto de perfil debe tener como maximo 50 caracteres")]
    [Url(ErrorMessage = "La foto de perfil no es valida")]
    public required string FotoDePerfil { get; set; }
    public required string Direccion { get; set; }

    [MinLength(5, ErrorMessage = "El telefono debe tener al menos 5 caracteres")]
    [MaxLength(125, ErrorMessage = "El telefono debe tener como maximo 50 caracteres")]
    [Phone(ErrorMessage = "El telefono no es valido")]
    public required string Telefono { get; set; }

    [EmailAddress(ErrorMessage = "El correo no es valido")]
    [MinLength(5, ErrorMessage = "El correo debe tener al menos 5 caracteres")]
    [MaxLength(125, ErrorMessage = "El correo debe tener como maximo 50 caracteres")]
    public required string Correo { get; set; }

}
