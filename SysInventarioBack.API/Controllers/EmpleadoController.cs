using Microsoft.AspNetCore.Mvc;
using SysInventarioBack.EntidadesDeNegocio;
using SysInventarioBack.LogicaDeNegocio;

namespace SysInventarioBack.API.Controllers
{
    public class EmpleadoController : Controller
    {
        public EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        public static List<Empleado> ListaEmpleado = new List<Empleado>();

        [HttpPost("AgregarEmpleado")]

        public ActionResult<int> AgregarEmpleado(Empleado pEmpleado)
        {
            if (ModelState.IsValid)
            {
                return objEmpleadoBL.AgregarEmpleado(ListaEmpleado, pEmpleado);
            }
            else
            {
                return 409;
            }
        }

        [HttpGet("MostrarEmpleado ")]
        public ActionResult<List<Empleado>> MostrarEmpleado()
        {
            return objEmpleadoBL.MostrarEmpleado(ListaEmpleado);
        }

        [HttpPut("ModificarEmpleado")]

        public ActionResult<int> ModificarEmpleado(int id, Empleado pEmpleado)
        {
            if (ModelState.IsValid)
            {
                return objEmpleadoBL.ModificarEmpleado(ListaEmpleado, id, pEmpleado);
            }
            else
            {
                return 409;
            }
        }

        [HttpDelete("EliminarEmpleado")]

        public ActionResult<int> EliminarEmpleado(int id)
        {
            return objEmpleadoBL.EliminarCategoria(ListaEmpleado,id);
        }
    }
}
