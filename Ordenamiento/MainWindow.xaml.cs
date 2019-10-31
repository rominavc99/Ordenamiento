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
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        public MainWindow()
        {
            InitializeComponent();

            miLista.Add(1);
            miLista.Add(3);
            miLista.Add(2);
            miLista.Add(4);
            miLista.Add(5);
            miLista.Add(9);
            miLista.Add(8);
            miLista.Add(7);

            lstNumeros.ItemsSource = miLista;
        }

        private void BtnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /*var temp = miLista[0];
              miLista[0] = miLista[3];
              miLista[3] = temp; */

            //SHELL
            int gap, temp, i, j;
            gap = miLista.Count / 2;

            while( gap > 0){

                for(i = 0; i<miLista.Count; i++)
                {
                    if(gap + i < miLista.Count && miLista[i] > miLista[gap + i])
                    {
                        temp = miLista[i];
                        miLista[i] = miLista[gap + i];
                        miLista[gap + i] = temp;
                    }
                }

                gap--;
            }

        }

        private void BtnBubble_Click(object sender, RoutedEventArgs e)
        {
            /* int i, j;
            int temp = 0;
            for(i =1; i < miLista.Count; i++)
            {
                for (j = 0; j < miLista.Count - i; j++)
                {
                    if (miLista[j] > miLista[j + 1])
                    {
                        temp = miLista[j];
                        miLista[j] = miLista[j + 1];
                        miLista[j + 1] = temp;
                    }
                }
            } */

            bool intercambio = false;
            do
            {
                for (int i = 0; i < miLista.Count - 1; i++)
                {
                    if (miLista[i] > miLista[i + 1])
                    {
                        int temp = miLista[i];
                        miLista[i] = miLista[i + 1];
                        miLista[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }
    }
}
