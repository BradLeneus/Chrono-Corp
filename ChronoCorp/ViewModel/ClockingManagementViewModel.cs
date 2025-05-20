using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

            [ObservableProperty]
            private CeduleQuart selectedCeduleQuart;

            public IRelayCommand ApprovePointageCommand { get; }

            public ClockingManagementViewModel(ICeduleQuartService ceduleQuartService)
            {
                _ceduleQuartService = ceduleQuartService;
                ApprovePointageCommand = new RelayCommand(ApprovePointage);
                _ = LoadShiftAndClockingToApprove();
            }

            // ajouter filtre date?
            public async Task LoadShiftAndClockingToApprove()
            {
                var shiftList = await _ceduleQuartService.GetAllCeduleQuartAsync();
                ShiftClockToApproveList = new ObservableCollection<CeduleQuart>(shiftList);
            }

            private async void ApprovePointage()
            {
                if (SelectedCeduleQuart != null)
                {
                    SelectedCeduleQuart.IsPointageApprouve = true;
                    try
                    {
                        await _ceduleQuartService.UpdateCeduleQuartAsync(SelectedCeduleQuart);
                        await LoadShiftAndClockingToApprove();
                    }
                    catch (Exception ex)
                    {
                        // Optionally handle exception, e.g., log or notify user
                    }
                }
            }
        }
}
