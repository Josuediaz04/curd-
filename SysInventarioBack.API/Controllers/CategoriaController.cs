using Microsoft.AspNetCore.Mvc;
using SysInventarioBack.EntidadesDeNegocio;
using SysInventarioBack.LogicaDeNegocio;

namespace SysInventarioBack.API.Controllers
{
    public class CategoriaController : Controller
    {
        // CATEGORIAS

        public CategoriaBL objCategoriaBL = new CategoriaBL();
        public static List<Categoria> ListaCategorias = new List<Categoria>();
        [HttpPost("AgregarCategoria")]

        public ActionResult<int> AgregarCategoria(Categoria pCategoria)
        {
            if (ModelState.IsValid)
            {
                return objCategoriaBL.AgregarCategoria(ListaCategorias, pCategoria);
            }else
            {
                return 409;
            }
            
        }

        [HttpGet("MostrarCategoria")]

        public ActionResult<List<Categoria>> MostrarCategoria()
        {
            return objCategoriaBL.MostrarCategorias(ListaCategorias);
        }

        [HttpPut("ModificarCategoria")]

        public ActionResult<int> ModificarCategoria(int id, Categoria pCategoria) 
        {
            if (ModelState.IsValid)
            {
                return objCategoriaBL.ModificarCategoria(ListaCategorias, id, pCategoria);
            }
            else
            {
                return 409;
            }
            
        }

        [HttpDelete("EliminarCategoria")]

        public ActionResult<int> EliminarCategoria(int id)
        {
            return objCategoriaBL.EliminarCategoria(ListaCategorias, id);
        }
    }

}
