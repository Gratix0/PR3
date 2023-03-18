using System;
using System.Collections.Generic;
using System.Data;
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
using PR1.PostOfficeDataSetTableAdapters;

namespace PR1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OfficeTableAdapter TableOffice = new OfficeTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            AllDataO.ItemsSource = TableOffice.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object id_O = (AllDataO.SelectedItem as DataRowView).Row[0];
            TableOffice.DeleteQuery(Convert.ToInt32(id_O));
        }
        //}
    }
}
