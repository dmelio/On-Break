using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    public partial class Cocktail
    {
        public string Numero { get; set; }
        public int IdTipoAmbientacion { get; set; }
        public bool MusicaAmbiental { get; set; }
        public bool MusicaCliente { get; set; }
        public int idModalidad { get; set; }
        public int CantidadPersonal { get; set; }
        public int Asistentes { get; set; }
        public string valortotal { get; set; }


        public Cocktail()
        {
            this.Init();
        }

        private void Init()
        {
            Numero = string.Empty;
            IdTipoAmbientacion = 0; 
            MusicaAmbiental = false;
            MusicaCliente = false;
            idModalidad = 0;
            CantidadPersonal = 0;
            Asistentes = 0;
            valortotal =string.Empty;
        }


    }
}
