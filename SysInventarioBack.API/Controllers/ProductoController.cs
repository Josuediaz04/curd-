using Microsoft.AspNetCore.Mvc;
using SysInventarioBack.EntidadesDeNegocio;
using SysInventarioBack.LogicaDeNegocio;

namespace SysInventarioBack.API.Controllers
{
    public class ProductoController : Controller
    {
        public ProductoBL objProductoBL = new ProductoBL();
        public static List<Producto> ListaProductos = new List<Producto>();
        [HttpPost("AgregarProducto")]

        public ActionResult<int> AgregarProductos(Producto pProducto)
        { 
           return objProductoBL.AgregarProductos(ListaProductos, pProducto);
        }

        [HttpGet("MostrarProductos")]
        public ActionResult<List<Producto>> MostrarProductos()
        {
            return objProductoBL.MostrarProducto(ListaProductos);
        }


        [HttpPut("ModificarProducto")]

        public ActionResult<int> ModificarProducto(int id, Producto pProducto)
        {
            return objProductoBL.ModificarProducto(ListaProductos, id, pProducto);
        }

        [HttpDelete("EliminarProducto")]

        public ActionResult<int> EliminarProducto(int id)
        {
            return objProductoBL.EliminarProducto(ListaProductos, id);  
        }
    }
}

