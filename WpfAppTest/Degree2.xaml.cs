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
    /// Logica di interazione per Degree2.xaml
    /// </summary>
    public partial class Degree2 : Window
    {
        public Degree2()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int a2 = int.Parse(txtA.Text);
                bool b3 = Equazioni.IsDegree2(a2);
                if (b3)
                    lblRisultato.Content = "l'equazione è di secondo grado";
                else
                    lblRisultato.Content = "l'equazione non è di secondo grado";
            }
            catch (Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
