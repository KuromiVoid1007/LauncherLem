using Avalonia.Controls;
using Avalonia.Interactivity;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;
using MinecraftLauncherLem;
using System;

namespace MinecraftLauncherLem.Views
{
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }
        private async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            StartMinecraftLem();
        }
        private void LoginButton_Click(object? sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginForm();
            loginWindow.Show();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e) 
        { 
            var registrationWindow = new RegistrationForm();
            registrationWindow.Show();
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            var profileWindow = new ProfileForm();
            profileWindow.Show();
        }


        private async void StartMinecraftLem()
        {
            var launcher = new MinecraftLauncher();
            var process = await launcher.InstallAndBuildProcessAsync("1.21", new MLaunchOption());
            process.Start();
        }
       
    }

}
