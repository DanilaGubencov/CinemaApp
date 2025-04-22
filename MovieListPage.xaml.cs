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
    /// Логика взаимодействия для MovieListPage.xaml
    /// </summary>
    public partial class MovieListPage : Page
    {
        private readonly string _role;

        public MovieListPage(string role)
        {
            InitializeComponent();
            _role = role;
            DeleteButton.Visibility = role == "admin" ? Visibility.Visible : Visibility.Collapsed;
            SelectButton.Visibility = role != "admin" ? Visibility.Visible : Visibility.Collapsed;
            LoadMovies();
        }

        private void LoadMovies()
        {
            MoviesListBox.Items.Clear();
            var movies = AppCon.modeldb.Список_фильмов.ToList();
            foreach (var movie in movies)
            {
                MoviesListBox.Items.Add(new Movie
                {
                    Id = movie.Id,
                    Title = movie.Название_фильма,
                    Genre = movie.Жанр,
                    Year = (int)movie.Год,
                    ImagePath = movie.Путь_к_изображению // Просто строка с путем
                });
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MoviesListBox.SelectedItem != null)
            {
                var selectedMovie = (Movie)MoviesListBox.SelectedItem;

                // Находим фильм в базе данных по ID
                var movieToDelete = AppCon.modeldb.Список_фильмов.FirstOrDefault(m => m.Id == selectedMovie.Id);

                if (movieToDelete != null)
                {
                    // Удаляем фильм из базы данных
                    AppCon.modeldb.Список_фильмов.Remove(movieToDelete);

                    try
                    {
                        // Сохраняем изменения в базе данных
                        AppCon.modeldb.SaveChanges();

                        // Удаляем фильм из ListBox
                        MoviesListBox.Items.Remove(selectedMovie);

                        MessageBox.Show($"Фильм '{selectedMovie.Title}' удален.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении фильма: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите фильм для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            if (MoviesListBox.SelectedItem != null)
            {
                var selectedMovie = (Movie)MoviesListBox.SelectedItem;
                Manager2.MainFrame2.Navigate(new SeatSelectionPage(selectedMovie.Title));
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите фильм.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}