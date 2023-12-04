using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mclarba.Servicios
{
    internal class MenuImpl : MenuItfz
    {
        public int mostrarMenu (){
            int opcion;

            do {         
            Console.WriteLine("\n\t\t\t 0 ---> Salir");
            Console.WriteLine("\t\t\t 1 ---> Añadir vajilla nueva");
            Console.WriteLine("\t\t\t 2 ---> Reducir vajilla");
            Console.Write("\n\t\t\t Seleccione una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion < 0 || opcion > 2)
                    Console.WriteLine("\n\t\t\t La opcion escrita no existe.");

            }while(opcion < 0 || opcion > 2);
            return opcion;
        }
    }
}
