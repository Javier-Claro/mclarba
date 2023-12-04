using mclarba.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mclarba.Servicios
{
    internal class AnyadirVajillaImpl : AnyadirVajillaItfz
    {
        List<Vajilla> cubierto = new List<Vajilla>();

        public void nuevaVajilla(List<Vajilla> nueva)
        {
            cubierto = new Vajilla();

            cubierto = anyadirNuevaVajilla();

            nueva.Add(cubierto);
        }

        public Vajilla anyadirNuevaVajilla()
        {
            Vajilla cubierto = new Vajilla();

            Console.Write("Indique el id del cubierto a añadir ");
            cubierto.idVajilla = Convert.ToInt64(Console.ReadLine());
            Console.Write("¿Que cubierto desea añadir? ");
            cubierto.codigoVajilla = Console.ReadLine();
            Console.Write("¿Que tipo de cubierto desea añadir? ");
            cubierto.tipoVajilla = Console.ReadLine();
            Console.Write("¿Que cantidad desea añadir? ");
            cubierto.cantidadVajilla = Convert.ToInt32(Console.ReadLine());

            cubierto.codigoVajilla = cubierto.idVajilla + cubierto.codigoVajilla;

            return cubierto;
        }
    }
}
