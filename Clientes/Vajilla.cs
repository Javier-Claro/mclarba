using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mclarba.Clientes
{
    /// <summary>
    /// Clase de la aplicacion que nos dará un nuevo tipo de cubierto object
    /// 041223 - jcb
    /// </summary>
    internal class Vajilla
    {
        // Los parámetros del object:
        public long idVajilla = 0;
        public string codigoVajilla = "aaaaa";
        public string nombreVajilla = "aaaaa";
        public string tipoVajilla = "aaaaa";
        public int cantidadVajilla = 0;
        
        //GETTERS & SETTERS:
        public long IdVajilla { get => idVajilla; set => idVajilla = value; }
        public string CodigoVajilla { get => codigoVajilla; set => codigoVajilla = value; }
        public string NombreVajilla { get => nombreVajilla; set => nombreVajilla = value; }
        public string TipoVajilla { get => tipoVajilla; set => tipoVajilla = value; }
        public int CantidadVajilla { get => cantidadVajilla; set => cantidadVajilla = value; }

        //CONSTRUCTOR:
        public Vajilla(long idVajilla, string codigoVajilla, string nombreVajilla, string tipoVajilla, int cantidadVajilla)
        {
            this.idVajilla = idVajilla;
            this.codigoVajilla = codigoVajilla;
            this.nombreVajilla = nombreVajilla;
            this.tipoVajilla = tipoVajilla;
            this.cantidadVajilla = cantidadVajilla;
        }

        public Vajilla()
        {
        }

        //Método de lectura de la lista:
        public String ToString()
        {
            String vajilla = idVajilla + " " + 
                codigoVajilla + " " + 
                nombreVajilla + " " + 
                tipoVajilla + " " + 
                cantidadVajilla; 

            return vajilla;
        }
    }
}
