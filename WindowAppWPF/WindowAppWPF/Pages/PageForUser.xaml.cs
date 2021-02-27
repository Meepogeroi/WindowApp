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
    /// Логика взаимодействия для PageForUser.xaml
    /// </summary>
    public partial class PageForUser : Page
    {
        Users usr;
        public PageForUser(Users usr)
        {
            InitializeComponent();
            this.usr = usr;
            text.Text = $"Hello, {usr.LoginUser}\n" +
                $"You`r password: {usr.PasswordUser}\n" +
                $"Registration time: {usr.DateRegistration}\n" +
                $"Status: {usr.StatusUser.Status}";
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
