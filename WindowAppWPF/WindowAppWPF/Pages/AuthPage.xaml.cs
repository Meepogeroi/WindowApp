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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        DB db;
        public AuthPage()
        {
            InitializeComponent();
            db = new DB();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Users usr = db.Users.Where(element=>element.LoginUser==LoginField.Text && element.PasswordUser == PasswordField.Password).FirstOrDefault();
            this.Cursor = Cursors.Arrow;
            if (usr.Status == 1)
            {
                this.NavigationService.Navigate(new PageForUser(usr));
            }
            else
            {
                this.NavigationService.Navigate(new PageForModer(db, usr));
            }
        }

        private void GoToRegButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage(db));
        }
    }
}
