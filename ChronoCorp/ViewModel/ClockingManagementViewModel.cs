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
    public partial class ClockingManagementViewModel : ObservableObject
    {
        private readonly ICeduleQuartService _ceduleQuartService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private ObservableCollection<CeduleQuart> shiftClockToApproveList = new();

        public ClockingManagementViewModel(ICeduleQuartService ceduleQuartService)
        {
            _ceduleQuartService = ceduleQuartService;
            _ = LoadShiftAndClockingToApprove();
        }

        // ajouter filtre date?
        public async Task LoadShiftAndClockingToApprove()
        {
            var shiftList = await _ceduleQuartService.GetAllCeduleQuartAsync();
            ShiftClockToApproveList = new ObservableCollection<CeduleQuart>(shiftList);
        }
    }
}
