using SysInventarioBack.EntidadesDeNegocio;

namespace SysInventarioBack.AccesoADatos
{
    public class CategoriaDAL
    {
        public int AgregarCategoria(List<Categoria> ListaCategoria, Categoria pCategoria)
        {
            ListaCategoria.Add(pCategoria);
            return 1;
        }

        public List<Categoria> MostrarCategorias(List<Categoria> ListaCategoria)
        {
            return ListaCategoria;
        }

        public int ModificarCategoria(List<Categoria> ListaCategorias, int id,Categoria pCategoria)
        {
            if(id != 0)
            {
                Categoria CategoriaBuscada = ListaCategorias.Where(c => c.IdCategoria== id).FirstOrDefault();
                if (CategoriaBuscada != null)
                {
                    CategoriaBuscada.IdCategoria = pCategoria.IdCategoria;
                    CategoriaBuscada.Nombre = pCategoria.Nombre;
                    CategoriaBuscada.Descripcion = pCategoria.Descripcion;  
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

        public int EliminarCategoria(List<Categoria>ListaCategorias, int id)
        {
            if (id != 0)
            {
                Categoria CategoriaBuscada = ListaCategorias.Where(c => c.IdCategoria == id).FirstOrDefault();
                if (CategoriaBuscada != null)
                {
                    ListaCategorias.Remove(CategoriaBuscada);
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
