using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Models
{
    public partial class Team
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Country { get; set; }
        public int? Titles { get; set; }
        public string Value { get; set; }
    }
}
