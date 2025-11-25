using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace WpfApp8
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

        private void submit(object sender, RoutedEventArgs e)
        {
            TextBlock show = new TextBlock();
            show.Text = "Show";
            show.FontSize = 40;
            sp.Children.Add(show);
            List<Animal> list = new List<Animal>();
            try
            {
                list.Add(new Animal(name.Text, DateTime.Parse(birth.Text), type.Text, gender.Text, double.Parse(weight.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //sp.ItemsSource = list;
            //name.Text = (name.SelectedItem as Animal).Name;
        }
    }
}
