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
using System.IO;

namespace SortingAlgorithmsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            unsortedListBlock.Text = "Unsorted Numbers " + readFromFileStr();

        }
        static int[] readFromFile()
        {
            string fileContents = File.ReadAllText(@"C:\dev\origin\05-ConsoleUpgrade\SortingAlgorithmsWPF\SortingAlgorithmsWPF\unsorted-numbers.txt");
            string[] stringArr = fileContents.Split(',');

            int[] list = new int[stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                list[i] = int.Parse(stringArr[i]);

            }
            return list;
            
        }
        static string readFromFileStr()
        {
            string fileContents = File.ReadAllText(@"C:\dev\origin\05-ConsoleUpgrade\SortingAlgorithmsWPF\SortingAlgorithmsWPF\unsorted-numbers.txt");
            return fileContents;

        }
        static string printList(int[] list)
        {
            string listPrint = "";
            for (int i = 0; i < list.Length; i++)
            {
                listPrint += (list[i] + ", ");
            }
            return listPrint;

        }

        private void bubbleSortButton_Click(object sender, RoutedEventArgs e)
        {
            int[] list = readFromFile();
            for (int i = 1; i <= list.Length - 1; i++)
            {

                for (int j = 0; j < (list.Length - 1); j++)
                {
                    if (list[j + 1] < list[j])
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

           unsortedListBlock.Text =  "Sorted Numbers    " + printList(list);

        }

        private void insertionSortButton_Click(object sender, RoutedEventArgs e)
        {
            int[] list = readFromFile();
            int temp;
            int j;

            for (int i = 1; i < list.Length; i++)
            {
                temp = list[i];
                j = i - 1;

                while (j >= 0 && list[j] > temp)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                list[j + 1] = temp;
            }

            unsortedListBlock.Text = "Sorted Numbers    " + printList(list);
        }

        private void selectionSoryButton_Click(object sender, RoutedEventArgs e)
        {
            int[] list = readFromFile();

            int i, j, min, temp;
            for (i = 0; i < list.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }
                temp = list[i];
                list[i] = list[min];
                list[min] = temp;
            }

            unsortedListBlock.Text = "Sorted Numbers    " + printList(list);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unsortedListBlock.Text = "Unsorted Numbers " + readFromFileStr();
        }

      

     
       
    }
}
