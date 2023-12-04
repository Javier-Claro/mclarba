using mclarba.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mclarba.Servicios
{
    internal interface AnyadirVajillaItfz
    {
        /// <summary>
        /// Método añade el nuevo objeto a la lista
        /// 041223 - jcb
        /// </summary>
        /// <returns>El nuevo cliente</returns>
        public void nuevaVajilla (List<Vajilla> nueva);

        /// <summary>
        /// Método que le da los valores a un nuevo objeto de la lista
        /// 041223 - jcb
        /// </summary>
        /// <returns>El nuevo cliente</returns>
        public Vajilla anyadirNuevaVajilla();
    }
}
