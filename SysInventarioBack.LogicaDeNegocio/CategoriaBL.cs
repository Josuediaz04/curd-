using SysInventarioBack.EntidadesDeNegocio;
using SysInventarioBack.AccesoADatos;

namespace SysInventarioBack.LogicaDeNegocio

{ 

    public class CategoriaBL
    {
        public CategoriaDAL objCategoriaDAL = new CategoriaDAL();
        public int AgregarCategoria(List<Categoria> ListaCategoria,Categoria pCategoria) 
        {
            return objCategoriaDAL.AgregarCategoria(ListaCategoria,pCategoria);
        }

        public List<Categoria> MostrarCategorias(List<Categoria> ListaCategoria) 
        {
            return objCategoriaDAL.MostrarCategorias(ListaCategoria);
        }

        public int ModificarCategoria(List<Categoria> ListaCategorias, int id, Categoria pCategoria)
        {
            return objCategoriaDAL.ModificarCategoria(ListaCategorias,id, pCategoria);
        }

        public int EliminarCategoria(List<Categoria>ListaCategorias, int id)
        {
            return objCategoriaDAL.EliminarCategoria(ListaCategorias, id);
        }
    }
}
