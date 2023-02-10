namespace Lanzamiento_de_Excepsiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INC NUMBER");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(Mes(numero));
        }
        public static string Mes(int numero)
        {
             
            switch (numero)
            {
                case 1: return "Enero";
                    break;
                case 2:
                return "Febrero";
                    break;
                case 3:
                    return "Marzo";
                    break;
                case 4:
                    return "Abril";
                    break;
                case 5:
                    return "Mayo";
                    break;
                case 6:
                    return "Junio";
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }
        }
    }
}