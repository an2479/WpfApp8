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

        List<Animal> list = new List<Animal>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitted!");
            Animal animal = new Animal() { Name= name.Text, Birth= DateTime.Parse(birth.Text), Gender=gender.Text, Type= type.Text , Weight=double.Parse(weight.Text)};
            list.Add(animal);
        }
        private void Show(object sender, RoutedEventArgs e)
        {
            StackPanel sp = new StackPanel();
            Border border = new Border();

            TextBlock textBlock = new TextBlock() { Text = "name: " + name + "birth: " + birth.Text + "type: " + type.Text + "gender: " + gender.Text + "weight: " + weight.Text };

            sp.Children.Add(textBlock);
            border.Child = sp;
            showAnimals.Children.Add(border);
        }
    }
}
