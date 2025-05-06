using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class ScheduleViewModel : ObservableObject
    {
        private readonly User _user;

        public ScheduleViewModel(User user)
        {
            _user = user;
        }
    }
}
