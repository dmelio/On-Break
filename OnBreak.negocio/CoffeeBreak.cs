using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class CoffeeBreak
    {
        public string Numero { get; set; }
        public bool Vegetariana { get; set; }
        public int idModalidad { get; set; }
        public int CantidadPersonal { get; set; }
        public int Asistentes { get; set; }
        public string valortotal { get; set; }

        public CoffeeBreak()
        {
            this.Init();
        }

        private void Init()
        {
            Numero = string.Empty;
            Vegetariana = false;
            idModalidad = 0;
            CantidadPersonal = 0;
            Asistentes = 0;
            valortotal = string.Empty;
        }

        public bool Create()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            datos.CoffeeBreak cb = new datos.CoffeeBreak();
            try
            {
                CommonBC.Syncronize(this, cb);
                bbdd.CoffeeBreak.Add(cb);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                bbdd.CoffeeBreak.Remove(cb);
                return false;
            }
        }
        public bool Delete()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.CoffeeBreak cb = bbdd.CoffeeBreak.First(c => c.Numero == Numero);
                bbdd.CoffeeBreak.Remove(cb);
                bbdd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Update()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.CoffeeBreak cb = bbdd.CoffeeBreak.First(c => c.Numero == Numero);
                CommonBC.Syncronize(this, cb);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Read()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.CoffeeBreak cb = bbdd.CoffeeBreak.First(c => c.Numero == Numero);
                CommonBC.Syncronize(cb, this);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private List<CoffeeBreak> GenerarListado(List<datos.CoffeeBreak> listaDatos)
        {
            List<CoffeeBreak> listaNegocio = new List<CoffeeBreak>();
            foreach (datos.CoffeeBreak datos in listaDatos)
            {
                CoffeeBreak negocio = new CoffeeBreak();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);

            }
            return listaNegocio;
        }

    }
}
