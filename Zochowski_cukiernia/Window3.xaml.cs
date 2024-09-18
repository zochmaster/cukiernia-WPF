using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Zochowski_cukiernia
{
    /// <summary>
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private Window2 Window2 = null;
        public Window3()
        {
            InitializeComponent();

        }
        public Window3(Window2 mainWin)
        {
            InitializeComponent();
            Window2 = mainWin;
            tableFill();
        }
        private void tableFill()
        {
            Pracownik pracownik = Window2.lstPracownicy.SelectedItem as Pracownik;

            gridPracownik.DataContext = pracownik;
            ObservableCollection<string> ListaStanowisk = new ObservableCollection<string>()
                { "Kucharz", "Cukiernik", "Sprzedawca", "Stażysta"};
            Stanowisko.ItemsSource = ListaStanowisk;



        }


        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
