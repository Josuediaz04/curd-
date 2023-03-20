using SysInventarioBack.EntidadesDeNegocio;
using SysInventarioBack.AccesoADatos;

using SysInventarioBack.AccesoADatos;

namespace SysInventarioBack.LogicaDeNegocio
{
    public class EmpleadoBL
    {
        public EmpleadoDAL objEmpleadoDAL = new EmpleadoDAL();

        public int AgregarEmpleado(List<Empleado> ListaEmpleado, Empleado pEmpleado)
        {
            return objEmpleadoDAL.AgregarEmpleado(ListaEmpleado, pEmpleado);
        }

        public List<Empleado> MostrarEmpleado(List<Empleado> ListaEmpleado)
        {
            return objEmpleadoDAL.MostrarEmpleado(ListaEmpleado);
        }

        public int ModificarEmpleado(List<Empleado> ListaEmpleado, int id, Empleado pEmpleado)
        {
            return objEmpleadoDAL.ModificarEmpleado(ListaEmpleado, id, pEmpleado);
        }

        public int EliminarCategoria(List<Empleado> ListaEmpleado,int id)
        {
            return objEmpleadoDAL.EliminarEmpleado(ListaEmpleado, id);
        }
    }
}
