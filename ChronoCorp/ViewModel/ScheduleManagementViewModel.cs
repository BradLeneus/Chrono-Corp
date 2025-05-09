using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ChronoCorp.ViewModel
{
    public partial class ScheduleManagementViewModel : ObservableObject
    {
        private readonly ICeduleQuartService _ceduleQuartService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private ObservableCollection<CeduleQuart> shiftList = new();

        public ScheduleManagementViewModel(ICeduleQuartService ceduleQuartService)
        {
            _ceduleQuartService = ceduleQuartService;
            _ = LoadShiftAndClockingToApprove();
        }

        // ajouter filtre date?
        public async Task LoadShiftAndClockingToApprove()
        {
            var shiftList = await _ceduleQuartService.GetAllCeduleQuartAsync();
            ShiftList = new ObservableCollection<CeduleQuart>(shiftList);
        }
    }
}
