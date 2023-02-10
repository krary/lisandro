namespace EXPRESINES_LAMBDAS_Y_PREDICADOS
{
    internal class Program
    {
        delegate void d();
        static void Main(string[] args)
        {
            d dd = new d(MensajeBienvenida.SaludosBienvendia);
            dd();
        }
    }
    class MensajeBienvenida
    {
        public static void SaludosBienvendia()
        {
            Console.WriteLine("Bienvendios");
        }
    }

    class MensajeDespedida
    {
        public static void SaludosDespedida()
        {
            Console.WriteLine("Os marchamos");
        }
    }
}