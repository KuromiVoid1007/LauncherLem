using CommunityToolkit.Mvvm.Input;
using MinecraftLauncherLem;

namespace MinecraftLauncherLem.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {



        public string Greeting { get; } = "Welcome to Avalonia!";



        [RelayCommand]
        private void OpenProfile()
        {
            var profileWindow = new ProfileForm();
            profileWindow.Show();
        }

    }
}
