namespace SOBRE_CARGA_DE_METOOS
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Boolean info;
            info = true;
            Console.WriteLine("Introduce la clve");
            String clave = Console.ReadLine();
            if (clave.Equals("casa")){
                info = false;
                Console.WriteLine(info);
            }
            if (info == false)
            {
                Console.WriteLine("Los siento pero la de claracion de la renta estas hecga");
            }


        }

        static void sumar(int a, int b)
        {
            Console.WriteLine($"El resultado de la suma es : {a + b}");
        }
        static void sumar(int a, double b)
        {
            Console.WriteLine($"El resultado de la suma es : {a + b}");
        }

    }
}