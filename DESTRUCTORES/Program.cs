using System.Security.Cryptography.X509Certificates;

namespace DESTRUCTORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivo c = new ManejoArchivo();
            c.info();
            
        }
    }

    class ManejoArchivo
    {
        StreamReader archivo=null;
        int contador = 0;
        String linea;

        public ManejoArchivo()
        {
            archivo = new StreamReader(@"C:\Users\Usuario\3D Objects\lectura.txt");
            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;  
            }
            
            
        }
        public void info()
        {
            Console.WriteLine("El archivo posee un total de {0} :lineas", contador);
        }
        ~ManejoArchivo()
        {
            archivo.Close();
        }
    }

}