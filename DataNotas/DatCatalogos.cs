using DataNotas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNotas
{
    public class DatCatalogos
    {
        public void Agregar(Catalogos c)
        {
            using(ExamenEntities db = new ExamenEntities())
            {
                db.Catalogos.Add(c);
                db.SaveChanges();
            }
        }

        public void Editar(Catalogos c)
        {
            using(ExamenEntities db = new ExamenEntities())
            {
                db.Catalogos.AddOrUpdate(c);
                db.SaveChanges();
            }
        }

        public Catalogos BuscarPorID(int id)
        {
            Catalogos c = new Catalogos();

            using (ExamenEntities db = new ExamenEntities())
            {
                c = db.Catalogos.Where(x=> x.id == id).FirstOrDefault();
            }

            return c;
        }

        public List<Catalogos> ObtenerTodos()
        {
            List<Catalogos> lsC = new List<Catalogos>();
            using(ExamenEntities db = new ExamenEntities())
            {
                lsC = db.Catalogos.ToList();
            }

            return lsC;
        }


    }
}
