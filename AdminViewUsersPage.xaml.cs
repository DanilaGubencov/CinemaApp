using System;
using System.Collections.Generic;
using System.IO;
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

namespace CinemaApp
{
    /// <summary>
    /// Логика взаимодействия для AdminViewUsersPage.xaml
    /// </summary>
    public partial class AdminViewUsersPage : Page
    {
        private List<User> users;
        public AdminViewUsersPage()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = AppCon.modeldb.Список_пользователей.ToList();
            UsersListBox.ItemsSource = users.Select(u => new User
            {
                Id = u.Id,
                Username = u.Логин,
                Password = u.Пароль
            }).ToList();

            if (users.Count == 0)
            {
                MessageBox.Show("Нет зарегистрированных пользователей.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DeleteUser_Button_Click(object sender, RoutedEventArgs e)
        {
            if (UsersListBox.SelectedItem != null)
            {
                var selectedUser = (User)UsersListBox.SelectedItem;
                var userToDelete = AppCon.modeldb.Список_пользователей.FirstOrDefault(u => u.Id == selectedUser.Id);

                if (userToDelete != null)
                {
                    AppCon.modeldb.Список_пользователей.Remove(userToDelete);
                    AppCon.modeldb.SaveChanges();
                    LoadUsers(); // Обновляем список
                    MessageBox.Show("Пользователь удален.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
