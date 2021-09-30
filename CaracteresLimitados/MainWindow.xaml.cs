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

namespace CaracteresLimitados
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CambiarEdicionTexto()
        {
            escribirTextBox.IsReadOnly = int.Parse(caracteresActuales.Text) >= 140 ? true : false;
        }

        private void escribirTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            caracteresActuales.Text = escribirTextBox.Text.Length.ToString();
            CambiarEdicionTexto();
        }
    }
}
