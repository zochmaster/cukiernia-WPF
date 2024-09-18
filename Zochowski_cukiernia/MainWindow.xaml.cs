using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using static System.Net.Mime.MediaTypeNames;

namespace Zochowski_cukiernia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ObservableCollection<Produkt> ListaProduktow = null;

        public MainWindow()
        {
            InitializeComponent();
            StworzWiazania();
        }
        private void StworzWiazania()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("ciastko", 4.99, "za sztuke"));
            ListaProduktow.Add(new Produkt("tort czekoladowy", 69.99, "za kilogram"));

            lstProduktow.ItemsSource = ListaProduktow;

            
            ObservableCollection<string> ListaKupna = new ObservableCollection<string>();
            foreach (var produkt in ListaProduktow)
            {
                ListaKupna.Add(produkt.Nazwa);
            }
            produktyComboBox.ItemsSource = ListaKupna;

            ObservableCollection<string> ListaRodzajow = new ObservableCollection<string>()
                { "za sztuke", "za kilogram"};
            rodzajComboBox.ItemsSource = ListaRodzajow;
        }

        private void addButtonClick(object sender, RoutedEventArgs e)
        {
            String nazwa = Name.Text;
            String rodzaj = rodzajComboBox.Text;
            CultureInfo culture = CultureInfo.InvariantCulture;
            NumberStyles style = NumberStyles.AllowDecimalPoint;
            if (nazwa != "")
            {
                if (double.TryParse(Price.Text, style, culture, out double wynik))
                {
                    double cena = double.Parse(Price.Text, culture);

                    ListaProduktow.Add(new Produkt(nazwa, cena, rodzaj));
                    komunikat.Content = "";
                    Price.Text = "";
                    Name.Text = "";
                    ObservableCollection<string> ListaKupna = new ObservableCollection<string>();
                    foreach (var produkt in ListaProduktow)
                    {
                        ListaKupna.Add(produkt.Nazwa);
                    }
                    produktyComboBox.ItemsSource = ListaKupna;
                }
                else { komunikat.Content = "wpisz poprawną cenę"; }
            }
            else { komunikat.Content = "wpisz prawną nazwę"; }

        }

        private void resetButtonClick(object sender, RoutedEventArgs e)
        {
            komunikat.Content = "";
            Name.Text = "";
            Price.Text = "";
        }


        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Produkt produkt = lstProduktow.SelectedItem as Produkt;
            if (produkt != null)
            {
                MessageBoxResult odpowiedz = MessageBox.Show("Czy wykasować produkt: " +
                    produkt.Nazwa + "?", "Pytanie", MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (odpowiedz == MessageBoxResult.Yes)
                {
                    ListaProduktow.Remove(produkt);
                    ObservableCollection<string> ListaKupna = new ObservableCollection<string>();
                    foreach (var produkt2 in ListaProduktow)
                    {
                        ListaKupna.Add(produkt2.Nazwa);
                    }
                    produktyComboBox.ItemsSource = ListaKupna;
                }

            }
        }
        private void buyButtonClick(object sender, RoutedEventArgs e)
        {
            Produkt myProdukt = new Produkt();
            foreach(Produkt produkt in ListaProduktow)
            {
                if (produktyComboBox.Text == produkt.Nazwa)
                {
                    myProdukt = produkt;
                    break;
                }
            }
            if (myProdukt.Rodzaj == "za sztuke")
            {
                int ilosc;
                if (int.TryParse(Quantity.Text, out ilosc))
                {
                    double zaplata = ilosc * myProdukt.Cena;
                    komunikat.Content = "do zapłaty: "+ Math.Round(zaplata,2) +" zł";
                }
                else { komunikat.Content = "podaj właściwą ilość produktu"; }
            }else if (myProdukt.Rodzaj == "za kilogram") {
                double ilosc;
                if (double.TryParse(Quantity.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out ilosc))
                {
                    double zaplata = ilosc * myProdukt.Cena;
                    komunikat.Content = "do zapłaty: " + Math.Round(zaplata, 2) + " zł";
                }
                else { komunikat.Content = "podaj właściwą ilość produktu"; }



            } else{komunikat.Content = "podaj właściwą nazwę produktu";}

                        
            Quantity.Text = "";
        }
        private void listDblClick(object sender, RoutedEventArgs e)
        {

        }

        private void goToPracownicy(object sender, RoutedEventArgs e)
        {
            Window2 okno1 = new Window2();
            okno1.Show();
            this.Close();
        }

        private void goToOpinie(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
    }
}
