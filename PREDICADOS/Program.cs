namespace PREDICADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numero = new List<int>();
            numero.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Predicate<int> delegado = new Predicate<int>(DamePares);
            List<int> numerospares = numero.FindAll(delegado);
              foreach(int i in numerospares){
                Console.WriteLine(i);
            }
        }
        static bool DamePares(int numero)
        {


            if (numero % 2 == 0) return true;
            else return false;
            
        }
    }
}