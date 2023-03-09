

namespace SysInventarioBack.EntidadesDeNegocio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Precio { get; set; }
        public DateTime FechaV { get; set; }
        public int Cantidad { get; set; }

        public Categoria? Categoria { get; set; }

    }
}
