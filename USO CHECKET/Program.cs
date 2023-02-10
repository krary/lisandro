namespace USO_CHECKET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int numero = int.MaxValue;
                Console.WriteLine(numero);
                int numero1 = numero + 23;
                Console.WriteLine(numero1);
                 int j = 34;
                j = 3;
            }
        }
    }
}