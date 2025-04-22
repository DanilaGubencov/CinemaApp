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
    /// Логика взаимодействия для PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {
        public PaymentPage(string userName, string rowNumber, string seatNumber, int price)
        {
            InitializeComponent();
            UserNameTextBlock.Text = $"Имя пользователя: {userName}"; // Имя пользователя
            SeatInfoTextBlock.Text = $"Выбранное место: {rowNumber}, Место {seatNumber}"; // Выбранный ряд и место
            PriceTextBlock.Text = $"Цена: {price} руб."; // Цена
        }
        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            // Здесь добавить логику для обработки платежа
            MessageBoxResult result = MessageBox.Show("Спасибо за покупку! Удачного просмотра!", "Оплата завершена", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                Manager2.MainFrame2.Navigate(new MovieListPage("User"));
            }
        }
    }
}

