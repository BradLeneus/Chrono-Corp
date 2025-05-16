using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChronoCorp.ViewModel
{
    public partial class NewLeaveViewModel : ObservableObject
    {
        [ObservableProperty]
        private Employee employee;

        /* [ObservableProperty]
        private string typeQuart;

        [ObservableProperty]
        private DateTime dateDebut;

        [ObservableProperty]
        private DateTime dateFin;

        [ObservableProperty]
        private string commentaire;*/

        public NewLeaveViewModel(Employee employee)
        {
            Employee = employee;
            //dateDebut = DateTime.Now;
            //dateFin = DateTime.Now;
        }

        [RelayCommand]
        private void SendLeaveRequest()
        {
            //
        }
    }

    
}
