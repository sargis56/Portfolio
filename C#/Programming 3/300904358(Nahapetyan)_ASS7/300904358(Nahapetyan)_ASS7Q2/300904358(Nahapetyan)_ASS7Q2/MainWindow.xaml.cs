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

namespace _300904358_Nahapetyan__ASS7Q2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] intArray = new int[10];
        double[] doubleArray = new double[10];

        public MainWindow()
        {
            InitializeComponent();
            GenerateIntegerValues();
            GenerateDoubleValues();
        }

        private void GenInt_Click(object sender, RoutedEventArgs e)
        {
            GenerateIntegerValues();
        }

        private void GenDouble_Click(object sender, RoutedEventArgs e)
        {
            GenerateDoubleValues();
        }

        private void btnGenBoth_Click(object sender, RoutedEventArgs e)
        {
            GenerateIntegerValues();
            GenerateDoubleValues();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int intKeyIndex = Search<int>(intArray, txtSearchKey.Text);
                double doubleKeyIndex = Search<double>(doubleArray, txtSearchKey.Text);

                MessageBox.Show("Element: " + txtSearchKey.Text + "\nIndex: " + intKeyIndex + "\nIn: Integer Array", "Search in Integer Array");
                MessageBox.Show("Element: " + txtSearchKey.Text + "\nIndex: " + doubleKeyIndex + "\nIn: Double Array", "Search in Integer Array");
            }
            catch //(Exception error) //\n\nERROR: " + error
            {
                MessageBox.Show("ERROR: " + txtSearchKey.Text + " is not a proper value.\nPlease insert a integer or a double.", "ERROR");
            }
        }

        public int Search<T>(T[] inputArray, string searchKey) where T : IComparable <T>
        {
            int index = -1;

            var key = (T)Convert.ChangeType(searchKey, typeof(T));

            foreach (var element in inputArray)
            {
                index++;

                if (key.CompareTo(element) == 0 )
                {
                    return index;
                }
            }

            return -1;
        }

        public void GenerateDoubleValues()
        {
            var generator = new Random();

            txtGenTextBoxDouble.Clear();
            txtGenTextBoxDouble.AppendText("Double Array:" + Environment.NewLine);

            for (var i = 0; i < doubleArray.Length; ++i)
            {
                doubleArray[i] = generator.Next(10, 100);
                txtGenTextBoxDouble.AppendText((i) + ": " + doubleArray[i] + Environment.NewLine);
                //MessageBox.Show(Convert.ToString(data2[i]), Convert.ToString(i));
            }
        }

        public void GenerateIntegerValues()
        {
            var generator = new Random();

            txtGenTextBoxInteger.Clear();
            txtGenTextBoxInteger.AppendText("Integer Array:" + Environment.NewLine);

            for (var i = 0; i < intArray.Length; ++i)
            {
                intArray[i] = generator.Next(10, 100);
                txtGenTextBoxInteger.AppendText((i) + ": " + intArray[i] + Environment.NewLine);
                //MessageBox.Show(Convert.ToString(data1[i]), Convert.ToString(i));
            }
        }

    }
}
