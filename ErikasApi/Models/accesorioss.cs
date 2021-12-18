using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErikasApi.Models
{
    public class accesorioss
    {
        [Key]
        public int idAccesorio { get; set; }
        public string tipoAccesorio { get; set; }
        public string color { get; set; }
        public double Precio { get; set; }

    }
}
