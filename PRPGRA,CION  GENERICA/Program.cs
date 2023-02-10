namespace PRPGRA_CION__GENERICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            almacenObjetos <Empleado>jj = new almacenObjetos<Empleado>(4);
            /*jj.agregar("NOMBRE");
            jj.agregar("SALARIO");
            jj.agregar("CUOTA MENSUAL");
            jj.agregar("UNI");
            String nombre = (String)jj.getElementos(1);
            Console.WriteLine(nombre);*/
            jj.agregar(new Empleado(1500));
            jj.agregar(new Empleado(344));
            jj.agregar(new Empleado(150));
            jj.agregar(new Empleado(47787));
            Empleado empleado = jj.getElementos(2);
            Console.WriteLine(empleado.salarios());
        }
    }
    class almacenObjetos<T>
    {
        private T [] datosElementos;
        private int i = 0;
        public almacenObjetos(int z)
        {
            datosElementos = new T [z];
        }
        public void agregar(T obj)
        {
            datosElementos[i] = obj;
            i++;
        }
        public T getElementos(int i)
        {
            return datosElementos[i];
        }
    }
    class Empleado
    {
        private int salario;
        public Empleado(int salario)
        {
            this.salario = salario;
        }
        public int salarios()
        {
            return salario;
            
        }
    }
}