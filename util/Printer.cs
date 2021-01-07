using static System.Console;

namespace CoreEscuela.util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
          var linea = "".PadLeft(10, '=');
          WriteLine(linea);
        }
    }
}