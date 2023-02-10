namespace SWITCH_EN_CONSOLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTRODUCE SU MEDIO DE TRANSPORTE");
            Console.WriteLine("EN LETRAS MAY");
            String tren = Console.ReadLine();
            switch (tren)
            {
                case "TREN": 
                        Console.WriteLine("Su medio de transporte es medio-seguro");
                        break; 
                    
                case "AVION": 
                        Console.WriteLine("Su medio de transporte es el mas seguro");
                        break;

                case "CARRO":
                        Console.WriteLine("Su medio de tranporte es el Mas inseguro");
                        break;
                       default:
                            Console.WriteLine("transporte no contemplado");
                        break;
                    }

            
        }
    }
}