using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.Models;

public class Vehiculos
{   
    [Key]
    public int Id { get; set; }
    public required string Marca { get; set; }
    public required string Modelo { get; set; }
    public required int PropietarioId { get; set; }
    public required int Año { get; set; }
    public required string Color { get; set; }
    public required string TipoVehiculo { get; set; }

    [ForeignKey("PropietarioId")]
    public Propietario? Propietario { get; set; }

}
