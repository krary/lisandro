namespace ENUM
{ enum Estaciones { Primavera,varano,otoño,invierno};
   enum salario { bajo=54,medio=676,normal=1000,alto=1400};
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUM son los tiops enumerados   
            Estaciones? variable_null = null;
            Estaciones estacion = Estaciones.Primavera;
            Console.WriteLine(estacion);
            salario ss = salario.bajo;
            int numero = (int)ss;
            Console.WriteLine(numero);
        }
    }

}