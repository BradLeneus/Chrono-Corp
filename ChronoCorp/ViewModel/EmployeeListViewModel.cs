using CommunityToolkit.Mvvm.ComponentModel;
using ChronoCorp.Model;
using ChronoCorp.Interface;
using System.Collections.ObjectModel;

public partial class EmployeeListViewModel : ObservableObject
{
    private readonly IEmployeeService _employeeService;

    [ObservableProperty]
    private Employee employee;

    [ObservableProperty]
    public ObservableCollection<Employee> employees = new();

    public EmployeeListViewModel(Employee employee, IEmployeeService employeeService)
    {
        _employeeService = employeeService;
        _ = LoadAllEmployees();
    }

    private async Task LoadAllEmployees()
    {
        var employeesList = await _employeeService.GetAllEmployeesAsync();
        Employees = new ObservableCollection<Employee>(employeesList);
    }
}
