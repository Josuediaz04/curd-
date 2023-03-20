using SysInventarioBack.EntidadesDeNegocio;

namespace SysInventarioBack.AccesoADatos
{
    public class EmpleadoDAL
    {
        public List<Empleado> MostrarEmpleado(List<Empleado> ListaEmpleado)
        {
            return ListaEmpleado;
        }

        public int AgregarEmpleado(List<Empleado> ListaEmpleado, Empleado pEmpleado)
        {
            ListaEmpleado.Add(pEmpleado);
            return 1;
        }

        public int ModificarEmpleado(List<Empleado> ListaEmpledo, int id, Empleado pEmpleado)
        {
            if (id != 0)
            {
                Empleado EmpleadoBuscado = ListaEmpledo.Where(e=>e.IdEmpleado== id).FirstOrDefault();

                if (EmpleadoBuscado != null)
                {
                    EmpleadoBuscado.IdEmpleado = pEmpleado.IdEmpleado;
                    EmpleadoBuscado.Nombre = pEmpleado.Nombre;
                    EmpleadoBuscado.Direccion = pEmpleado.Direccion;
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

        public int EliminarEmpleado(List<Empleado>ListaEmpleado, int id)
        {
            if (id != 0)
            {
                Empleado EmpleadoBuscado = ListaEmpleado.Where(e => e.IdEmpleado == id).FirstOrDefault();
                if (EmpleadoBuscado != null)
                {
                    ListaEmpleado.Remove(EmpleadoBuscado);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }return 0;
        }


    }

    
}




