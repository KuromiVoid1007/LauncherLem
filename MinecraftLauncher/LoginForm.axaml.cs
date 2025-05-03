using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MinecraftLauncherLem.ViewModels;

namespace MinecraftLauncherLem;

public partial class LoginForm : Window
{
    public LoginForm()
    {
        InitializeComponent();
        DataContext = new LoginFormViewModel(Close);
    }
    
}