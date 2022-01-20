using Equazione2Grado_Core;
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

namespace Equazione2Grado_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double valueA;
        double valueB;
        double valueC;
        Equazione eq = new Equazione();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRisolvi_Click(object sender, RoutedEventArgs e)
        {
            valueA = double.Parse(TextCoefficienteA.Text);
            valueB = double.Parse(TextCoefficienteB.Text);
            valueC = double.Parse(TextCoefficienteC.Text);

            double[] risultato = eq.RisolviEquazioneDiSecondoGrado(valueA, valueB, valueC);
            //con operatore ternario
            TextRisultato.Text = (risultato == null) ? "errore" : (risultato.Length == 1) ? risultato[0].ToString() : $"x1={risultato[0]} x2={risultato[1]}";
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            TextRisultato.Clear();
            TextCoefficienteA.Clear();
            TextCoefficienteB.Clear();
            TextCoefficienteC.Clear();
        }

        private void NumericOnly(object sender,TextCompositionEventArgs e)
        {
            if(char.IsNumber(e.Text,0) || char.IsPunctuation(e.Text, 0)){
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("inserisci solo valori numerici");
            }
        }
       

      
    }
}
