using System.Text.RegularExpressions;

namespace EXPRESIONES_REGULARES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String mensaje = "hola este es mi mensaje 232-323-33";
            String patron = "[J]";
            Regex rex = new Regex(patron);
            MatchCollection ll = rex.Matches(mensaje);
            if (ll.Count > 0) Console.WriteLine("SE ha encontrado una j");
                else Console.WriteLine("No se Ha encontrado la j");
            
        }
    }
}