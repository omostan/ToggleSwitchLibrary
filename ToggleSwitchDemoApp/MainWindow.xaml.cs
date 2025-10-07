using System.Windows;
using ToggleSwitchDemoApp.ViewModels;

namespace ToggleSwitchDemoApp;

public partial class MainWindow : Window
{
    private const string BaseUri = "pack://application:,,,/ToggleSwitchLibrary;component/Themes";

    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }

    private void DarkTheme_Click(object sender, RoutedEventArgs e)
    {
        SwitchTheme("Dark");
    }

    private void LightTheme_Click(object sender, RoutedEventArgs e)
    {
        SwitchTheme("Light");
    }

    private void SwitchTheme(string theme)
    {
        var uri = new Uri($"{BaseUri}/{theme}.xaml");
        ResourceDictionary appTheme = new() { Source = uri };
        Application.Current.Resources.Clear();
        Application.Current.Resources.MergedDictionaries.Add(appTheme);
    }
}