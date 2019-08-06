using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class TipoEvento
    {
        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }

        public TipoEvento()
        {
            this.Init();
        }

        private void Init()
        {
            IdTipoEvento = 0;
            Descripcion = string.Empty;
        }

        public bool Read()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.TipoEvento tipo = bbdd.TipoEvento.First(te => te.IdTipoEvento == IdTipoEvento);
                CommonBC.Syncronize(tipo, this);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TipoEvento> ReadAll()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.TipoEvento> listaDatos = bbdd.TipoEvento.ToList<datos.TipoEvento>();
                List<TipoEvento> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<TipoEvento>();
            }
        }

        private List<TipoEvento> GenerarListado(List<datos.TipoEvento> listaDatos)
        {
            List<TipoEvento> listaNegocio = new List<TipoEvento>();
            foreach (datos.TipoEvento datos in listaDatos)
            {
                TipoEvento negocio = new TipoEvento();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }

    }
}
