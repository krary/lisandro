using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    internal class Warning : Avisos
    {
        private String remitente;
        private String fecha;
        private String mensaje;

        public Warning()
        {
            remitente = "DGT";
            mensaje = "Sanción cometida.Pague en tres dias y tendrá una reduccion del 50%";
            fecha = "";

        }
        public Warning(String remitente,String mensaje,String fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;

        }




        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAvisos()
        {
            Console.WriteLine("Mensaje{0}a sido enviado{1} el dia{2}", mensaje, remitente, fecha);
        }
    }
}
