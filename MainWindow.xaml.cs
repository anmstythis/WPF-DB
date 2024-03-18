using System;
using System.Data;
using System.Windows;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using lab1_dataset.neoCorpDataSetTableAdapters;


namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            PageFrame.Content = new DSStaff();

            //TextSource("Введите имя", "Введите фамилию", "Введите отчество", "Введите email");

            //forKey.IsEnabled = true;

            //forKey.ItemsSource = Post.post.GetData();
            //forKey.DisplayMemberPath = "postname";
        }
        //private void TextSource(string one, string two, string three, string four)
        //{
        //    txtbx.Text = one;
        //    txtbx1.Text = two;
        //    txtbx2.Text = three;
        //    txtbx3.Text = four;
        //}

        private void staffButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new DSStaff();

            //TextSource("Введите имя", "Введите фамилию", "Введите отчество", "Введите email");

            //forKey.IsEnabled = true;

            //forKey.ItemsSource = Post.post.GetData();
            //forKey.DisplayMemberPath = "postname";
        }

        private void postButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new DSPost();


            //forKey.IsEnabled = true;

            //TextSource("Введите название должности", string.Empty, string.Empty, string.Empty);

            //forKey.ItemsSource = Corpus.corp.GetData();
            //forKey.DisplayMemberPath = "title";
        }

        private void corpButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new DSCorp();


            //TextSource("Введите название корпуса", "Введите описание специализации", string.Empty, string.Empty);

            //forKey.IsEnabled = false;
        }

        //private void addButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (staffButtonOpened)
        //    {
        //        if (txtbx2.Text == "Введите отчество")
        //        {
        //            Staff.InsertData(txtbx1.Text, txtbx.Text, string.Empty, txtbx3.Text, forKey.SelectedIndex + 1);
        //        }
        //        else
        //        {
        //            Staff.InsertData(txtbx1.Text, txtbx.Text, txtbx2.Text, txtbx3.Text, forKey.SelectedIndex + 1);
        //        }
                
        //        PageFrame.Content = new DSStaff();
        //    }
        //    else if (postButtonOpened)
        //    {
        //        Post.InsertData(txtbx.Text, forKey.SelectedIndex + 1);

        //        PageFrame.Content = new DSPost();
        //    }
        //    else if (corpButtonOpened)
        //    {
        //        Corpus.InsertData(txtbx.Text, txtbx1.Text);

        //        PageFrame.Content = new DSCorp();
        //    }
        //}

        //private void deleteButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (staffButtonOpened)
        //    {
        //        Staff.DeleteData();
        //        PageFrame.Content = new DSStaff();
        //    }
        //    else if (postButtonOpened)
        //    {
        //        PageFrame.Content = new DSPost();
        //    }
        //    else if (corpButtonOpened)
        //    {
        //        Corpus.DeleteData();
        //        PageFrame.Content = new DSCorp();
        //    }
        //}
    }
}
