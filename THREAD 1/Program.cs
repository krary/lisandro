namespace THREAD_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread hilo = new Thread(mensaje);
            Thread hilo1 = new Thread(mensaje);

            hilo.Start();
            hilo.Join();
            hilo1.Start();
            hilo1.Join();
            Console.WriteLine("HOLA A TODOS");
            Thread.Sleep(1000);
            Console.WriteLine("HOLA A TODOS");
            Thread.Sleep(1000);
            Console.WriteLine("HOLA A TODOS");
            Thread.Sleep(1000);
            Console.WriteLine("HOLA A TODOS");
            Thread.Sleep(1000);
            Console.WriteLine("HOLA A TODOS");

        }
        static void mensaje()
        {
            Console.WriteLine("ESTE ES EL HILO DE EL THREAD");
            Console.WriteLine("ESTE ES EL HILO DE EL THREAD");
            Console.WriteLine("ESTE ES EL HILO DE EL THREAD");
            Console.WriteLine("ESTE ES EL HILO DE EL THREAD");
        }
    }
}