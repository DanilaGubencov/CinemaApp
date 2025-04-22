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
    /// Логика взаимодействия для SeatSelectionPage.xaml
    /// </summary>
    public partial class SeatSelectionPage : Page
    {
        private string userName;
        public SeatSelectionPage(string userName)
        {
            InitializeComponent();
            this.userName = userName; // Сохраняем имя пользователя
            LoadSeats();
        }
        private void LoadSeats()
        {
            var rows = new List<Row>();
            int maxPrice = 500; // Максимальная цена для первого ряда

            for (int i = 0; i < 6; i++) // 7 рядов
            {
                var seats = new List<Seat>();
                for (int j = 1; j <= 12; j++) // 5 мест в каждом ряду
                {
                    int price = maxPrice - (i * 60); // Уменьшаем цену с каждым рядом
                    seats.Add(new Seat { SeatNumber = $"{j}", Price = Math.Max(0, price) }); // Не допускаем отрицательных цен
                }
                rows.Add(new Row { RowNumber = $"Ряд {i + 1}", Seats = seats });
            }

            RowsItemsControl.ItemsSource = rows;
        }

        private void SeatButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            int price = (int)button.Tag; // Получаем цену из Tag
            button.ToolTip = $"Цена: {price} руб."; // Показать цену в подсказке
        }

        private void SeatButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.ToolTip = null; // Убираем подсказку при уходе мыши
        }

        private void SeatButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int price = (int)button.Tag; // Получаем цену из Tag
            string seatNumber = button.Content.ToString(); // Получаем номер места

            // Получаем номер ряда, используя DataContext
            var row = FindParentRow(button);
            string rowNumber = row?.RowNumber ?? "Ряд"; // Получаем номер ряда

            // Открываем окно ввода информации о пользователе
            Manager2.MainFrame2.Navigate(new UserInfoPage(rowNumber, seatNumber, price));

        }
        private Row FindParentRow(Button button)
        {
            // Находим родительский элемент ряда для получения его номера
            var stackPanel = button.Parent as StackPanel;
            while (stackPanel != null && !(stackPanel.DataContext is Row))
            {
                stackPanel = stackPanel.Parent as StackPanel;
            }
            return stackPanel?.DataContext as Row;
        }
    }
}
