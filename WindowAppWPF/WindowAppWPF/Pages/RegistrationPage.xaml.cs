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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        DB db;
        public RegistrationPage(DB db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginField.Text.Length > 0 && PasswordField.Password.Length > 0)
                {
                this.Cursor = Cursors.Wait;
                    Users usr = new Users()
                    {
                        LoginUser = LoginField.Text,
                        PasswordUser = PasswordField.Password,
                        Status = 1,
                        DateRegistration = DateTime.Now
                    };
                    db.Users.Add(usr);
                    db.SaveChanges();
                this.Cursor = Cursors.Arrow;
                    this.NavigationService.GoBack();
                }
            else
            {
                MessageBox.Show("Не указан логин или пароль");
            }
        }
    }
}
