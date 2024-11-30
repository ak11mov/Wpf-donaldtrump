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
    /// Логика взаимодействия для Combobox.xaml
    /// </summary>
    public partial class Combobox : Window
    {
        public Combobox()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            ImageBox.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\akimovSd\Desktop\Без названия (1).png"));
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            ImageBox.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\akimovSd\Desktop\Без названия.png"));
        } 

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            ImageBox.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\akimovSd\Desktop\png-transparent-minecraft-pocket-edition-minecraft-mods-golden-apple-item-food-rectangle-video-game-thumbnail.png"));
        }

    }
}
