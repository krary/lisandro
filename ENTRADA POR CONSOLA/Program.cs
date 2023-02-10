
namespace ENTRADA_POR_CONSOLA
{
    class Program
    {
       
        
          
        

        static void Main(string[]args)
        {
            Console.WriteLine("hola ");
            int numero=int.Parse(Console.ReadLine());
            Console.WriteLine("Introudce el segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"El Resultado es{""}{ numero + num2}");

            //constante
            const int AA = 232;
            Console.WriteLine("El valor de la constante es{0}",AA);
        
        
        }
    }
}