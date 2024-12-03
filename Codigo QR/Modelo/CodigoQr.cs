using System;
using System.Collections.Generic;

namespace Codigo_QR.Modelo;

public partial class CodigoQr
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public byte[]? Imagen { get; set; }
}
