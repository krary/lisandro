namespace ARRAYS_IMPLICITO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays implicitos
            var datos = new[] { "nombre", "apellidos", ".." };
            var miclase = new { nombre = "nombre", edad = 32 };
            var variable = 243242;
            //Aqui se tiene los tres tipos de arreglos conrespecto a no hacer instancias
            Empleado[] empleado = new Empleado[3];
            empleado[0] = new Empleado("Juan", 32);
            empleado[1] = new Empleado("Albert", 42);
            empleado[2] = new Empleado("Sarah", 22);

            var e = new[]
            {
                new{Nombre="maria",Edad=23},
                new {Nombre="Sarah",Edad=43},
                new{Nombre="Kyle",Edad=43},
                new {Nombre="GAMB",Edad=33}
            };
            for(int i = 0; i < e.Length; i++)
            {
                Console.WriteLine(e[i]);
            }
            foreach(var w in e)
            {
                Console.WriteLine(w);
            }
        }
        class Empleado
        {
            private String nombre;
            private int Edad;
            public Empleado(String nombre,int Edad)
            {
                this.nombre = nombre;
                this.Edad = Edad;
            }
        }
    }
}