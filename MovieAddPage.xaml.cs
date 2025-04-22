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
    /// Логика взаимодействия для MovieAddPage.xaml
    /// </summary>
    public partial class MovieAddPage : Page
    {
        public MovieAddPage()
        {
            InitializeComponent();
        }
        private string imagePath;

        private void SelectImageButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == true)
            {
                imagePath = openFileDialog.FileName;
                // Можно также прочитать файл в byte[] для сохранения в БД
                // ImageData = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void AddMovieButton_Click(object sender, RoutedEventArgs e)
        {
            string title = MovieTitleTextBox.Text;
            string genre = GenreTextBox.Text;
            int year = int.Parse(YearTextBox.Text);
            try
            {
                // Проверка введенных данных
                if (string.IsNullOrWhiteSpace(MovieTitleTextBox.Text))
                {
                    MessageBox.Show("Введите название фильма");
                    return;
                }

                if (string.IsNullOrWhiteSpace(GenreTextBox.Text))
                {
                    MessageBox.Show("Введите жанр фильма");
                    return;
                }

                if (!int.TryParse(YearTextBox.Text, out year) || year < 1888 || year > DateTime.Now.Year + 5)
                {
                    MessageBox.Show("Введите корректный год выпуска");
                    return;
                }

                int newId = AppCon.modeldb.Список_фильмов.Any()
                ? AppCon.modeldb.Список_фильмов.Max(m => m.Id) + 1
                : 1;
                var newMovie = new Список_фильмов()
                {
                    Id = newId,
                    Название_фильма = title,
                    Жанр = genre,
                    Год = year,
                    Изображение = null, // Не храним бинарные данные
                    Путь_к_изображению = imagePath // Добавьте это поле в таблицу БД как varchar(MAX)
                };
                AppCon.modeldb.Список_фильмов.Add(newMovie);
                AppCon.modeldb.SaveChanges();
                MessageBox.Show("Фильм успешно добавлен!");

                // Очистка формы после добавления
                MovieTitleTextBox.Text = "";
                GenreTextBox.Text = "";
                YearTextBox.Text = "";
                imagePath = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении фильма: {ex.Message}");
            }
        }
    }
}
    