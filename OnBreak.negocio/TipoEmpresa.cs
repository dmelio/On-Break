using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class TipoEmpresa
    {
        public int IdTipoEmpresa { get; set; }
        public string Descripcion { get; set; }


        public TipoEmpresa()
        {
            this.Init();
        }

        private void Init()
        {
            IdTipoEmpresa = 0;
            Descripcion = string.Empty;
        }

        public bool Read()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.TipoEmpresa tipoE = bbdd.TipoEmpresa.First(te => te.IdTipoEmpresa == IdTipoEmpresa);
                CommonBC.Syncronize(tipoE, this);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TipoEmpresa> ReadAll()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.TipoEmpresa> listaDatos = bbdd.TipoEmpresa.ToList<datos.TipoEmpresa>();
                List<TipoEmpresa> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<TipoEmpresa>();
            }
        }

        private List<TipoEmpresa> GenerarListado(List<datos.TipoEmpresa> listaDatos)
        {
            List<TipoEmpresa> listaNegocio = new List<TipoEmpresa>();
            foreach (datos.TipoEmpresa datos in listaDatos)
            {
                TipoEmpresa negocio = new TipoEmpresa();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }
    }
}
