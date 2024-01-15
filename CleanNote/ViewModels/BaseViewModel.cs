using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNote.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {

        [RelayCommand]
        void GoBack()
        {
            Shell.Current.GoToAsync("..");
        }
    }
}
