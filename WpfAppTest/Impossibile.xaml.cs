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
    /// Logica di interazione per Impossibile.xaml
    /// </summary>
    public partial class Impossibile : Window
    {
        public Impossibile()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int a1 = int.Parse(txtA.Text);
                int b1 = int.Parse(txtB.Text);
                bool b2 = Equazioni.IsInconsisted(a1, b1);
                if (b2)
                    lblRisultato.Content = "l'equazione è impossibile";
                else
                    lblRisultato.Content = "l'equazione non è impossibile";
            }
            catch (Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
