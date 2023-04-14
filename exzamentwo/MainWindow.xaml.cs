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

namespace exzamentwo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonVhod_Click(object sender, RoutedEventArgs e)
        {
            Product product   = new Product();

            string login = TextBoxLogin.Text.Trim();
            string password = Password.Password.Trim();
            Accounts accounts = null;
            accounts = exzamenEntities.GetContext().Accounts.Where(d => d.Login == login && d.Password == password).FirstOrDefault();
            if (accounts != null)
            {
                product.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Такого пользователя нет.", "Ошибка");
            }
           
           
        }
    }
}
