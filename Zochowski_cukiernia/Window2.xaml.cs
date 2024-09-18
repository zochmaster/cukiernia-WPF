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
    public partial class Window2 : Window
    {
        internal ObservableCollection<Pracownik> ListaPracownikow = null;
        public Window2()
        {
            InitializeComponent();
            StworzWiazania();
        }
        private void StworzWiazania()
        {
            ListaPracownikow = new ObservableCollection<Pracownik>();
            ListaPracownikow.Add(new Pracownik("Adam", "Nowak", "Kucharz"));
            ListaPracownikow.Add(new Pracownik("Wojciech", "Dąbrowski", "Cukiernik"));
            ListaPracownikow.Add(new Pracownik("Marian", "Gąska", "Sprzedawca"));

            lstPracownicy.ItemsSource = ListaPracownikow;

            ObservableCollection<string> ListaStanowisk = new ObservableCollection<string>()
                { "Kucharz", "Cukiernik", "Sprzedawca", "Stażysta"};
            stanowiskoComboBox.ItemsSource = ListaStanowisk;

            
        }

        private void addButtonClick(object sender, RoutedEventArgs e)
        {
            String name = userName.Text;
            String stanowisko = stanowiskoComboBox.Text;
            if(name.Split(" ").Length > 1)
            {
               ListaPracownikow.Add(new Pracownik(name.Split(" ")[0], name.Split(" ")[1], stanowisko));
                komunikat.Content = "";
                userName.Text = "";
                
            }
            else { komunikat.Content = "nieprawidłowe imie!!!"; }
             
        }

        private void resetButtonClick(object sender, RoutedEventArgs e)
        {
            komunikat.Content = "";
            userName.Text = "";
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Pracownik pracownik = lstPracownicy.SelectedItem as Pracownik;
            if (pracownik != null)
            {
                MessageBoxResult odpowiedz = MessageBox.Show("Czy wykasować pracownika: " +
                    pracownik.Imie + " " + pracownik.Nazwisko + "?", "Pytanie", MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (odpowiedz == MessageBoxResult.Yes)
                {
                    ListaPracownikow.Remove(pracownik);
                    
                }

            }
        }

        private void lstPracownicy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window3 okno1 = new Window3(this);
            okno1.ShowDialog();
            
        }

        private void goToZakupy(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
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
