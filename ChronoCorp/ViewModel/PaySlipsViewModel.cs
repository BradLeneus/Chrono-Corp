using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ChronoCorp.ViewModel
{
    public partial class PaySlipsViewModel : ObservableObject
    {
        private readonly IFichePaieService _fichePaieService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        public ObservableCollection<FichePaie> paySlipsList = new();

        public PaySlipsViewModel(Employee employee, IFichePaieService fichePaieService)
        {
            Employee = employee;
            _fichePaieService = fichePaieService;
            _ = LoadMyPaySlips(employee);
        }

        private async Task LoadMyPaySlips(Employee employee)
        {
            var fichePaieList = await _fichePaieService.GetFichePaieListByEmployeeId(employee.Id);
            paySlipsList = new ObservableCollection<FichePaie>(fichePaieList);
        }


        //Implémenter ReadMyPaySlips()
           public async Task ReadMyPaySlips(Employee employee)
        {

        }


       


    }
}
