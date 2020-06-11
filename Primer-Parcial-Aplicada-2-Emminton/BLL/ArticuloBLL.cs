using Primer_Parcial_Aplicada_2_Emminton.DaL;
using Primer_Parcial_Aplicada_2_Emminton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Primer_Parcial_Aplicada_2_Emminton.BLL
{
    public class ArticuloBLL
    {
        public static bool Guardar(Articulo articulo)
        {
            if (Existe(articulo.ArticuloId))
                return Insertar(articulo);
            else
                return Modificar(articulo);
        }

        private static bool Insertar(Articulo articulo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Articulos.Add(articulo);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static Articulo Buscar(int id)
        {
            Articulo articulo = new Articulo();
            Contexto db = new Contexto();

            try
            {
                articulo = db.Articulos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return articulo;
        }
        private static bool Modificar(Articulo articulo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(articulo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var  eliminar = ArticuloBLL.Buscar(id);
                db.Articulos.Remove(eliminar);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> criterio)
        {
            List<Articulo> Lista = new List<Articulo>();
            Contexto db = new Contexto();

            try
            {

                Lista = db.Articulos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

        public static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = db.Articulos.Any(e => e.ArticuloId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;
        }
    }
}
