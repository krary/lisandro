namespace USO_WHILE
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("¿Desea entrar en el bucle while?");
            String mensaje = Console.ReadLine();
            int counting = 0;
            while (mensaje != "no")


            {
                
                counting++;
                Console.WriteLine("already you are inc");
                Console.WriteLine("Desea salir?");
                String clave = Console.ReadLine();
                if (clave.Equals("quiro salir")) { 
                Console.WriteLine("exit..");
                Console.WriteLine("Succed");

                mensaje = "no";
            }
                else if (counting == 5)
                {
                    mensaje = "no";
                }
                }
            
            
        }
    }
}