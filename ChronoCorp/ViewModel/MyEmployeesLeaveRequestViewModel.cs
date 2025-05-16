using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ChronoCorp.ViewModel
{
    public partial class MyEmployeesLeaveRequestViewModel : ObservableObject
    {
        private readonly IDemandeCongeService _demandeCongeService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private ObservableCollection<DemandeConge> leaveRequest = new();

        public MyEmployeesLeaveRequestViewModel(Employee employee, IDemandeCongeService demandeCongeService)
        {
            Employee = employee;
            _demandeCongeService = demandeCongeService;
            _ = LoadMyLeaveRequest(employee);
        }

        private async Task LoadMyLeaveRequest(Employee employee)
        {
            var leaveRequestList = await _demandeCongeService.GetDemandeCongeListByIdDestinataire(employee.Id);
            LeaveRequest = new ObservableCollection<DemandeConge>(leaveRequestList);
        }
    }
}
