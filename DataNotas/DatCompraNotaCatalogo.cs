using DataNotas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNotas
{
    public class DatCompraNotaCatalogo
    {
        public void Agregar(CompraNotasCatalogos cc)
        {
            using(ExamenEntities db = new ExamenEntities()) 
            {
                db.CompraNotasCatalogos.Add(cc);
                db.SaveChanges();
            }
        }

        public List<CompraNotasCatalogos> ObtenerComprasPorNota(int id) // id de la nota
        {
            List<CompraNotasCatalogos> lsCC = new List<CompraNotasCatalogos>();

            using (ExamenEntities db = new ExamenEntities())
            {
                lsCC = db.CompraNotasCatalogos.Include("Catalogos").Include("Notas")
                    .Where(x=> x.idNotas == id).ToList();
            }

            return lsCC;
        }

        public List<CompraNotasCatalogos> ObtenerTodos()
        {
            List<CompraNotasCatalogos> lsCC = new List<CompraNotasCatalogos>();

            using (ExamenEntities db = new ExamenEntities()) 
            {
              lsCC =  db.CompraNotasCatalogos.Include("Catalogos").Include("Notas").ToList();
            }

            return lsCC;
        }

        public CompraNotasCatalogos ObtenerPorID(int id)
        {
            CompraNotasCatalogos cc = new CompraNotasCatalogos();

            using (ExamenEntities db = new ExamenEntities()) 
            {
                cc = db.CompraNotasCatalogos.Where(x=> x.id == id).Include("Catalogos").Include("Notas").FirstOrDefault();
            }

            return cc;
        }

        public void Editar(CompraNotasCatalogos cc)
        {
       

            using (ExamenEntities db = new ExamenEntities()) 
            {

                db.CompraNotasCatalogos.AddOrUpdate(cc);
                db.SaveChanges();
            }

        }

        public CompraNotasCatalogos ObtenerPorIDProducto(int idCatalogo, int idNotas)
        {
            CompraNotasCatalogos cc = new CompraNotasCatalogos();

            using (ExamenEntities db = new ExamenEntities())
            {
                cc = db.CompraNotasCatalogos.Include("Notas").Include("Catalogos")
                    .Where(x=> x.idCatalogos == idCatalogo && x.idNotas == idNotas).FirstOrDefault();
            }

            return cc;
        }



    }
}
