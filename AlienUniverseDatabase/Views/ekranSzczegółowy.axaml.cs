using AlienUniverseDatabase.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AlienUniverseDatabase.Views;

public partial class ekranSzczegółowy : Window
{
    public ekranSzczegółowy(FilmySpis wybranyFilm)
    {
        InitializeComponent();
        DataContext = wybranyFilm;
    }

    private void Postacie_Click(object? sender, RoutedEventArgs e)
    {
        var okno = new EkranPostaci()
        {
            DataContext = "FilmyListBox.SelectedItem"
        };
        okno.Show();
    }
}