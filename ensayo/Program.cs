namespace ensayo
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int l = 0;
            Console.WriteLine("Escribe que indice va ha tener tu lista");
            l = int.Parse(Console.ReadLine());
            int[] numero= new int[l];
            int b = 0;
            for(var i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Escribe un numero");
                b = int.Parse(Console.ReadLine());
                numero[i] = b;
               

            }
            for (var i = 0; i < numero.Length; i++)

            {
                Console.WriteLine("su LISTA es");
                Console.WriteLine(numero[i]);
            }
            
        }

    }
}