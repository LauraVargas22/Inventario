using System;

namespace Inventario.Domain.Entities;

public class DetalleVenta
{
    public int Id { get; set; }
    public int Factura_id { get; set; }
    public string? Producto_id { get; set; }
    public int Cantidad { get; set; }
    public decimal Valor { get; set; }
}