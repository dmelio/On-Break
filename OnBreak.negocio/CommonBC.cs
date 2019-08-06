using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.negocio
{
    class CommonBC
    {
        internal static void Syncronize(object origen, object destino)
        {
            /* Auxiliares para Reflection del Tipo de Dato Origen */
            Type tipo = null;
            PropertyInfo[] propiedades = null;

            /* Obtiene información del Tipo Origen y sus Propiedades */
            tipo = origen.GetType();
            propiedades = tipo.GetProperties();

            /* Recorre las propiedades del Origen para asignar los valores al destino */
            foreach (PropertyInfo propiedad in propiedades)
            {
                try
                {
                    /* Recupera propiedad destino por su nombre */
                    PropertyInfo propInfo = destino.GetType().GetProperty(propiedad.Name);

                    /* Asigna valor destino desde el origen */
                    propInfo.SetValue(destino, propiedad.GetValue(origen, null));
                }
                catch {/* Los valores que no se pueden asignar son ignorados */}
            }
        }
    }
}
