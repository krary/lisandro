namespace COLECCIONES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(32);
            lista.Add(34);
            lista.Add(3434);
            foreach(int i in lista){
                Console.WriteLine(i);
            }
            LinkedList<int> numeros = new LinkedList<int>();
            foreach(int i in new int[] { 23, 323, 232, 3 })
            {
                numeros.AddFirst(i);

            }
            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}