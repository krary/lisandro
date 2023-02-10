namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Albert", 3433);

            e1.propiedad = 3233;
            

           
            
        }
    }

    class Empleado
    {
        private String nombre;
        private int salario;
        public Empleado(String nombre,int salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }public void SetSalario()
        {
            Console.WriteLine("El salario es de "+salario);
        }
        public int GetSalario(int salario)
        {
            this.salario = salario;
            if (salario <= 1400)
            {
                return "El salario es basico"; 
            }
            else
            {
                return "El salario no es basico";
            }
        }
        //AQUI VIENE EL EL LLAMADO METODO PROPERTY

        public int propiedad
        {
            get {return  this.salario; }
            set { this.salario=GetSalario(value)}
        }

    }






}//yr