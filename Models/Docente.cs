using System;
using System.Collections.Generic;

namespace ModeloAsistencia.Models
{
    public partial class Docente
    {
        public string IdEmpleado { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Celular { get; set; }
    }
}
