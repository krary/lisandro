namespace Ejemplares_de_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            informacion i = new informacion();
            Console.WriteLine(i.convierte(343));
            dolar dol = new dolar();
            Console.WriteLine(dol.Convertw(434));
        }
    }
    //------------------------------------------------
    class informacion
    {
        private double euro = 1.2121;
    
    public double convierte(int n)
        {
            return n / euro;
        }
    }


    class dolar
    {
        private double d = 2.4343;
        public double Convertw(int n)
        {
            return n / d;
        }
    }


}
