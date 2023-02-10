namespace METODOS_STATICOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            miclase miclase1 = new miclase();
            
            //Console.WriteLine(miclase.numero());

            double cuadrado = Math.Sqrt(9);
            double potencia = Math.Pow(3, 4);
            Console.WriteLine(potencia);
            Console.WriteLine(cuadrado);
            //Creando class Anonima
            var mivariable = new { Nombre = "nombre", Edad = 32, Clave = false };
            Console.WriteLine(mivariable.Nombre);
        }
    }
    class miclase
    {
        private static int punto;
        public miclase()
        {
            punto = 34343;

        }
        public static int numero() => punto;
        

    }
}