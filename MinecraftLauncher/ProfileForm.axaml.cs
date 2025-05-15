using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MinecraftLauncherLem;

public partial class ProfileForm : Window
{
    public ProfileForm()
    {
        InitializeComponent();
    }


    private void WebsitePremium_Click(object sender, RoutedEventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "http://176.124.202.23/",
            UseShellExecute = true
        });
    }
}