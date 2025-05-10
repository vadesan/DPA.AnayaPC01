using System;
using System.Collections.Generic;

namespace DPA.AnayaPC01.DOMAIN.Core.Entities;

public partial class Canchas
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public string? Ubicacion { get; set; }

    public virtual ICollection<Reservas> Reservas { get; set; } = new List<Reservas>();
}
