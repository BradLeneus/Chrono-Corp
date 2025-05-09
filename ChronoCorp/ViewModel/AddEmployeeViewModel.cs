using ChronoCorp.Interface;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.ViewModel
{
    public partial class AddEmployeeViewModel : ObservableObject
    {
        private readonly IEmployeeService _employeeService;

        // [ObservableProperty] pour tous les champs ici :)

        public AddEmployeeViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
    }
}
