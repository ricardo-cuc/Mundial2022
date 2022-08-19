using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Models
{
    public partial class ApuestasUsuario
    {
        public string NroApuetas { get; set; }
        public int NroPartido { get; set; }
        public string UCodigo { get; set; }
        public int? ATipoResultado { get; set; }
        public int? AResultadoE1 { get; set; }
        public int? AResultadoE2 { get; set; }
        public int? APuntosCanjeados { get; set; }

        public virtual Partido NroPartidoNavigation { get; set; }
        public virtual Usuario UCodigoNavigation { get; set; }
    }
}
