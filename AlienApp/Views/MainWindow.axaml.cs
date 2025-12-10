using AlienApp.ViewModels;
using Avalonia.Controls;
using ReactiveUI.Avalonia;

namespace AlienApp.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>

{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}