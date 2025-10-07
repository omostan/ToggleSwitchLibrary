# ToggleSwitchLibrary

A reusable WPF ToggleSwitch control with support for light/dark themes, localization, and accessibility.

## ✨ Features

- Animated toggle switch with sliding knob
- Light and dark theme support
- Optional label with accessibility support
- Localization-ready via `.resx`
- Easy integration into any WPF project
- Packaged as a reusable UserControl
- Sample demo app included

## 📦 Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/omostan/ToggleSwitchLibrary.git

## Usage

To use the ToggleSwitch control in your WPF application, follow these steps:

1. Add a reference to the `ToggleSwitchLibrary` project in your main project.
2. Include the namespace in your XAML file:

   ```xml
   xmlns:tgb="clr-namespace:ToggleSwitchLibrary;assembly=ToggleSwitchLibrary"
   ```

3. Use the `ToggleSwitch` control in your XAML:
   a. with label

   ```xml
   <tgb:ToggleSwitch IsChecked="{Binding IsPreCheckActive}" Label="PreCheck" />
   ```
   b. without label

   ```xml
   <tgb:ToggleSwitch IsChecked="{Binding IsPreCheckActive}" />
   ```

4. Bind the `IsChecked` property to a boolean property in your view model.

## Accessibility Features Included

- AutomationProperties.Name is bound to the label.
- Focusable container for keyboard navigation.
- Optional label for screen readers and clarity.
