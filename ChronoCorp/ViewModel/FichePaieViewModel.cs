using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ChronoCorp.ViewModel
{
    public partial class FichePaieViewModel : ObservableObject
    {
        private readonly IFichePaieService _fichePaieService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        public ObservableCollection<FichePaie> fichePaies = new();

        public FichePaieViewModel(Employee employee, IFichePaieService fichePaieService)
        {
            Employee = employee;
            _fichePaieService = fichePaieService;
            _ = LoadMyFichePaie(employee);
        }

        private async Task LoadMyFichePaie(Employee employee)
        {
            var fichePaieList = await _fichePaieService.GetFichePaieListByEmployeeId(employee.Id);
            FichePaies = new ObservableCollection<FichePaie>(fichePaieList);
        }
    }
}
