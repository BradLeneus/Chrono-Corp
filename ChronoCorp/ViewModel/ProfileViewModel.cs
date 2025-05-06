using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class ProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string role;

        public ProfileViewModel(User user)
        {
            Username = user.Username;
            Role = user.Role;
        }
    }
}