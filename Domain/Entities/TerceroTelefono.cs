using System;

namespace Inventario.Domain.Entities;

public enum TipoTelefono 
{
    Fijo = 0,
    Movil = 1
}
public class TerceroTelefono
{
    public int Id { get; set; }
    public string? numero { get; set; }
    public string? Tercero_Id { get; set; }
    public TipoTelefono Tipo_telefono { get; set; }
}