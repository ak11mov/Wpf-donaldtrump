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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void TreeViewItem_Selected(object Sender , RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = (TreeViewItem)Sender;
            MessageBox.Show("вы выбрали:" + treeViewItem.Header.ToString(), "выбор БД", MessageBoxButton.OK, MessageBoxImage.Hand);

        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar calendar = (Calendar)sender;
            MessageBox.Show("выбрана дата " + calendar.SelectedDate.Value.ToShortDateString());
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = (DatePicker)sender;
            MessageBox.Show("выбрана дата " + datePicker.SelectedDate.Value.ToShortDateString());
        }
    }
}
