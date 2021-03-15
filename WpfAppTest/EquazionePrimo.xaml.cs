using System;
using EquazioniLibrary;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppTest
{
    /// <summary>
    /// Logica di interazione per EquazionePrimo.xaml
    /// </summary>
    public partial class EquazionePrimo : Window
    {
        public EquazionePrimo()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double a5 = int.Parse(txtA.Text);
                double b7 = int.Parse(txtB.Text);
                string s1 = Equazioni.EquationDegree1(a5, b7);
                lblRisultato.Content = s1;
            }
            catch (Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
