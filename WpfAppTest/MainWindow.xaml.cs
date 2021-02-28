using System;
using EquazioniLibrary;
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

namespace WpfAppTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Buttom_Click()
        {
            Console.Write("Inserisci il numero accanto di cosa vuoi eseguire:\n1 verifica se è determinata, \n2 se è impossibile, \n3 se è di secondo grado, \n4 se vuoi calcolare il delta, \n5 se vuoi il risultato di un'equazione di secondo grado, \n6 se vuoi il risultato di un'equazione di primo grado \n");
            string str = Console.ReadLine();

            switch (str)
            {
                case "1":
                    Console.Write("Inserisci il valore di a: ");
                    int a = int.Parse(Console.ReadLine());
                    bool b = Equazioni.IsDetermined(a);
                    if (b)
                        Console.WriteLine("l'equazione è determinata");
                    else
                        Console.WriteLine("l'equazione non è determinata");
                    break;

                case "2":
                    Console.Write("Inserisci il valore di a: ");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci il valore di b: ");
                    int b1 = int.Parse(Console.ReadLine());
                    bool b2 = Equazioni.IsInconsisted(a1, b1);
                    if (b2)
                        Console.WriteLine("l'equazione è impossibile");
                    else
                        Console.WriteLine("l'equazione non è impossibile");
                    break;

                case "3":

                    break;
                default:
                    Console.Write("valore inserito non valido");
                    break;
            }
        }
    }
}
