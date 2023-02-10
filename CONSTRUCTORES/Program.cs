namespace CONSTRUCTORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            coche coche1 = new coche();
            coche1.tapiz("si");
            coche1.clim(true);
            Console.WriteLine(coche1.info());
        }
    }

class coche
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private Boolean climatizador;
        private String tapizeria;
        public coche()
        {
            ruedas = 4;
            largo = 34.31;
            ancho = 34;
            climatizador = false;
            tapizeria = "no";
            climatizador = false;

        }
        public String info()
        {
            return "RUEDAS :\n"+ "\n "+ruedas +"\n"+ "Largo :\n" + largo + "\n" + "Ancho:\n " + ancho+"\n"+
                "Tapizeria:\n"+tapizeria+"\n" + "Climatizador::\n"+climatizador;
        }
        public void tapiz(String tap)
        {
            tapizeria = tap;

        }
        public void clim(Boolean cli)
        {
            climatizador = cli;
        }
    }









}