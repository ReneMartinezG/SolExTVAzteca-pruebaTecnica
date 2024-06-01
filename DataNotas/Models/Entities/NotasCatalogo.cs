using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNotas.Models.Entities
{
    public class NotasCatalogo
    {
        public Notas Notas { get; set; }

        public List<CompraNotasCatalogos> ListaCompraNotas { get; set; }


    }
}
