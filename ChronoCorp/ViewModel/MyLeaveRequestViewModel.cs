using ChronoCorp.Model;
using ChronoCorp.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChronoCorp.ViewModel
{
    public partial class MyLeaveRequestViewModel : ObservableObject
    {
        private readonly User _user;

        [ObservableProperty]
        private object currentLeaveView;

        public MyLeaveRequestViewModel(User user)
        {
            _user = user;

            CurrentLeaveView = new CheckLeaveStatusView
            {
                DataContext = new CheckLeaveStatusViewModel(_user)
            };
        }

        [RelayCommand]
        private void OpenNewLeaveRequestView()
        {
            CurrentLeaveView = new NewLeaveView
            {
                DataContext = new NewLeaveViewModel(_user)
            };
        }
    }

}
