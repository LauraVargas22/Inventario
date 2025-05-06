using System;

namespace Inventario.Domain.Entities;

public class MovimientoCaja
{
    public int Id { get; set; }
    public DateTime fecha { get; set; }
    public int TipoMovimiento_id { get; set; }
    public decimal valor { get; set; }
    public string? concepto { get; set; }
    public string? Tercero_Id { get; set; }
}