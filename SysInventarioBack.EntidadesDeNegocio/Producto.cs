

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysInventarioBack.EntidadesDeNegocio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        [Required]
        public int Codigo { get; set; }

        [Required]
        [StringLength(20)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(25)]
        public string? Descripcion { get; set; }

        [Required]
        [StringLength(4)]
        public string? Precio { get; set; }

        [Required]
        public DateTime FechaV { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [ForeignKey("IdCategoria")]
        public int IdCategoria { get; set; }


        public Categoria? Categoria { get; set; }

    }
}
