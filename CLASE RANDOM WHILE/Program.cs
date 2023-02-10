namespace CLASE_RANDOM_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Random numeroAL = new Random();
            int AL = numeroAL.Next(0,100);
            int contador = 5;
            int clave = 0;
            while (AL!=clave)
            {
                Console.WriteLine(AL);
                contador --;
                Console.WriteLine("INTRODUCE EL NUMERO");

                try
                {
                    clave = int.Parse(Console.ReadLine());
                }catch (Exception w) when(w.GetType() !=typeof( System.OverflowException))
                {
                    Console.WriteLine("Porfavor introduce un numero no letra");
                    Console.WriteLine(w.Message);
                }catch (System.OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                if (AL > clave)
                {
                    Console.WriteLine("Pista el numero es mayor");
                    Console.WriteLine("Te van quedando : " + contador);
                }
                else if (AL > clave)
                {
                    Console.WriteLine("Pista el numero es menor");
                    Console.WriteLine("Te van quedando : " + contador);
                }
                else if (contador == 0) {
                    clave = AL;
                }


                            }
            Console.WriteLine("HAS ACERTADO EL NUMERO");
        
        
        }
    }
}