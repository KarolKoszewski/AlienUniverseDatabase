using System.Collections.ObjectModel;
using AlienUniverseDatabase.Models;

namespace AlienUniverseDatabase.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<FilmySpis> Filmy { get; } = new()
    {
        new FilmySpis()
        {
            
        }
    };
}