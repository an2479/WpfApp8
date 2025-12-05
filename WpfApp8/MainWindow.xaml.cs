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
using static System.Net.Mime.MediaTypeNames;

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
            MinLength min = new MinLength();
            min.MinLen = 3;
            ValidationResult rMinN = min.Validate(name.Text,null);
            ValidationResult rMinT = min.Validate(type.Text,null);

            MaxLength max = new MaxLength();
            max.MaxLen = 10;
            ValidationResult rMaxN = max.Validate(name.Text, null);
            ValidationResult rMaxT = max.Validate(type.Text, null);

            Birth b = new Birth();
            ValidationResult rB = b.Validate(birth.Text,null);
            
            Gender g = new Gender();
            ValidationResult rG = g.Validate(gender.Text, null);

            Weight w = new Weight();
            ValidationResult rW = w.Validate(weight.Text, null);

            if(rMinN.IsValid && rMinT.IsValid && rMaxN.IsValid && rMaxT.IsValid && rB.IsValid && rW.IsValid && rG.IsValid)
            {
                MessageBox.Show("Successfully submitted!");
                Animal animal = new Animal() { Name = name.Text, Birth = birth.Text, Gender = gender.Text, Type = type.Text, Weight = double.Parse(weight.Text) };
                list.Add(animal);
            }
            else
            {
                MessageBox.Show("Can't submit. Check if the data is correct.");
            }
        }
        private void Show(object sender, RoutedEventArgs e)
        {
            Border border = new Border();
            border.BorderBrush = Brushes.Black;
            border.BorderThickness = new Thickness(1);
            TextBlock textBlock = new TextBlock() { Text = " name: " + name.Text + "\n" + " birth: " + birth.Text + "\n" + " type: " + type.Text + "\n" + " gender: " + gender.Text + "\n" + " weight: " + weight.Text };
            textBlock.FontSize = 23;
            border.Child = textBlock;
            showAnimals.Children.Add(border);
        }
    }
}
