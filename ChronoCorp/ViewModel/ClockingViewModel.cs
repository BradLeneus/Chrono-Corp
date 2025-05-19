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
    public partial class ClockingViewModel : ObservableObject
    {
        private readonly ICeduleQuartService _ceduleQuartService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private ObservableCollection<CeduleQuart> shiftToClockList = new();

        [ObservableProperty]
        private CeduleQuart selectedCeduleQuart;

        public IRelayCommand SetHeureEntreeNowCommand { get; }
        public IRelayCommand SetHeureDepartNowCommand { get; }
        public IRelayCommand SaveCedulePointageCommand { get; }

        public ClockingViewModel(Employee employee, ICeduleQuartService ceduleQuartService)
        {
            _ceduleQuartService = ceduleQuartService;
            Employee = employee;
            SetHeureEntreeNowCommand = new RelayCommand(SetHeureEntreeNow);
            SetHeureDepartNowCommand = new RelayCommand(SetHeureDepartNow);
            SaveCedulePointageCommand = new RelayCommand(async () => await SaveCedulePointageAsync());
            _ = LoadMyShiftToClock(employee);
        }

        public async Task LoadMyShiftToClock(Employee employee)
        {
            var shiftList = await _ceduleQuartService.GetQuartListByEmployeeId(employee.Id);
            ShiftToClockList = new ObservableCollection<CeduleQuart>(shiftList);
        }

        private void SetHeureEntreeNow()
        {
            if (SelectedCeduleQuart != null)
            {
                SelectedCeduleQuart.HeureEntree = DateTime.Now;
                OnPropertyChanged(nameof(SelectedCeduleQuart));
            }
        }

        private void SetHeureDepartNow()
        {
            if (SelectedCeduleQuart != null)
            {
                SelectedCeduleQuart.HeureDepart = DateTime.Now;
                OnPropertyChanged(nameof(SelectedCeduleQuart));
            }
        }

        private async Task SaveCedulePointageAsync()
        {
            if (SelectedCeduleQuart == null)
                return;

            try
            {
                await _ceduleQuartService.UpdateCeduleQuartAsync(SelectedCeduleQuart);
                await LoadMyShiftToClock(Employee);
            }
            catch (Exception ex)
            {
                // Optionally handle exception, e.g., log or notify user
            }
        }
    }
}
