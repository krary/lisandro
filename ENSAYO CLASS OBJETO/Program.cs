namespace EN<SAYO_CLASS_OBJETO
{
    internal class Program
    {
        static void Main(string[] args)
        {
        objeto objetos= new objeto();
        empleado empleados = new empleado(32,"xjkj");

        objetos.getobjeto(empleados, 2, 1);




 //CRANDO CLASSE QUE PUEDEN CONTENER TODOS LOS TYPOS DE OBJETOS
        }
    }

    class objeto
    {
        private int indice=0;
        private int totalArrayz=0;
        private Object[] obj;
        public objeto()
        {
            
        }
        public Object getobjeto(Object ob ,int z,int indice)
        {   this.indice=indice;

            
            totalArrayz = z;
            
            obj = new Object[totalArrayz];
            return obj[indice]=ob;
        }
    }
      class empleado
      {
           private int edad;
           private String nombre;
        public empleado(int edad,String nombre)
    {
        this.edad = edad;
        this.nombre = nombre;
    }

      }






}