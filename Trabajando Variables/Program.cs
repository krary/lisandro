using System;

namespace Trabajando_Variables
{
   class  Variables
    {
        static void Main(string[]args)
        {
            int[] p = new int[2];
            p[0] = 343;
            p[1] = 445;

            Console.WriteLine(p[0]);
            //DECLARACION IMPLICITA DE VARIABLES
            var numero = "lisandro";
            Console.WriteLine(numero);
            //CONVERSIONES DE TIPO IMPLICITA Y EXPLICITA
            double var1 = 343.3;
            int var;
            var = (int)var1;
            Console.WriteLine(var);
            //CONVERSION DE STRING A INT 
            String b = "343";
            int a;
            a = int.Parse(b);
            Console.WriteLine(a + 454);








            
        
        
        
        
        }
    }
}