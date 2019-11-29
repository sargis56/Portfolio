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
using System.Collections.ObjectModel;

namespace _300904358_Nahapetyan__ASS2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        List<String> categorys = new List<String>();
        List<String> catBeverage = new List<String>();
        List<String> catAppetizer = new List<String>();
        List<String> catMainCourse = new List<String>();
        List<String> catDessert = new List<String>();
        List<double> prices = new List<double>();
        List<string> itemNames = new List<string>();
        double totalPrice;
        double taxRate = 0.008;
        double totalTax;
        double subTotal;

        public MainWindow()
		{
			InitializeComponent();
            dataGridItems.ItemsSource = items;
            comboBoxCategory.ItemsSource = categorys;

            categorys.Add("Beverage");
            categorys.Add("Appetizer");
            categorys.Add("Main Course");
            categorys.Add("Dessert");

            //Beverages
            addItem("Soda", 1.95, "Beverage");
            addItem("Tea", 1.50, "Beverage");
            addItem("Coffee", 1.25, "Beverage");
            addItem("Mineral Water", 2.95, "Beverage");
            addItem("Juice", 2.50, "Beverage");
            addItem("Milk", 1.50, "Beverage");
            //Appetizers
            addItem("Buffalo Wings", 5.95, "Appetizer");
            addItem("Buffalo Fingers", 6.95, "Appetizer");
            addItem("Potato Skins", 8.95, "Appetizer");
            addItem("Nachos", 8.95, "Appetizer");
            addItem("Mushroom Caps", 10.95, "Appetizer");
            addItem("Shrimp Cocktail", 12.95, "Appetizer");
            addItem("Chips and Salsa", 6.95, "Appetizer");
            //Main Courses
            addItem("Seafood Alfredo", 15.95, "Main Course");
            addItem("Chicken Alfredo", 13.95, "Main Course");
            addItem("Chicken Picatta", 13.95, "Main Course");
            addItem("Turkey Club", 11.95, "Main Course");
            addItem("Lobster Pie", 19.95, "Main Course");
            addItem("Prime Rib", 20.95, "Main Course");
            addItem("Shrimp Scampi", 18.95, "Main Course");
            addItem("Turkey Dinner", 13.95, "Main Course");
            addItem("Stuffed Chicken", 14.95, "Main Course");
            //Desserts
            addItem("Apple Pie", 5.95, "Dessert");
            addItem("Sundae", 3.95, "Dessert");
            addItem("Carrot Cake", 5.95, "Dessert");
            addItem("Mud Pie", 4.95, "Dessert");
            addItem("Apple Crisp", 5.95, "Dessert");

            comboBoxCategory.SelectedIndex = 0;

            comboBoxItemsBeverage.SelectedIndex = 0;
            comboBoxItemsAppetizer.SelectedIndex = 0;
            comboBoxItemsMainCourse.SelectedIndex = 0;
            comboBoxItemsDessert.SelectedIndex = 0;

            comboBoxItemsBeverage.ItemsSource = catBeverage;
            comboBoxItemsAppetizer.ItemsSource = catAppetizer;
            comboBoxItemsMainCourse.ItemsSource = catMainCourse;
            comboBoxItemsDessert.ItemsSource = catDessert;

            comboBoxItemsBeverage.Visibility = Visibility.Collapsed;
            comboBoxItemsAppetizer.Visibility = Visibility.Collapsed;
            comboBoxItemsMainCourse.Visibility = Visibility.Collapsed;
            comboBoxItemsDessert.Visibility = Visibility.Collapsed;

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += update;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0);
            dispatcherTimer.Start();
        }

        private void update(object sender, EventArgs e)
        {
            
            if (comboBoxCategory.Text == "Beverage")
            {
                comboBoxItemsBeverage.Visibility = Visibility.Visible;
                comboBoxItemsAppetizer.Visibility = Visibility.Collapsed;
                comboBoxItemsMainCourse.Visibility = Visibility.Collapsed;
                comboBoxItemsDessert.Visibility = Visibility.Collapsed;
            }
            else if (comboBoxCategory.Text == "Appetizer")
            {
                comboBoxItemsBeverage.Visibility = Visibility.Collapsed;
                comboBoxItemsAppetizer.Visibility = Visibility.Visible;
                comboBoxItemsMainCourse.Visibility = Visibility.Collapsed;
                comboBoxItemsDessert.Visibility = Visibility.Collapsed;
            }
            else if (comboBoxCategory.Text == "Main Course")
            {
                comboBoxItemsBeverage.Visibility = Visibility.Collapsed;
                comboBoxItemsAppetizer.Visibility = Visibility.Collapsed;
                comboBoxItemsMainCourse.Visibility = Visibility.Visible;
                comboBoxItemsDessert.Visibility = Visibility.Collapsed;
            }
            else if (comboBoxCategory.Text == "Dessert")
            {
                comboBoxItemsBeverage.Visibility = Visibility.Collapsed;
                comboBoxItemsAppetizer.Visibility = Visibility.Collapsed;
                comboBoxItemsMainCourse.Visibility = Visibility.Collapsed;
                comboBoxItemsDessert.Visibility = Visibility.Visible;
            }

            if (items.Count >= 1)
            {
                
                foreach (Item item in items)
                {
                    item.Total = item.Price * item.Qty;
                    //totalPrice = totalPrice + item.Total;
                }
                updateTotals();
                labelTotalOutput.Content = totalPrice.ToString("C");
                labelTaxOutput.Content = totalTax.ToString("C");
                labelSubTotalOutput.Content = subTotal.ToString("C");
            }
            else
            {
                labelTaxOutput.Content = "$0.00";
                labelTotalOutput.Content = "$0.00";
                labelSubTotalOutput.Content = "$0.00";
                totalPrice = 0;
            }

            labelTaxPercentOutput.Content = taxRate * 1000 + "%";
            //dataGridItems.Items.Refresh();

        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            //dataGridItems.Items.Remove(dataGridItems.SelectedItem);

            if ((dataGridItems.SelectedIndex == -1) || (dataGridItems.SelectedIndex >= items.Count))
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                items.Remove(items[dataGridItems.SelectedIndex]);
            }

            updateTotals();
        }

        private void buttonOrder_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxCategory.Text == "Beverage")
            {
                items.Add(new Item { StoreItem = comboBoxItemsBeverage.Text, Price = findPrice(comboBoxItemsBeverage.Text), Qty = 1, Total = findPrice(comboBoxItemsBeverage.Text) });
            }
            else if (comboBoxCategory.Text == "Appetizer")
            {
                items.Add(new Item { StoreItem = comboBoxItemsAppetizer.Text, Price = findPrice(comboBoxItemsAppetizer.Text), Qty = 1, Total = findPrice(comboBoxItemsAppetizer.Text) });
            }
            else if (comboBoxCategory.Text == "Main Course")
            {
                items.Add(new Item { StoreItem = comboBoxItemsMainCourse.Text, Price = findPrice(comboBoxItemsMainCourse.Text), Qty = 1, Total = findPrice(comboBoxItemsMainCourse.Text) });
            }
            else if (comboBoxCategory.Text == "Dessert")
            {
                items.Add(new Item { StoreItem = comboBoxItemsDessert.Text, Price = findPrice(comboBoxItemsDessert.Text), Qty = 1, Total = findPrice(comboBoxItemsDessert.Text) });
            }
            updateTotals();

        }

        private void addItem (string name, double price, string category)
        {
            if (category == "Beverage")
            {
                catBeverage.Add(name);
            }
            else if (category == "Appetizer")
            {
                catAppetizer.Add(name);
            }
            else if (category == "Main Course")
            {
                catMainCourse.Add(name);
            }
            else if (category == "Dessert")
            {
                catDessert.Add(name);
            }
            itemNames.Add(name);
            prices.Add(price);
        }

        private double findPrice (string itemName)
        {
            int priceIndex = itemNames.FindIndex(x => x.StartsWith(itemName));

            return prices[priceIndex];
        }

        private void buttonClearBill_Click(object sender, RoutedEventArgs e)
        {
            items.Clear();
        }

        private void logoBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "www.centennialcollege.ca");
        }

        private void updateTotals()
        {
            totalPrice = 0;
            foreach (Item item in items)
            {
                totalPrice = totalPrice + item.Total;
            }

            totalTax = totalPrice * taxRate;
            subTotal = totalPrice + totalTax;
        }

        private void dataGridItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
