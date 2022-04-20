public record class recProductos
{
    public int idProducto { get; set; }
    public string Descripcion { get; set; }
    public string CodigoBarras { get; set; }

    public recProductos(int id, string descripcion, string codigoBarras)
    {
        this.idProducto = id;
        this.Descripcion = descripcion;
        this.CodigoBarras = codigoBarras;
    }
}

public record struct recImpuestos
{
    public decimal PorcentajeIva { get; set; }
    public decimal PorcentajeIeps { get; set; }
    public recImpuestos(decimal porIva, decimal porIeps)
    {
        PorcentajeIva = porIva;
        PorcentajeIeps = porIeps;
    }
}

public record struct recMontosImpuestos
{
    public decimal MontoIva { get; set; }
    public decimal MontoIeps { get; set; }

    public recMontosImpuestos(decimal montoIva, decimal montoIeps)
    {
        MontoIva = montoIva;
        MontoIeps = montoIeps;
    }
}