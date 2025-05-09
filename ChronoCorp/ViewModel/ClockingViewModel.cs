using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.ViewModel
{
    public partial class ClockingViewModel : ObservableObject
    {
        private readonly ICeduleQuartService _ceduleQuartService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private ObservableCollection<CeduleQuart> shiftToClockList = new();

        public ClockingViewModel(Employee employee, ICeduleQuartService ceduleQuartService)
        {
            _ceduleQuartService = ceduleQuartService;
            Employee = employee;
            _ = LoadMyShiftToClock(employee);
        }

        // ajouter filtre date?
        public async Task LoadMyShiftToClock(Employee employee)
        {
            var shiftList = await _ceduleQuartService.GetQuartListByEmployeeId(employee.Id);
            ShiftToClockList = new ObservableCollection<CeduleQuart>(shiftList);
        }
    }
}
