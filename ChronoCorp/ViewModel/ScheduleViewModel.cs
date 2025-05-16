using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ChronoCorp.ViewModel
{
    public partial class ScheduleViewModel : ObservableObject
    {
        private readonly ICeduleQuartService _ceduleQuartService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private ObservableCollection<CeduleQuart> myShiftList = new();

        public ScheduleViewModel(Employee employee, ICeduleQuartService ceduleQuartService)
        {
            _ceduleQuartService = ceduleQuartService;
            Employee = employee;
            _ = LoadMyShift(employee);
        }

        // ajouter filtre date?
        public async Task LoadMyShift(Employee employee)
        {
            var shiftList = await _ceduleQuartService.GetQuartListByEmployeeId(employee.Id);
            MyShiftList = new ObservableCollection<CeduleQuart>(shiftList);
        }


        //Implémenter ReadMyShift

        public async Task ReadMyShift(Employee employee) { 
        
        
        }
        


    }
}
