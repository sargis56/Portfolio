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
using System.Data.Entity;
using System.Data;
using BaseballTable;
namespace DisplayPlayerTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseballEntities dbContext = new BaseballEntities();

        public MainWindow()
        {
            InitializeComponent();

            dbContext.Players.OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            playerDataGrid.ItemsSource = dbContext.Players.Local;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DisplayPlayerTable.BaseballDataSet baseballDataSet = ((DisplayPlayerTable.BaseballDataSet)(this.FindResource("baseballDataSet")));
            // Load data into the table Players. You can modify this code as needed.
            DisplayPlayerTable.BaseballDataSetTableAdapters.PlayersTableAdapter baseballDataSetPlayersTableAdapter = new DisplayPlayerTable.BaseballDataSetTableAdapters.PlayersTableAdapter();
            baseballDataSetPlayersTableAdapter.Fill(baseballDataSet.Players);
            System.Windows.Data.CollectionViewSource playersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("playersViewSource")));
            playersViewSource.View.MoveCurrentToFirst();
            System.Windows.Data.CollectionViewSource playerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("playerViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // playerViewSource.Source = [generic data source]
        }

        private void playerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            var type = textBoxLastName.Text;

            playerDataGrid.ItemsSource = from p in dbContext.Players.Local
                  where p.LastName.EndsWith(type) || p.LastName.StartsWith(type)
                  orderby p.LastName
                  select p;

            //playerDataGrid.ItemsSource = dbContext.Players.Local;
        }

        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {
            dbContext.Players.OrderBy(players => players.LastName)
            .ThenBy(players => players.FirstName)
            .Load();

            playerDataGrid.ItemsSource = dbContext.Players.Local;
        }
    }
}
