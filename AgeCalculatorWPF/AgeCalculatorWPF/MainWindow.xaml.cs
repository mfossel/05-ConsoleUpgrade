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

namespace AgeCalculatorWPF
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                
                DateTime Bday = calendar.SelectedDate.Value;
                TimeSpan Diff = DateTime.Now.Subtract(Bday);
                Double NumDays = Diff.Days;
                Double NumYears = NumDays / 365;

                Double NumWeeksRem = (NumDays % 365);
                Double NumWeeks = NumWeeksRem / 7;

                Double NumDaysLeft = (NumWeeksRem % 7);

                int NumYearsInt = (int)NumYears;
                string NumYearsStr = NumYearsInt.ToString();

                int NumWeeksInt = (int)NumWeeks;
                string NumWeeksStr = NumWeeksInt.ToString();

                int NumDaysInt = (int)NumDaysLeft;
                string NumDaysStr = NumDaysInt.ToString();


                ageOutput.Text = NumYearsStr + " years " + NumWeeksStr + " weeks and " + NumDaysStr + " days";

            }

            catch (FormatException)
            {
                ageOutput.Text = "Please enter your birthday in the correct format (MM-DD-YYYY)";
            }
        }

       

    }
}
