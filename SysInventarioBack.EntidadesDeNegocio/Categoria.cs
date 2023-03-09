

namespace SysInventarioBack.EntidadesDeNegocio
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? IMGURL { get; set; }
        public List<Producto>? Productos { get; set; }


    }
}
