using DataNotas;
using DataNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesNota
{
    public class BusCatalogos
    {
        DatCatalogos datCatalogo = new DatCatalogos();

        public void agregar(Catalogos c)
        {
            datCatalogo.Agregar(c);
        }

        public void Editar (Catalogos c)
        {
            datCatalogo.Editar(c);
        }

        public Catalogos BuscarPorID(int id)
        {
            return datCatalogo.BuscarPorID(id);
        }

        public List<Catalogos> ObtenerTodos()
        {
            return datCatalogo.ObtenerTodos();
        }

    }
}
