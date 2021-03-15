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
    /// Logica di interazione per EquazioneSecondo.xaml
    /// </summary>
    public partial class EquazioneSecondo : Window
    {
        public EquazioneSecondo()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int a4 = int.Parse(txtA.Text);
                int b6 = int.Parse(txtB.Text);
                int c1 = int.Parse(txtC.Text);
                string s = Equazioni.EquazioneSecondo(a4, b6, c1);
                lblRisultato.Content = s;
            }
            catch (Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
