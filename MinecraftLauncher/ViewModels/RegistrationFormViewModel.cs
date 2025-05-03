using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace MinecraftLauncherLem.ViewModels
{
    internal partial class RegistrationFormViewModel : ViewModelBase
    {
        private readonly Action _closeAction;


        public RegistrationFormViewModel(Action closeAction)
        {
            _closeAction = closeAction;
        }

        [RelayCommand]
        private void Exit()
        {
            _closeAction?.Invoke();
        }
    }
}
