using mclarba.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mclarba.Servicios
{
    internal interface ModificarCantidadItfz
    {
        /// <summary>
        /// Método modifica la cantidad de cubiertos
        /// 041223 - jcb
        /// </summary>
        /// <returns>El nuevo cliente</returns>
        public void reducirVajilla(List<Vajilla> nueva);
    }
}
