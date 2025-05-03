using CommunityToolkit.Mvvm.Input;
using MinecraftLauncherLem;

namespace MinecraftLauncherLem.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {



        public string Greeting { get; } = "Welcome to Avalonia!";

        [RelayCommand]
        private void OpenLogin()
        {
            var loginWindow = new LoginForm();
            loginWindow.Show();
        }

        [RelayCommand]
        private void OpenRegistration()
        {
            var registrationWindow = new RegistrationForm();
            registrationWindow.Show();
        }

        [RelayCommand]
        private void OpenProfile()
        {
            var profileWindow = new ProfileForm();
            profileWindow.Show();
        }

    }
}
