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

        private void submit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitted!");
            Animal animal = new Animal() { Name= name.Text, Birth= DateTime.Parse(birth.Text), Gender=gender.Text, Type= type.Text , Weight=double.Parse(weight.Text)};
            list.Add(animal);
            //name.Text = (sp.SelectedItem as Animal).Name;
            //birth.Text = (sp.SelectedItem as Animal).Birth.ToString();
            //type.Text = (sp.SelectedItem as Animal).Type;
            //gender.Text = (sp.SelectedItem as Animal).Gender;

        }

        private void show(object sender, MouseButtonEventArgs e)
        {
            //myL.ItemsSource = null;
            //myL.ItemsSource = animal;
            //TextBlock t= new TextBlock ();
            //t.Text = ;
            //mySp.Padding(t);
        }

        private void show(object sender, RoutedEventArgs e)
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
