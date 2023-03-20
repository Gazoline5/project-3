using Lab6Fomina.Model;
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

namespace Lab6Fomina.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private Users user = new Users();
        public RegisterPage()
        {
            InitializeComponent();

            DataContext = user;
        }

        private void RegisterBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dfominaEntities.GetContext().Users.FirstOrDefault(x => x.Email == user.Email) == null)
                {
                    user.IDSecretQuestion = 1;

                    MessageBox.Show(Manager.PrintProperties(user));

                    dfominaEntities.GetContext().Users.Add(user);
                    dfominaEntities.GetContext().SaveChanges();

                    MessageBox.Show("Успех!", "Успех!");

                    Manager.MainFrame.Navigate(new LoginPage());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.ToString(), "Ошибка!");
            }
        }
    }
}
