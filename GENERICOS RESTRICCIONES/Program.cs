using System.Reflection.Metadata.Ecma335;

namespace GENERICOS_RESTRICCIONES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contenedor<fontanero> contenedor1 = new contenedor<fontanero>(2);
            contenedor1.agregaobjeto(new fontanero(2323));
            contenedor1.agregaobjeto(new fontanero(4344));
            Console.WriteLine(contenedor1.devuelve(1));
        }
    }
    interface Salario
    {
        public void getSalario();
    }
    class contenedor<t> where t:Salario
    {
        private int c;
        private t[]datosempleados;
        private int i = 0;
        public contenedor(int c)
        {
            this.c = c;
            datosempleados = new t[c];
        }
        public void agregaobjeto(t o)
        {
            datosempleados[i] = o;
            i++;

        }
        public t devuelve(int i)
        {
            return datosempleados[i];

        }




    }
        class maestro : Salario
        { private int salario;
            public maestro(int salario)
            {
                this.salario = salario;
            }

            public void getSalario()
            {
                Console.WriteLine("El salario es de {salario}", salario);
            }
        }
        class electricista : Salario
        {
            private int salario;
            public electricista(int salario)
            {
                this.salario = salario;
            }
            public void getSalario() {
                Console.WriteLine("El salario es de ", salario);
            } }
        class fontanero : Salario { 
        private int salario;

        public fontanero(int salario)
        { this.salario = salario;


        }
        public void getSalario() {
            Console.WriteLine("El salario es de ", salario);
        } }
    class programador
    {

    }
}