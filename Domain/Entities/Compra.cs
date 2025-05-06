using System;

namespace Inventario.Domain.Entities;

public class Compra
{
    public int Id { get; set; }
    public string? TerceroProveedor_id { get; set; }
    public DateTime fecha { get; set; }
    public string? TerceroEmpleado_id { get; set; }
    public string? DocCompra { get; set; }
}