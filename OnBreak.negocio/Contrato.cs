using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class Contrato
    {
        string _descripcionTipoEvento;
        string _descripcionModalidad;
        public string Numero { get; set; }
        public System.DateTime Creacion { get; set; }
        public System.DateTime Termino { get; set; }
        public string RutCliente { get; set; }
        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public System.DateTime FechaHoraInicio { get; set; }
        public System.DateTime FechaHoraTermino { get; set; }
        public int Asistentes { get; set; }
        public int PersonalAdicional { get; set; }
        public bool Realizado { get; set; }
        public double ValorTotalContrato { get; set; }
        public string Observaciones { get; set; }

        public string DescripcionTipoEvento { get { return _descripcionTipoEvento; } }
        public string DescripcionModalidad { get { return _descripcionModalidad; } }

        public Contrato()
        {
           this.Init();
        }

        private void Init()
        {
            Numero = string.Empty;
            Creacion = DateTime.Today;
            Termino = DateTime.Today;
            RutCliente = string.Empty;
            IdModalidad = string.Empty;
            IdTipoEvento = 0;
            FechaHoraInicio = DateTime.Today;
            FechaHoraTermino = DateTime.Today;
            Asistentes = 0;
            PersonalAdicional = 0;
            Realizado = false;
            ValorTotalContrato = 0;
            Observaciones = string.Empty;
            _descripcionModalidad = string.Empty;
            _descripcionTipoEvento = string.Empty;
        }
        
        public bool Read()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.Contrato cont = bbdd.Contrato.First(c => c.Numero == Numero);
                CommonBC.Syncronize(cont,this);
                leerDescripcionTipoEvento();
                leerDescripcionModalidad();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void leerDescripcionModalidad()
        {
            ModalidadServicio mod = new ModalidadServicio() { IdModalidad = IdModalidad };
            if (mod.Read())
            {
                _descripcionModalidad = mod.Nombre;
            }
            else
            {
                _descripcionModalidad = string.Empty;
            }
        }

        private void leerDescripcionTipoEvento()
        {
            TipoEvento tipo = new TipoEvento() { IdTipoEvento = IdTipoEvento };
            if (tipo.Read())
            {
                _descripcionTipoEvento = tipo.Descripcion;
            }
            else
            {
                _descripcionTipoEvento = string.Empty;
            }
        }

        public bool Create()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            datos.Contrato cont = new datos.Contrato();
            try
            {
                CommonBC.Syncronize(this,cont);
                bbdd.Contrato.Add(cont);
                bbdd.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                bbdd.Contrato.Remove(cont);
                return false;
            }
        }
        public bool Delete()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.Contrato cont = bbdd.Contrato.First(c => c.Numero == Numero);
                bbdd.Contrato.Remove(cont);
                bbdd.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }
        public bool Update()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.Contrato cont = bbdd.Contrato.First(c => c.Numero == Numero);
                CommonBC.Syncronize(this,cont);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Contrato> ReadAll()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.Contrato> listaDatos = bbdd.Contrato.ToList<datos.Contrato>();
                List<Contrato> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch
            {
                return new List<Contrato>();
            }
        }
        private List<Contrato> GenerarListado(List<datos.Contrato> listaDatos)
        {
            List<Contrato> listaNegocio = new List<Contrato>();
            foreach(datos.Contrato datos in listaDatos)
            {
                Contrato negocio = new Contrato();
                CommonBC.Syncronize(datos, negocio);
                negocio.leerDescripcionModalidad();
                negocio.leerDescripcionTipoEvento();
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }

       public List<Contrato> ReadByTipoEve(int IdTipoEvento)
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.Contrato> listaDatos = bbdd.Contrato.Where(c => c.IdTipoEvento == IdTipoEvento).ToList<datos.Contrato>();
                List<Contrato> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch(Exception ex)
            {
                return new List<Contrato>();
            }
        }

        public List<Contrato> ReadByMod(string IdModalidad)
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.Contrato> listaDatos = bbdd.Contrato.Where(c => c.IdModalidad == IdModalidad).ToList<datos.Contrato>();
                List<Contrato> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Contrato>();
            }
        }
        public List<Contrato> ReadByRutclie(string RutCliente)
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.Contrato> listaDatos = bbdd.Contrato.Where(c => c.RutCliente == RutCliente).ToList<datos.Contrato>();
                List<Contrato> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Contrato>();
            }
        }
        public List<Contrato> ReadByNumCont(string Numero)
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.Contrato> listaDatos = bbdd.Contrato.Where(c => c.Numero == Numero).ToList<datos.Contrato>();
                List<Contrato> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Contrato>();
            }
        }

    }
}
