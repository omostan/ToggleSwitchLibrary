using System.ComponentModel;

namespace ToggleSwitchDemoApp.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private bool _isFeatureEnabled;

    public bool IsFeatureEnabled
    {
        get => _isFeatureEnabled;
        set
        {
            _isFeatureEnabled = value;
            OnPropertyChanged(nameof(IsFeatureEnabled));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
