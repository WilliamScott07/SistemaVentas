using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
namespace CapaNegocio
{
    public class N_Categoria
    {

        public static string Insertar(string nombre,string descripcion)
        {
            D_Categoria categoria = new D_Categoria();
            categoria.Nombre = nombre;
            categoria.Descripcion = descripcion;
            return categoria.Insertar(categoria);
        }
    }
}
