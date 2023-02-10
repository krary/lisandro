namespace ARRAYS_EN_METODOS
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello, World!");
            int[] datos = new int[4];
            datos[0] = 1313;
            datos[1] =43242;
            datos[2] = 154;
            datos[3] = 545;
            arrays(datos);
            leerdatos();

        }//METODO VOID EN ARRAYS
        static void arrays(int[] numeros)
        {
            foreach (int e in numeros)
            {
                Console.WriteLine(e);
            }
        
            //METODO SETTERS EN ARRAYS
            
            
        }
        static int[] leerdatos()
        {
            Console.WriteLine("Introduce su index");
            String respuesta = Console.ReadLine();
            int conv = int.Parse(respuesta);
            int[] datos = new int[conv];
            for (int i = 0; i < conv; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion {i}");
                respuesta = Console.ReadLine();
                int datosElementos = int.Parse(respuesta);
                datos[i] = datosElementos;
            }
            return datos;
        }
    }
}