﻿using CinemaApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
        }

        private void btAddMovie(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MovieAddPage());          
        }

        private void btListMovie(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MovieListPage("admin"));
        }

        private void btExit(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }

        private void btUsers(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AdminViewUsersPage());
        }
    }
}
