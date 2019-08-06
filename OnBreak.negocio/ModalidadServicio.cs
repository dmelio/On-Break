using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class ModalidadServicio
    {
        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public string Nombre { get; set; }
        public double ValorBase { get; set; }
        public int PersonalBase { get; set; }

        public ModalidadServicio()
        {
            this.Init();
        }

        private void Init()
        {
            IdModalidad = string.Empty;
            IdTipoEvento = 0;
            Nombre = string.Empty;
            ValorBase = 0;
            PersonalBase = 0;
        }

        public bool Read()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.ModalidadServicio mod = bbdd.ModalidadServicio.First(mo => mo.IdModalidad == IdModalidad);
                CommonBC.Syncronize(mod, this);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<ModalidadServicio> ReadAll()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.ModalidadServicio> listaDatos = bbdd.ModalidadServicio.ToList<datos.ModalidadServicio>();
                List<ModalidadServicio> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<ModalidadServicio>();
            }
        }

        private List<ModalidadServicio> GenerarListado(List<datos.ModalidadServicio> listaDatos)
        {
            List<ModalidadServicio> listaNegocio = new List<ModalidadServicio>();
            foreach (datos.ModalidadServicio datos in listaDatos)
            {
                ModalidadServicio negocio = new ModalidadServicio();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }
       
        public List<ModalidadServicio> ReadbyTipo(int IdTipoEvento)
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.ModalidadServicio> listaDatos = bbdd.ModalidadServicio.Where(te => te.IdTipoEvento == IdTipoEvento).ToList<datos.ModalidadServicio>();
                List<ModalidadServicio> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }catch(Exception ex)
            {
                return new List<ModalidadServicio>();
            }
        }
    }
}
