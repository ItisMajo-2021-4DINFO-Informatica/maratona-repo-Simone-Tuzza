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

namespace TuzzaMAratona
{

    public partial class MainWindow : Window
    {
        maratone maratone;

        public MainWindow()
        {
            InitializeComponent();
            maratone = new maratone();
            DgElencomaratone.ItemsSource = maratone.elencomaratone;
        }
 

            private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e)
            {
                maratone.LeggiDati();
                DgElencomaratone.Items.Refresh();
            }


   
        private void BtnCercaAtleta_Click(object sender, RoutedEventArgs e)
        {
            string nome = TxtTitolo.Text;
            string citta = TxtCitta.Text;
            string artistaTrovato = maratone.CercaAtleta(nome, citta);
            LblAtleta.Content = artistaTrovato;
        }
    }
    }

