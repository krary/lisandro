using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INTERFAZ_GRAFICAS_NOTIFY_PROPERY_CHANGED
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Unificadores = new Unificador { Nombres="Lisandro",Apellidos="Sarmiento"};
            this.DataContext = Unificadores;
        }
        public Unificador Unificadores;
    }
}
