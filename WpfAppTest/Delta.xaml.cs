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
    /// Logica di interazione per Delta.xaml
    /// </summary>
    public partial class Delta : Window
    {
        public Delta()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int a3 = int.Parse(txtA.Text);
                int b4 = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                double b5 = Equazioni.Delta(a3, b4, c);
                lblRisultato.Content = $"Il delta è: {b5} ";
            }
            catch (Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
