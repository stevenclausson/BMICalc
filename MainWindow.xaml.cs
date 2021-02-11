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
            float height;
            float weight;

            //check if numbers are input.
            if (!float.TryParse(heightText.Text, out height))
            {
                MessageBox.Show("Height needs to be a number only.");
                return;
            }
            if (!float.TryParse(weightText.Text, out weight))
            {
                MessageBox.Show("Weights needs to be a number only.");
                return;
            }



            height = float.Parse(heightInput);
            weight = float.Parse(weightInput);

            if (americanRadio.IsChecked == true)
            {
                totalBmi = (weight / (height * height)) * 703;
                bmiLabel.Content = totalBmi.ToString("0.00");
            }
            else
            {
                totalBmi = (weight / (height * height));
                bmiLabel.Content = totalBmi.ToString("0.00");
            }
            

            if (totalBmi <= 16)
            {
                labelText.Content = "Your BMI suggests you may be severely underweight!";
            }
            else if (totalBmi >= 16.1 && totalBmi <= 18.4)
            {
                labelText.Content = "Your BMI suggests you may be underweight.";
            }
            else if (totalBmi >=18.5 && totalBmi <= 24.9)
            {
                labelText.Content = "Your BMI suggests you are at a healthy and normal weight.";
            }
            else if (totalBmi >= 25 && totalBmi <= 29.9)
            {
                labelText.Content = "Your BMI suggests you are overweight.";
            }
            else if (totalBmi >= 30 && totalBmi <= 34.9)
            {
                labelText.Content = "Your BMI suggests you are moderetely overweight.";
            }
            else if (totalBmi >= 35 && totalBmi <= 39.9)
            {
                labelText.Content = "Your BMI suggests you are obese!";
            }
            else if (totalBmi >= 40)
            {
                labelText.Content = "Your BMI suggests you are morbidly obese!";
            }

        }
    }
}
