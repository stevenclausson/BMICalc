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

namespace BMI_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string heightInput;
        public string weightInput;
        public float totalBmi;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            heightInput = heightText.Text;
            weightInput = weightText.Text;

            float height = float.Parse(heightInput);
            float weight = float.Parse(weightInput);
            
            totalBmi = (weight / (height * height)) * 703;
            bmiLabel.Content = totalBmi;

        }
    }
}
