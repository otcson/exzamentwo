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

namespace exzamentwo
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        public Product()
        {
            InitializeComponent();
            DataGridProduct.ItemsSource = exzamenEntities.GetContext().Products.ToList();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct(null);
            addEditProduct.Show();
            Hide();
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            var ProductRemoving = DataGridProduct.SelectedItem as Product;
            if (ProductRemoving != null)
            {
                exzamenEntities.GetContext().Products.Remove(ProductRemoving);
            }
        }

    }
}
