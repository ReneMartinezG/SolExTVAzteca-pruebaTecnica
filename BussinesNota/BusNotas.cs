using DataNotas;
using DataNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesNota
{
    public class BusNotas
    {
        DatNotas datNota = new DatNotas();
        DatCompraNotaCatalogo datCompraNota = new DatCompraNotaCatalogo();
        DatCatalogos datCatalogo = new DatCatalogos();


        public List<Notas> ObtenerTodos()
        {
            return datNota.ObtenerTodos();
        }

        public Notas ObtenerPorID(int id)
        {
            return datNota.ObtenerPorID(id);
        }

        public void Agregar()
        {
            Notas n = new Notas()
            {
                Total = 0,
                FechaCompra = DateTime.Now,
            };

            datNota.Agregar(n);
       
        }

        public void AgregarCompraNotasCatalogo(CompraNotasCatalogos cc) 
        {

            datCompraNota.Agregar(cc);
            
        }

        public List<CompraNotasCatalogos> ObtenerCCPorNota(int id)
        {
            return datCompraNota.ObtenerComprasPorNota(id);
        }

        public void AgregarCC(CompraNotasCatalogos cc)
        {
            

            CompraNotasCatalogos ccRepetido = new CompraNotasCatalogos();
            Catalogos c = new Catalogos();
            Notas n = new Notas();

            c = datCatalogo.BuscarPorID(cc.idCatalogos);
            ccRepetido = datCompraNota.ObtenerPorIDProducto(cc.idCatalogos,cc.idNotas);
            n = datNota.ObtenerPorID(cc.idNotas);

            n.Total += cc.PrecioUnitario = c.precio;

            if (ccRepetido == null)
            {
                cc.Cantidad = 1;
                datCompraNota.Agregar(cc);

            }
            else
            {
                ccRepetido.Cantidad = ccRepetido.Cantidad + 1;
                datCompraNota.Editar(ccRepetido);

            }


            datNota.Editar(n);
        }

    }
}
