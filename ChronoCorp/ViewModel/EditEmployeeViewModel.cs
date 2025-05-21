using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace ChronoCorp.ViewModel
{
    public partial class EditEmployeeViewModel : ObservableObject
    {
        private readonly IEmployeeService _employeeService;

        [ObservableProperty]
        private Employee employee;

        public EditEmployeeViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public void LoadEmployee(Employee employee)
        {
            Employee = employee;
        }

        [RelayCommand]
        public async Task SaveAsync()
        {
            await _employeeService.UpdateEmployeeAsync(Employee);
        }
    }
}
