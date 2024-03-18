using System;
using System.Data;
using System.Globalization;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using lab1_dataset.neoCorpDataSetTableAdapters;

namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для DSCorp.xaml
    /// </summary>
    public partial class DSCorp : Page
    {
        public corpusTableAdapter corp = new corpusTableAdapter();
        public DSCorp()
        {
            InitializeComponent();
            corpGrid.ItemsSource = corp.GetData();
            title.Text = "Введите название корпуса";
            spec.Text = "Введите описание специализации";
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (title.Text != "Введите название корпуса" && spec.Text != "Введите описание специализации")
            {
                corp.InsertQuery(title.Text, spec.Text);
            }
            corpGrid.ItemsSource = corp.GetData();
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (corpGrid.SelectedItem as DataRowView).Row[0];
                if (title.Text == "Введите название корпуса")
                {
                    object text = (corpGrid.SelectedItem as DataRowView).Row[1];
                    corp.UpdateQuery((string)text, spec.Text, Convert.ToInt32(id));
                }
                else if (spec.Text == "Введите описание специализации")
                {
                    object text = (corpGrid.SelectedItem as DataRowView).Row[2];
                    corp.UpdateQuery(title.Text, (string)text, Convert.ToInt32(id));
                }
                else
                {          
                    corp.UpdateQuery(title.Text, spec.Text, Convert.ToInt32(id));
                }
            }
            catch
            {
                MessageBox.Show("Не выбран объект!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                corpGrid.ItemsSource = corp.GetData();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (corpGrid.SelectedItem as DataRowView).Row[0];
                corp.DeleteQuery(Convert.ToInt32(id));
            }
            catch
            {
                MessageBox.Show("Не выбран объект!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                corpGrid.ItemsSource = corp.GetData();
            }
        }
    }
}
