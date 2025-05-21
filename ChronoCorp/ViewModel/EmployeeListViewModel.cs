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
    private ObservableCollection<Employee> employees = new();

    public EmployeeListViewModel(Employee employee, IEmployeeService employeeService)
    {
        Employee = employee;
        _employeeService = employeeService;
        _ = LoadAllEmployees();
    }

    public async Task LoadAllEmployees()
    {
        var employeesList = await _employeeService.GetAllEmployeesAsync();
        if (employeesList != null)
        {
            Employees = new ObservableCollection<Employee>(employeesList);
        }
    }
}
