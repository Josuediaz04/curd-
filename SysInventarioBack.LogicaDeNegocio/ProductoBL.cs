using SysInventarioBack.EntidadesDeNegocio;
using SysInventarioBack.AccesoADatos;

namespace SysInventarioBack.LogicaDeNegocio
{
    public class ProductoBL
    {
        public ProductoDAL objProductoDAL = new ProductoDAL();

        public int AgregarProductos(List<Producto> ListaProductos,Producto pProducto)
        {
            return objProductoDAL.AgregarProductos(ListaProductos, pProducto);
        }

        public List<Producto> MostrarProducto(List<Producto> ListaProductos)
        {
            return objProductoDAL.MostrarProductos(ListaProductos);
        }

        public int ModificarProducto(List<Producto> ListaProductos, int id, Producto pProducto)
        {
            return objProductoDAL.ModificarProducto(ListaProductos,id,pProducto);
        }

        public int EliminarProducto(List<Producto> ListaProductos, int id)
        {
            return objProductoDAL.EliminarProducto(ListaProductos, id);
        }
    }
}
