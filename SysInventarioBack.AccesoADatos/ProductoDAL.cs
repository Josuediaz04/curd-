using SysInventarioBack.EntidadesDeNegocio;

namespace SysInventarioBack.AccesoADatos
{
    public class ProductoDAL
    {
        public int AgregarProductos(List<Producto> ListaProductos,Producto pProducto)
        {
            ListaProductos.Add(pProducto);
            return 1;
        }

        public List<Producto> MostrarProductos(List<Producto> ListaProductos) 
        {
            return ListaProductos;
        }

        public int ModificarProducto(List<Producto> ListaProductos, int id, Producto pProducto)
        {
            if (id != 0)
            {
                Producto ProductoBuscado = ListaProductos.Where(c => c.IdProducto == id).FirstOrDefault();
                if (ProductoBuscado != null)
                {
                    ProductoBuscado.IdProducto = pProducto.IdProducto;
                    ProductoBuscado.Nombre = pProducto.Nombre;
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public int EliminarProducto(List<Producto> ListaProductos, int id)
        {
            if (id != 0)
            {
                Producto ProductoBuscado = ListaProductos.Where(c => c.IdProducto == id).FirstOrDefault();
                if (ProductoBuscado != null)
                {
                    ListaProductos.Remove(ProductoBuscado);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

    }


}
