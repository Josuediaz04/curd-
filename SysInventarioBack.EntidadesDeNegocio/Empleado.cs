using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysInventarioBack.EntidadesDeNegocio
{
    public class Empleado
    {
        
        public int IdEmpleado { get; set; }

        [Required]
        [StringLength(10)]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
    }
}
