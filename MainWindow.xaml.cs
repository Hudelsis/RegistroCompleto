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
using Microsoft.EntityFrameworkCore;
using RegistroCompleto.Entidades;
using RegistroCompleto.BLL;
using RegistroCompleto.DAL;


namespace RegistroCompleto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        private Persona persona;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = persona;
        }

        private void Limpiar()
        {
            this.persona = new Persona();
            this.DataContext = persona;
        }
        private bool Validar()
        {
            bool esValido = true;

            if(NombresTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transaccion Fallidad", "Fallo");
            }
            return esValido;

        }
        public void BuscarButton_Click (object sender, RoutedEventArgs e)
        {
            var persona =PersonaBLL.Buscar(int.Parse(IDTextBox.Text));
           
           if(persona != null)
            this.persona = persona;
            else
            this.DataContext = this.persona;

        }
        public void NuevoButton_Click(object sender, RoutedEventArgs e)
       {
            Limpiar();
           

       }
       public void GuardarButton_Click(object sender, RoutedEventArgs e)
       {
           

           if(!Validar())
           return;
           persona.Nombres=NombresTextBox.Text;
           persona.Cedula=CedulaTextBox.Text;
           persona.Direccion=CedulaTextBox.Text;
           persona.Telefono=TelefonoTextBox.Text;
           persona.FechaNacimiento =FechaTextBox.Text;
           var paso= PersonaBLL.Guardar(persona);

           if (paso){
               Limpiar();
               MessageBox.Show("Transacciones exitosa!", "Existo");              
           }
           else
           MessageBox.Show("Transacciones Fallida", "Fallo");
           
            
       }
       public void EliminarButton_Click(object sender, RoutedEventArgs e)
       {
           if(PersonaBLL.Eliminar(int.Parse(IDTextBox.Text)))
           {
               Limpiar();
               MessageBox.Show("Registro eliminado", "Existo");
           }
           else
           
             MessageBox.Show("No fue posible eliminar", "Fallo");
           
       }
      

       
    
    }
}
