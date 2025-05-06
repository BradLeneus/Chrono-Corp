using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class CheckLeaveStatusViewModel : ObservableObject
    {
        private readonly User _user;

        public CheckLeaveStatusViewModel(User user)
        {
            _user = user;
            //dateDebut = DateTime.Now;
            //dateFin = DateTime.Now;
        }
    }
}
