using System.Collections.Generic;
using System.Linq;
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
        FilmyListBox.SelectionChanged += (sender, e) =>
        {
            if (FilmyListBox.SelectedItem != null)
            {
                var okno = new ekranSzczegółowy()
                {
                    DataContext = FilmyListBox.SelectedItem
                };
                okno.Show();
            }
        };
    }

    private void DodajFilm_Click(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewM)
        {
            int.TryParse(txtRokPremiery.Text, out int rok);
            int.TryParse(txtCzasTrwania.Text, out int czas);
            double.TryParse(txtIMDbOcena.Text, out double ocena);

            List<string> postacie;

            if (string.IsNullOrWhiteSpace(txtPostacie.Text))
            {
                postacie = new List<string>();
            }
            else
            {
                string[] postacieTablica = txtPostacie.Text.Split(',');
                postacie = postacieTablica.Select(p => p.Trim()).ToList();
            }

            var nowyFilm = new FilmySpis
            {
                TytulOrginalny = txtTytulOrginalny.Text,
                TytulPolski = txtTytulPolski.Text,
                RokPremiery = rok,
                Rezyser = txtRezyser.Text,
                Scenariusz = txtScenariusz.Text,
                Gatunek = txtGatunek.Text,
                CzasTrwaniaMinuty = czas,
                IMDbOcenaOd1do10 = ocena,
                Postacie = postacie,
                Statek = txtStatek.Text,
                OpisFabuly = txtOpisFabuly.Text,
                Ciekawostka = txtCiekawostka.Text
            };

            viewM.FilmySpisList.Add(nowyFilm);

            txtTytulOrginalny.Clear();
            txtTytulPolski.Clear();
            txtRokPremiery.Clear();
            txtRezyser.Clear();
            txtScenariusz.Clear();
            txtGatunek.Clear();
            txtCzasTrwania.Clear();
            txtIMDbOcena.Clear();
            txtPostacie.Clear();
            txtStatek.Clear();
            txtOpisFabuly.Clear();
            txtCiekawostka.Clear();
        }
    }

    private void UsunFilm_Click(object? sender, RoutedEventArgs e)
    {
        if (FilmyListBox.SelectedItem is FilmySpis selectedFilm && DataContext is MainWindowViewModel viewM)
        {
            viewM.FilmySpisList.Remove(selectedFilm);
        }
    }
}