namespace Ejemplo_Finally_Abriendo_Conexion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader lector = null;
            try
            {
                String linea;
                int contador=0;
                String path = @"C:\Users\Usuario\3D Objects\lectura.txt";
                lector = new System.IO.StreamReader(path);
                while ((linea = lector.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No se puede encontrar el archivo");

            }finally
                {
                if (lector != null) lector.Close();
                Console.WriteLine("Canal cerrado");
                
            }
        }
    }
}