using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class ActividadEmpresa
    {
        public int IdActividadEmpresa { get; set; }
        public string Descripcion { get; set; }

        public ActividadEmpresa()
        {
            this.Init();
        }

        private void Init()
        {
            IdActividadEmpresa = 0;
            Descripcion = string.Empty;
        }
        public bool Read()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.ActividadEmpresa tipoAct = bbdd.ActividadEmpresa.First(ta => ta.IdActividadEmpresa == IdActividadEmpresa);
                CommonBC.Syncronize(tipoAct, this);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<ActividadEmpresa> ReadAll()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.ActividadEmpresa> listaDatos = bbdd.ActividadEmpresa.ToList<datos.ActividadEmpresa>();
                List<ActividadEmpresa> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch(Exception ex)
            {
                return new List<ActividadEmpresa>();
            }
        }

        private List<ActividadEmpresa> GenerarListado(List<datos.ActividadEmpresa>listaDatos)
        {
            List<ActividadEmpresa> listaNegocio = new List<ActividadEmpresa>();
            foreach(datos.ActividadEmpresa datos in listaDatos)
            {
                ActividadEmpresa negocio = new ActividadEmpresa();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }
    }
}
