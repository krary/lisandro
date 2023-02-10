namespace HERENCIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            humano h1 = new humano("Filosofo");
            caballo c1 = new caballo("Mustang");
            gorila g1 = new gorila("Espalda Plateada");
            h1.pensar();
            mamifero h2 = new humano("Programador");
            Object[] objetosClase = new Object[4];
            objetosClase[0] = h1;
            objetosClase[1] = g1;
            objetosClase[2] = c1;
            objetosClase[3] = h2;
                    }
    }
    class mamifero
    {
        private String nombreSerVivo;
        public mamifero(String nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }
        
        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public virtual void pensar()
        {
            ConsoleWrite("pensamientos basicos instintivos");
        }
        public void crias()
        {
            Console.WriteLine("Puedo cuidar de mis crias");
        }
    }
    class caballo : mamifero {
        public caballo(String horse) : base(horse)
        { 
        }
        public void galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }
    class humano : mamifero
    {public humano(String superior) : base(superior)
    {
            public override void pensar()
            {
                Console.WriteLine("Im avilable to THINK MY FRIEND");
            }
        }
        public override void pensar()
        {
            Console.WriteLine("Puedo Pensar y Razonar");
        }
    }
    class gorila : mamifero
    {
        public gorila(String plateado) : base(plateado)
        {

        }

        public void trapar()
        {
            Console.WriteLine("Soy capaz de treapar");
        }
    }
}