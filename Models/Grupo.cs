using System;
using System.Collections.Generic;

namespace ModeloAsistencia.Models
{
    public partial class Grupo
    {
        public int Id { get; set; }
        public string IdDocente { get; set; } = null!;
        public string Horario { get; set; } = null!;
        public string Asistencia { get; set; } = null!;
        public string Comentarios { get; set; } = null!;
        public string? Grupo1 { get; set; }
    }
}
