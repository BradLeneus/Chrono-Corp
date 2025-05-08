using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ChronoCorp.ViewModel
{
    public partial class MyEmployeesViewModel : ObservableObject
    {
        private readonly IEmployeeService _employeeService;

        [ObservableProperty]
        public ObservableCollection<Employee> myEmployees = new();

        [ObservableProperty]
        private Employee employee;

        public MyEmployeesViewModel(Employee employee, IEmployeeService employeeService)
        {
            Employee = employee;
            _employeeService = employeeService;
            _ = LoadMyEmployees();
        }

        public async Task LoadMyEmployees()
        {
            var myEmployeesList = await _employeeService.GetEmployeeListByIdSuperiorAsync(Employee.Id);
            MyEmployees = new ObservableCollection<Employee>(myEmployeesList);
        }
    }
}
