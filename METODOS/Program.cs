namespace METODOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mensajeEnPantalla(4,5);
            Console.WriteLine(operacion(2, 3));

        }
       static void mensajeEnPantalla(int num1,int num2)
            
        {
            
                Console.WriteLine($"El resultado es de : {num1*num2}");
            Console.WriteLine("gik");
        }
        //setter
        //static int operacion(int x,int y)
        //{
        //  return x * y;
        //}
        static int operacion(int num1, int num2) => num1 * num2;
    }
}