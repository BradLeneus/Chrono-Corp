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
        private DateTime? newHeureDebut;

        [ObservableProperty]
        private DateTime? newHeureFin;

        public IRelayCommand AddCedulePointageCommand { get; }
        public IRelayCommand SetHeureDebutNowCommand { get; }
        public IRelayCommand SetHeureFinNowCommand { get; }

        public ClockingViewModel(Employee employee, ICeduleQuartService ceduleQuartService)
        {
            _ceduleQuartService = ceduleQuartService;
            Employee = employee;
            AddCedulePointageCommand = new RelayCommand(async () => await AddCedulePointageAsync());
            SetHeureDebutNowCommand = new RelayCommand(SetHeureDebutNow);
            SetHeureFinNowCommand = new RelayCommand(SetHeureFinNow);
            _ = LoadMyShiftToClock(employee);
        }

        public async Task LoadMyShiftToClock(Employee employee)
        {
            var shiftList = await _ceduleQuartService.GetQuartListByEmployeeId(employee.Id);
            ShiftToClockList = new ObservableCollection<CeduleQuart>(shiftList);
        }

        private async Task AddCedulePointageAsync()
        {
            if (NewHeureDebut == null || NewHeureFin == null)
            {
                return;
            }

            if (NewHeureFin <= NewHeureDebut)
            {
                
                return;
            }

            var newCedule = new CeduleQuart
            {
                IdEmployee = Employee.Id,
                IdCreateur = Employee.Id, 
                TypeQuart = 1, 
                IsPausePayee = false,
                HeureDebut = NewHeureDebut.Value,
                HeureFin = NewHeureFin.Value,
                IsPointageApprouve = false
            };

            try
            {
                await _ceduleQuartService.AddCeduleQuartAsync(newCedule);
                await LoadMyShiftToClock(Employee);

               
                NewHeureDebut = null;
                NewHeureFin = null;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void SetHeureDebutNow()
        {
            NewHeureDebut = DateTime.Now;
        }

        private void SetHeureFinNow()
        {
            NewHeureFin = DateTime.Now;
        }
    }
}
