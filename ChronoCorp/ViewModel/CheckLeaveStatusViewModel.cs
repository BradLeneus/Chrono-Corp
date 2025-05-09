using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class CheckLeaveStatusViewModel : ObservableObject
    {
        [ObservableProperty]
        private Employee employee;

        public CheckLeaveStatusViewModel(Employee employee)
        {
            Employee = employee;
            //dateDebut = DateTime.Now;
            //dateFin = DateTime.Now;
        }
    }
}
