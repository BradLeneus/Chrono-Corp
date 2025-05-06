using ChronoCorp.Data;
using ChronoCorp.Model;
using ChronoCorp.Service;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;

namespace ChronoCorp.ViewModel
{
    public partial class MyEmployeesViewModel : BaseViewModel
    {
        private readonly EmployeeService _employeeService;

        [ObservableProperty]
        public ObservableCollection<Employee> myEmployees = new();

        [ObservableProperty]
        private Employee employee;

        public MyEmployeesViewModel(Employee employee)
        {
            var dataProvider = new EmployeeDataProvider();
            _employeeService = new EmployeeService(dataProvider);
            Employee = employee;
            _ = LoadMyEmployees();
        }

        public async Task LoadMyEmployees()
        {
            var myEmployeesList = await _employeeService.GetEmployeeListByIdSuperiorAsync(Employee.Id);
            MyEmployees = new ObservableCollection<Employee>(myEmployeesList);
        }
    }
}
