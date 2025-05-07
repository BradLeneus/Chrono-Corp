using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class EmployeeCredentialsViewModel : BaseViewModel
    {
        private readonly EmployeeCredentials _model;

        [ObservableProperty]
        private long _id;

        [ObservableProperty]
        private string _mdp;

        [ObservableProperty]
        private string _role;

        public EmployeeCredentialsViewModel(EmployeeCredentials model)
        {
            _model = model;
            _id = model.Id;
            _mdp = model.Mdp;
            _role = model.Role;
        }
    }
}
