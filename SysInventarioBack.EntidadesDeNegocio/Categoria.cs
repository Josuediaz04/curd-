using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SysInventarioBack.EntidadesDeNegocio
   
{
    public class Categoria
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategoria { get; set; }

        [Required]
        [StringLength(10)]
        [MinLength(3)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(50)]
       
        public string? Descripcion { get; set; }

        [Required,StringLength(100)]
        public string? IMGURL { get; set; }
        public  virtual ICollection<Producto>? Productos { get; set; }


    }
}
