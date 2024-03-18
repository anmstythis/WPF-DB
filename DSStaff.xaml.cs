using lab1_dataset.neoCorpDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для DSStaff.xaml
    /// </summary>
    public partial class DSStaff : Page
    {
        staffTableAdapter staff = new staffTableAdapter();
        DSPost Post = new DSPost();
        public DSStaff()
        {
            InitializeComponent();
            staffGrid.ItemsSource = staff.GetData();
            
            surname.Text = "Введите фамилию";
            name.Text = "Введите имя";
            middlename.Text = "Введите отчество";
            email.Text = "Введите email";

            postKey.ItemsSource = Post.post.GetData();
            postKey.DisplayMemberPath = "postname";
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (surname.Text != "Введите фамилию" && name.Text != "Введите имя" && email.Text != "Введите email")
            {
                foreach (var item in Post.post.GetData())
                {
                    if (item.postname == postKey.Text)
                    {
                        int idPost = item.ID_post;
                        if (middlename.Text == "Введите отчество")
                        {
                            staff.InsertQuery(surname.Text, name.Text, string.Empty, email.Text, idPost);
                        }
                        else
                        {
                            staff.InsertQuery(surname.Text, name.Text, middlename.Text, email.Text, idPost);
                        }
                    }
                }
            }

            staffGrid.ItemsSource = staff.GetData();
        }

        //private void SurnameCheck(string name, string middlename, string email, int idPost, object id)
        //{
        //    object surname = (staffGrid.SelectedItem as DataRowView).Row[1];
        //    if (name == "Введите имя")
        //    {
        //        object nametxt = (staffGrid.SelectedItem as DataRowView).Row[2];
        //        staff.UpdateQuery((string)surname, (string)nametxt, middlename, email, idPost, Convert.ToInt32(id));
        //    }
        //    else if (middlename == "Введите отчество")
        //    {
        //        object mid = (staffGrid.SelectedItem as DataRowView).Row[3];
        //        staff.UpdateQuery((string)surname, name, (string)mid, email, idPost, Convert.ToInt32(id));
        //    }
        //    else if (email == "Введите email")
        //    {
        //        object mail = (staffGrid.SelectedItem as DataRowView).Row[4];
        //        staff.UpdateQuery((string)surname, name, middlename, (string)mail, idPost, Convert.ToInt32(id));
        //    }
        //    else if (postKey.SelectedItem == null)
        //    {
        //        object pst = (staffGrid.SelectedItem as DataRowView).Row[5];
        //        staff.UpdateQuery((string)surname, name, middlename, email, (int)pst, Convert.ToInt32(id));
        //    }
        //}

        //private void NameCheck(string surname, string middlename, string email, int idPost, object id)
        //{
        //    object name = (staffGrid.SelectedItem as DataRowView).Row[2];
        //    if (surname == "Введите фамилию")
        //    {
        //        object snametxt = (staffGrid.SelectedItem as DataRowView).Row[1];
        //        staff.UpdateQuery((string)snametxt, (string)name, middlename, email, idPost, Convert.ToInt32(id));
        //    }
        //    else if (middlename == "Введите отчество")
        //    {
        //        object mid = (staffGrid.SelectedItem as DataRowView).Row[3];
        //        staff.UpdateQuery(surname, (string)name, (string)mid, email, idPost, Convert.ToInt32(id));
        //    }
        //    else if (email == "Введите email")
        //    {
        //        object mail = (staffGrid.SelectedItem as DataRowView).Row[4];
        //        staff.UpdateQuery(surname, (string)name, middlename, (string)mail, idPost, Convert.ToInt32(id));
        //    }
        //    else if (postKey.SelectedItem == null)
        //    {
        //        object pst = (staffGrid.SelectedItem as DataRowView).Row[5];
        //        staff.UpdateQuery(surname, (string)name, middlename, email, (int)pst, Convert.ToInt32(id));
        //    }
        //}
        
        //private void MiddleNameCheck(string surname, string name, string email, int idPost, object id)
        //{
        //    object mid = (staffGrid.SelectedItem as DataRowView).Row[3];
        //    if (surname == "Введите фамилию")
        //    {
        //        object snametxt = (staffGrid.SelectedItem as DataRowView).Row[1];
        //        staff.UpdateQuery(surname, name, (string)mid, email, idPost, Convert.ToInt32(id));
        //    }
        //    else if (name == "Введите имя")
        //    {
        //        object nm = (staffGrid.SelectedItem as DataRowView).Row[2];
        //        staff.UpdateQuery(surname, (string)nm, (string)mid, email, idPost, Convert.ToInt32(id));
        //    }
        //    else if (email == "Введите email")
        //    {
        //        object mail = (staffGrid.SelectedItem as DataRowView).Row[4];
        //        staff.UpdateQuery(surname, name, (string)mid, (string)mail, idPost, Convert.ToInt32(id));
        //    }
        //    else if (postKey.SelectedItem == null)
        //    {
        //        object pst = (staffGrid.SelectedItem as DataRowView).Row[5];
        //        staff.UpdateQuery(surname, name, (string)mid, email, (int)pst, Convert.ToInt32(id));
        //    }
        //}

        //private void PostKeyCheck(string surname, string name, string middlename, string email, object id)
        //{
        //    object pst = (staffGrid.SelectedItem as DataRowView).Row[5];
        //    if (surname == "Введите фамилию")
        //    {
        //        object snametxt = (staffGrid.SelectedItem as DataRowView).Row[1];
        //        staff.UpdateQuery((string)snametxt, name, middlename, email, (int)pst, Convert.ToInt32(id));
        //    }
        //    else if (name == "Введите имя")
        //    {
        //        object nm = (staffGrid.SelectedItem as DataRowView).Row[2];
        //        staff.UpdateQuery(surname, (string)nm, middlename, email, (int)pst, Convert.ToInt32(id));
        //    }
        //    else if (middlename == "Введите отчество")
        //    {
        //        object mid = (staffGrid.SelectedItem as DataRowView).Row[3];
        //        staff.UpdateQuery(surname, name, (string)mid, email, (int)pst, Convert.ToInt32(id));
        //    }
        //    else if (email == "Введите email")
        //    {
        //        object mail = (staffGrid.SelectedItem as DataRowView).Row[4];
        //        staff.UpdateQuery(surname, name, middlename, (string)mail, (int)pst, Convert.ToInt32(id));
        //    }
        //}

        //private void EmailCheck(string surname, string name, string middlename, int idPost, object id)
        //{
        //    object mail = (staffGrid.SelectedItem as DataRowView).Row[4];
        //    if (surname == "Введите фамилию")
        //    {
        //        object snametxt = (staffGrid.SelectedItem as DataRowView).Row[1];
        //        staff.UpdateQuery((string)snametxt, name, middlename, (string)mail, idPost, Convert.ToInt32(id));
        //    }
        //    else if (middlename == "Введите отчество")
        //    {
        //        object mid = (staffGrid.SelectedItem as DataRowView).Row[3];
        //        staff.UpdateQuery(surname, name, (string)mid, (string)mail, idPost, Convert.ToInt32(id));
        //    }
        //    else if (name == "Введите имя")
        //    {
        //        object nm = (staffGrid.SelectedItem as DataRowView).Row[2];
        //        staff.UpdateQuery(surname, (string)nm, middlename, (string)mail, idPost, Convert.ToInt32(id));
        //    }
        //    else if (postKey.SelectedItem == null)
        //    {
        //        object pst = (staffGrid.SelectedItem as DataRowView).Row[5];
        //        staff.UpdateQuery(surname, name, middlename, (string)mail, (int)pst, Convert.ToInt32(id));
        //    }
        //}

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (staffGrid.SelectedItem as DataRowView).Row[0];
                foreach (var item in Post.post.GetData() )
                {
                    if (item.postname == postKey.Text)
                    {
                        int idPost = item.ID_post;
                        
                        if (staffGrid.SelectedItem != null)
                        {
                            staff.UpdateQuery(surname.Text, name.Text, middlename.Text, email.Text, idPost, Convert.ToInt32(id));
                        }
                        else
                        {
                            object pst = (staffGrid.SelectedItem as DataRowView).Row[5];
                            staff.UpdateQuery(surname.Text, name.Text, middlename.Text, email.Text, (int)pst, Convert.ToInt32(id));
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
                staffGrid.ItemsSource = staff.GetData();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (staffGrid.SelectedItem as DataRowView).Row[0];
                staff.DeleteQuery(Convert.ToInt32(id));
            }
            catch
            {
                MessageBox.Show("Не выбран объект!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                staffGrid.ItemsSource = staff.GetData();
            }
        }

    }
}
