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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        internal ObservableCollection<Recenzja> ListaRecenzji = null;
        public Window1()
        {
            InitializeComponent();
            StworzWiazania();
        }
        private void StworzWiazania()
        {
            ListaRecenzji = new ObservableCollection<Recenzja>();
            ListaRecenzji.Add(new Recenzja("Adam", 5, "Cukiernia ta to prawdziwe miejsce pełne słodkich rozkoszy! " +
                "Ich wypieki są nie tylko pyszne, ale również pięknie wykonane. Obsługa jest przyjazna, " +
                "a atmosfera przyjemna. Zdecydowanie warto odwiedzić, by delektować się ich wybornymi słodkościami!"));
            ListaRecenzji.Add(new Recenzja("Marcin", 4, "Pyszne jedzenie!!!"));
            ListaRecenzji.Add(new Recenzja("Marta", 3, "Ta cukiernia oferuje różnorodne wypieki i słodkości, " +
                "jednak jakość nie zawsze jest doskonała. " +
                "Obsługa jest przyjazna, ale czasami może być tłoczno. " +
                "Warto zwrócić uwagę na ich wybór, ale nie zawsze spełnia oczekiwania."));

            lstRecenzji.ItemsSource = ListaRecenzji;

            ObservableCollection<string> ListaOcen = new ObservableCollection<string>()
                { "1", "2", "3", "4", "5"};
            ocenaComboBox.ItemsSource = ListaOcen;
        }

        private void addButtonClick(object sender, RoutedEventArgs e)
        {
            String autor = Autor.Text;
            String tresc = Opinia.Text;
            int ocena = int.Parse(ocenaComboBox.Text);
            if (autor != "" && tresc != "")
            {
                ListaRecenzji.Add(new Recenzja(autor, ocena, tresc));
                Autor.Text = "";
                Opinia.Text = "";
            }

        }

        private void resetButtonClick(object sender, RoutedEventArgs e)
        {
            Autor.Text = "";
            Opinia.Text = "";
        }
        private void goToZakupy(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void goToPracownicy(object sender, RoutedEventArgs e)
        {
            Window2 okno1 = new Window2();
            okno1.Show();
            this.Close();
        }
    }
}
