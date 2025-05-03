using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MinecraftLauncherLem.ViewModels;

namespace MinecraftLauncherLem;

public partial class RegistrationForm : Window
{
    public RegistrationForm()
    {
        InitializeComponent();
        DataContext = new RegistrationFormViewModel(Close);
    }
}