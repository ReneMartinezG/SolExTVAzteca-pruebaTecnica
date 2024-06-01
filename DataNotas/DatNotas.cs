using DataNotas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataNotas
{
    public class DatNotas
    {

        public List<Notas> ObtenerTodos()
        {
            List<Notas> lsN = new List<Notas>();

            using (ExamenEntities db = new ExamenEntities())
            {
                lsN = db.Notas.ToList();
            }

            return lsN;
        }

        public void Agregar(Notas n)
        {
            using (ExamenEntities db = new ExamenEntities())
            {
                db.Notas.Add(n);
                db.SaveChanges();
            }
        }

        public void Editar(Notas n)
        {
            using (ExamenEntities db = new ExamenEntities())
            {
                
                db.Notas.AddOrUpdate(n);
                db.SaveChanges();
            }
        }

        public Notas ObtenerPorID(int id)
        {
            Notas n = new Notas();

            using (ExamenEntities db = new ExamenEntities())
            {
                n = db.Notas.Where(x=> x.id == id).FirstOrDefault();
            }

            return n;
        }

    }
}
