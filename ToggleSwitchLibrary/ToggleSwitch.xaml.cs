using System.Windows;
using System.Windows.Controls;

namespace ToggleSwitchLibrary;

public partial class ToggleSwitch : UserControl
{
    public ToggleSwitch()
    {
        InitializeComponent();
    }

    public static readonly DependencyProperty IsCheckedProperty =
        DependencyProperty.Register(nameof(IsChecked), typeof(bool), typeof(ToggleSwitch),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }

    public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register(nameof(Label), typeof(string), typeof(ToggleSwitch),
            new PropertyMetadata(string.Empty, OnLabelChanged));

    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }

    private static void OnLabelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (ToggleSwitch)d;
        control.LabelVisibility = string.IsNullOrWhiteSpace(control.Label)
            ? Visibility.Collapsed
            : Visibility.Visible;
    }

    public static readonly DependencyProperty LabelVisibilityProperty =
        DependencyProperty.Register(nameof(LabelVisibility), typeof(Visibility), typeof(ToggleSwitch),
            new PropertyMetadata(Visibility.Collapsed));

    public Visibility LabelVisibility
    {
        get => (Visibility)GetValue(LabelVisibilityProperty);
        set => SetValue(LabelVisibilityProperty, value);
    }
}