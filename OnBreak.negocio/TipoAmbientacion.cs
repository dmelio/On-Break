using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class TipoAmbientacion
    {
        public int IdTipoAmbientacion { get; set; }
        public string Descripcion { get; set; }

        public TipoAmbientacion()
        {
            this.Init();
        }

        private void Init()
        {
            IdTipoAmbientacion = 0;
            Descripcion = string.Empty;
        }

        public bool Read()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.TipoAmbientacion tipo = bbdd.TipoAmbientacion.First(te => te.IdTipoAmbientacion == IdTipoAmbientacion);
                CommonBC.Syncronize(tipo, this);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TipoAmbientacion> ReadAll()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.TipoAmbientacion> listaDatos = bbdd.TipoAmbientacion.ToList<datos.TipoAmbientacion>();
                List<TipoAmbientacion> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<TipoAmbientacion>();
            }
        }

        private List<TipoAmbientacion> GenerarListado(List<datos.TipoAmbientacion> listaDatos)
        {
            List<TipoAmbientacion> listaNegocio = new List<TipoAmbientacion>();
            foreach (datos.TipoAmbientacion datos in listaDatos)
            {
                TipoAmbientacion negocio = new TipoAmbientacion();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }
    }
}
