using System;
using System.Collections.Generic;

namespace Api.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }
}
