using mclarba.Clientes;
using mclarba.Servicios;

namespace mclarba.Controladores
{

    /// <summary>
    /// Clase Main de la aplicacion
    /// 041223 - jcb
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 041223 - jcb
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int opcion;
            List<Vajilla> list = new List<Vajilla>();
            AnyadirVajillaItfz nuevo = new AnyadirVajillaImpl();
            ModificarCantidadItfz mod = new ModificarCantidadImpl();
            MenuItfz men = new MenuImpl();

            do
            {
                opcion = men.mostrarMenu();

                switch (opcion)
                {
                    case 1:
                        nuevo.nuevaVajilla(list);
                        break;

                    case 2:
                        mod.reducirVajilla(list);
                        break;
                }
            } while (opcion != 0);
        }
    }
}