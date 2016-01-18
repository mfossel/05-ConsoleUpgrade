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

namespace ColatzWPF
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
        
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                try
                {

                    string input = numInputBox.Text;
                    int userNum = int.Parse(input);
                    int count = 0;
                    int peakInt = userNum;
                    int countAtPeak = 0;


                    while (userNum != 1)
                    {
                        if (userNum % 2 == 0)
                        {
                            userNum = userNum / 2;
                            count = count + 1;

                            if (userNum > peakInt)
                            {
                                peakInt = userNum;
                                countAtPeak = count;
                            }

                        }
                        else
                        {
                            userNum = userNum * 3 + 1;
                            count = count + 1;
                            if (userNum > peakInt)
                            {
                                peakInt = userNum;
                                countAtPeak = count;
                            }


                        }


                    }



                    outputBox.Text = "You made it to 1. It took " + count + " steps to reach 1. The peak integer was "
                        + peakInt + " and it occured at step " + countAtPeak + ".";
                    
                   
                }



                catch (Exception)
                {
                    outputBox.Text = "Please enter a number.";

                }
            

        }





        

    
    }

}