using System;
using System.Data;
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
using lab1_dataset.neoCorpDataSetTableAdapters;
using System.Xml.Linq;


namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для DSPost.xaml
    /// </summary>
    public partial class DSPost : Page
    {
        public staffpostTableAdapter post = new staffpostTableAdapter();
        DSCorp Corpus = new DSCorp();
        public DSPost()
        {
            InitializeComponent();
            postGrid.ItemsSource = post.GetData();
            postname.Text = "Введите название должности";
            corpKey.ItemsSource = Corpus.corp.GetData();
            corpKey.DisplayMemberPath = "title";
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (postGrid.SelectedItem as DataRowView).Row[0];
                post.DeleteQuery(Convert.ToInt32(id));
            }
            catch
            {
                MessageBox.Show("Не выбран объект!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                postGrid.ItemsSource = post.GetData();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (postname.Text != "Введите название должности" && corpKey.SelectedItem != null)
            {
                foreach (var item in Corpus.corp.GetData())
                {
                    if (item.title == corpKey.Text)
                    {
                        int idCorp = item.ID_corp;
                        post.InsertQuery(postname.Text, idCorp);
                    }
                }
            }
            postGrid.ItemsSource = post.GetData();
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (postGrid.SelectedItem as DataRowView).Row[0];
                if (postname.Text != "Введите название должности" || corpKey.SelectedItem != null)
                {
                    foreach (var item in Corpus.corp.GetData())
                    {
                        if (item.title == corpKey.Text)
                        {
                            int idCorp = item.ID_corp;
                            if (postname.Text == "Введите название должности")
                            {
                                object text = (postGrid.SelectedItem as DataRowView).Row[1];
                                post.UpdateQuery((string)text, idCorp, Convert.ToInt32(id));
                            }
                            else
                            {
                                post.UpdateQuery(postname.Text, idCorp, Convert.ToInt32(id));
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не выбран объект!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                postGrid.ItemsSource = post.GetData();
            }
        }
    }
}
