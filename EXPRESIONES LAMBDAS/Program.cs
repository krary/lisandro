namespace EXPRESIONES_LAMBDAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            operaciones oo = new operaciones(Parametro=>Parametro*Parametro);
            Console.WriteLine(oo(32));
            List<int> list = new List<int> { 1,2,3,4,5};
            List<int> list1 = list.FindAll(i => i % 2 == 0);
            list1.ForEach(list1 => Console.WriteLine(list1));
        
        
        }
        /*public static int Cuadrado(int numero)
        {
            return numero * numero;
        }*/

        public delegate int operaciones(int i);

    }
}