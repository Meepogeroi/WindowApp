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

namespace WindowAppWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageForModer.xaml
    /// </summary>
    public partial class PageForModer : Page
    {
        DB db;
        public PageForModer(DB db, Users usr)
        {
            InitializeComponent();
            this.db = db;
            dataView.ItemsSource = db.Users.ToList();
            if(usr.Status == 2)
            {
                ForAdmin.Visibility = Visibility.Hidden;
            }
            else
            {
                BackButtonForModer.Visibility = Visibility.Hidden;
            }
        }

        private void saveChange_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            dataView.ItemsSource = null;
            dataView.ItemsSource = db.Users.ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void BackButtonForModer_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
