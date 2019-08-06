using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class Cliente
    {
        string _descripcionTipoe;
        string _descripcionTipoAct;
        public string RutCliente { get; set; }
        public string RazonSocial { get; set; }
        public string NombreContacto { get; set; }
        public string MailContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int IdActividadEmpresa { get; set; }
        public int IdTipoEmpresa { get; set; }

        public string DescripcionTipoe { get { return _descripcionTipoe; } }
        public string DescripcionTipoAct1 { get{ return _descripcionTipoAct; } }

        public Cliente()
        {
            this.Init();
        }

        private void Init()
        {
            RutCliente = string.Empty;
            RazonSocial = string.Empty;
            NombreContacto = string.Empty;
            MailContacto = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            IdActividadEmpresa = 0;
            IdTipoEmpresa = 0;
            _descripcionTipoe = string.Empty;
            _descripcionTipoAct = string.Empty;
        
        }

        public bool Create()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            datos.Cliente clie = new datos.Cliente();
            try
            {
                CommonBC.Syncronize(this,clie);
                bbdd.Cliente.Add(clie);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                bbdd.Cliente.Remove(clie);
                return false;
            }
        }

        private void LeerDescripcionTipoAct()
        {
            ActividadEmpresa act = new ActividadEmpresa() { IdActividadEmpresa = IdActividadEmpresa };
            if (act.Read())
            {
                _descripcionTipoAct = act.Descripcion;
            }
            else
            {
                _descripcionTipoAct = string.Empty;
            }
        }

        private void LeerDescripcionTipoe()
        {
            TipoEmpresa tipoe = new TipoEmpresa() { IdTipoEmpresa = IdTipoEmpresa };
            if (tipoe.Read())
            {
                _descripcionTipoe = tipoe.Descripcion;
            }
            else
            {
                _descripcionTipoe = string.Empty;
            }
        }

        public bool Delete()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.Cliente clie = bbdd.Cliente.First(c => c.RutCliente == RutCliente);
                bbdd.Cliente.Remove(clie);
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
                datos.Cliente clie = bbdd.Cliente.First(c => c.RutCliente == RutCliente);
                CommonBC.Syncronize(this,clie);
                bbdd.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        
        public bool Read()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                datos.Cliente clie = bbdd.Cliente.First(c => c.RutCliente == RutCliente);
                CommonBC.Syncronize(clie,this);
                LeerDescripcionTipoe();
                LeerDescripcionTipoAct();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<Cliente> ReadAll()
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();
            try
            {
                List<datos.Cliente> listaDatos = bbdd.Cliente.ToList<datos.Cliente>();
                List<Cliente> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch(Exception ex)
            {
                return new List<Cliente>();
            }
        }

        private List<Cliente> GenerarListado(List<datos.Cliente> listaDatos)
        {
            List<Cliente> listaNegocio = new List<Cliente>();
            foreach(datos.Cliente datos in listaDatos)
            {
                Cliente negocio = new Cliente();
                CommonBC.Syncronize(datos, negocio);
                negocio.LeerDescripcionTipoe();
                negocio.LeerDescripcionTipoAct();
                listaNegocio.Add(negocio);
                
            }
            return listaNegocio;
        }

        public List<Cliente> ReadByTipoEmp(int IdTipoEmpresa)
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();

            try
            {
                List<datos.Cliente> listaDatos = bbdd.Cliente.Where(c => c.IdTipoEmpresa == IdTipoEmpresa).ToList<datos.Cliente>();

                List<Cliente> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }
        public List<Cliente> ReadByAct(int IdActividadEmpresa)
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();

            try
            {
                List<datos.Cliente> listaDatos = bbdd.Cliente.Where(a => a.IdActividadEmpresa == IdActividadEmpresa).ToList<datos.Cliente>();

                List<Cliente> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }
        public List<Cliente> ReadByRut(string RuTCliente)
        {
            datos.Onbreak2Entities bbdd = new datos.Onbreak2Entities();

            try
            {
                List<datos.Cliente> listaDatos = bbdd.Cliente.Where(a => a.RutCliente == RuTCliente).ToList<datos.Cliente>();

                List<Cliente> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }
    }
}
