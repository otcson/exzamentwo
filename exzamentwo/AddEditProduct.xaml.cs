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
    /// Логика взаимодействия для AddEditProduct.xaml
    /// </summary>
    public partial class AddEditProduct : Window
    {
        private static Products _products;
        public AddEditProduct(Products products)
        {
            InitializeComponent();
            if (products != null)
            {
                _products = products;
            }
            DataContext = _products;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            exzamenEntities.GetContext().Products.Add(_products);
            exzamenEntities.GetContext().SaveChanges();
            Product product = new Product();
            product.Show();
            Hide();
        }
    }
}
