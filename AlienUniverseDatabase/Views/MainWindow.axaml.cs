using AlienUniverseDatabase.Models;
using AlienUniverseDatabase.ViewModels;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AlienUniverseDatabase.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void DodajFilm_Click(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void UsunFilm_Click(object? sender, RoutedEventArgs e)
    {
        if (FilmyListBox.SelectedItem is FilmySpis selectedFilm && DataContext is MainWindowViewModel viewM)
        {
            viewM.FilmySpisList.Remove(selectedFilm);
        }
    }
}