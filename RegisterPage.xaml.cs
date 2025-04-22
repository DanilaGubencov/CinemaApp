using CinemaApp._0000;
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
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Проверка существования пользователя
            var existingUser = AppCon.modeldb.Список_пользователей.FirstOrDefault(u => u.Логин == username);
            if (existingUser != null)
            {
                MessageBox.Show("Пользователь уже существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            int newId = AppCon.modeldb.Список_пользователей.Any()
                ? AppCon.modeldb.Список_пользователей.Max(m => m.Id) + 1
                : 1;
            var newUser = new Список_пользователей()
            { 
                Id = newId,
                Логин = username,
                Пароль = password,
                Роль = "User" // Роль по умолчанию
             };

            AppCon.modeldb.Список_пользователей.Add(newUser);
            AppCon.modeldb.SaveChanges();

            MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            Manager2.MainFrame2.Navigate(new LoginPage());
        }
    }
}
           