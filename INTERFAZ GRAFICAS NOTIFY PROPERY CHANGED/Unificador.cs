using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFAZ_GRAFICAS_NOTIFY_PROPERY_CHANGED
{
   public class Unificador :INotifyPropertyChanged
    {
        private String Nombre;
        private String Apellido;
        private String Nombre_completo;
        
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(String propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
        public String Nombres
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public String Apellidos
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public String Nombres_completos
        {
            get {  Nombre_completo=Nombre+" "+Apellido;
                return Nombre_completo;            }
            set {  }
        }




    }
}
