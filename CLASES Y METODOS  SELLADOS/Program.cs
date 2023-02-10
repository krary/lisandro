namespace CLASES_Y_METODOS__SELLADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    sealed class ciudad
    {
        private int  casas;
        private int personas;
        private boolena reyReina;
        private int ingenieros;
        public ciudad()
        {
            casas = 0;
            personas = 0;
            reyReina = false;
            ingenieros = 0;
        }
        public sealed virtual int i() => ingenieros;
        public sealed virtual int persona() => personas;
        public sealed virtual int casa() => casas;
        public sealed virtual Boolean reyes() => reyReina;  
    }
    class laHabana:ciudad
    {
        public void i() => Console.WriteLine("INGENIORSO :23232");
        public void persona() => Console.WriteLine("Personas :34343434");
        public void casa() => Console.WriteLine( 34343);
        public void reyes() => Console.WriteLine(false);
    }


}


}//YJ