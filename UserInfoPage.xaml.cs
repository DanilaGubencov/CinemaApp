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

namespace CinemaApp
{
    /// <summary>
    /// Логика взаимодействия для UserInfoPage.xaml
    /// </summary>
    public partial class UserInfoPage : Page
    {
        private string rowNumber;
        private string seatNumber;
        private int price;
        public UserInfoPage(string rowNumber, string seatNumber, int price)
        {
            InitializeComponent();
            this.rowNumber = rowNumber;
            this.seatNumber = seatNumber;
            this.price = price;

            // Отображаем информацию о выбранном месте и цене
            SeatInfoTextBlock.Text = $"Выбранное место: {rowNumber}, Место {seatNumber}";
            PriceTextBlock.Text = $"Цена: {price} руб.";
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;

            // Проверяем, что поля не пустые
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Открываем окно оплаты и передаем данные
            Manager2.MainFrame2.Navigate(new PaymentPage($"{firstName} {lastName}", rowNumber, seatNumber, price));
        }
    }
}
