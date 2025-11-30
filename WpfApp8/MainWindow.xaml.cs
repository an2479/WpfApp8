using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Xml.Linq;

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
            List<Animal> list = new List<Animal>();
            try
            {
                list.Add(new Animal(name.Text, DateTime.Parse(birth.Text), type.Text, gender.Text, double.Parse(weight.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//ehat if name is a number??
            TextShow.Visibility = Visibility.Visible;
            Animal a=new Animal(name.Text, DateTime.Parse(birth.Text), type.Text, gender.Text, double.Parse(weight.Text));
            list.Add(a);
            mySp.ItemsSource = list;
            mySp.Visibility = Visibility.Visible;
            //name.Text = (sp.SelectedItem as Animal).Name;
            //birth.Text = (sp.SelectedItem as Animal).Birth.ToString();
            //type.Text = (sp.SelectedItem as Animal).Type;
            //gender.Text = (sp.SelectedItem as Animal).Gender;
        }

        private void ShowDetails(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("hi");
        }
    }
}
