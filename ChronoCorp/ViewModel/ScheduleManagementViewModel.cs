using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class ScheduleManagementViewModel : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging
    {
        private readonly ICeduleQuartService _ceduleQuartService;
        private readonly IEmployeeService _employeeService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private ObservableCollection<CeduleQuart> shiftList = new();


        [ObservableProperty]
        private ObservableCollection<Employee> employees = new();

        [ObservableProperty]
        private Employee selectedEmployee;

        [ObservableProperty]
        private DateTime startDate = DateTime.Now;

        [ObservableProperty]
        private DateTime endDate = DateTime.Now.AddHours(8);

        [ObservableProperty]
        private int typeQuart;

        [ObservableProperty]
        private bool isPausePayee;

        [ObservableProperty]
        private CeduleQuart selectedShift;

        [ObservableProperty]
        private DateTime selectedDate = DateTime.Today;

        [ObservableProperty]
        private TimeSpan selectedTime = DateTime.Now.TimeOfDay;

        public DateTime StartDateTime => SelectedDate.Date + SelectedTime;


        [ObservableProperty]
        private double selectedNbHeuresToCreateEmployeeShift = 8; // Valeur par défaut
        partial void OnSelectedNbHeuresToCreateEmployeeShiftChanged(double value)
        {
            if (value > 12)
                SelectedNbHeuresToCreateEmployeeShift = 12;
            else if (value < 1)
                SelectedNbHeuresToCreateEmployeeShift = 1;
        }


        // Propriété pour l'heure de fin (à lier dans le XAML)
        [ObservableProperty]
        private TimeSpan endTime = DateTime.Now.AddHours(8).TimeOfDay;

        // Propriété calculée pour le nombre d'heures saisi
        public double NbHeuresSaisi
        {
            get
            {
                try
                {
                    var debut = StartDate.Date + SelectedTime;
                    var fin = EndDate.Date + EndTime;
                    var diff = fin - debut;
                    return diff.TotalHours > 0 ? diff.TotalHours : 0;
                }
                catch
                {
                    return 0;
                }
            }
        }


        partial void OnStartDateChanged(DateTime value) => OnPropertyChanged(nameof(NbHeuresSaisi));
        partial void OnEndDateChanged(DateTime value) => OnPropertyChanged(nameof(NbHeuresSaisi));
        partial void OnSelectedTimeChanged(TimeSpan value) => OnPropertyChanged(nameof(NbHeuresSaisi));
        partial void OnEndTimeChanged(TimeSpan value) => OnPropertyChanged(nameof(NbHeuresSaisi));


        //Id du gestionnaire hardcodé

        private long gestionnaireId = 330152;

        public double? SelectedNbHeures => SelectedShift?.NbHeures;


        private Employee _selectedEmployee;




        // Commandes  pour les méthodes
        public IRelayCommand CreateAndAssignShiftCommand => new RelayCommand(async () =>
        {
            await CreateAndAssignShift(SelectedEmployee, StartDate, EndDate, TypeQuart, IsPausePayee);
        });

        public IRelayCommand LoadShiftsForEmployeeCommand => new RelayCommand(async () =>
        {
            await LoadShiftsForEmployee(SelectedEmployee);
        });



        public ScheduleManagementViewModel(ICeduleQuartService ceduleQuartService, IEmployeeService employeeService)
        {
            _ceduleQuartService = ceduleQuartService;
            _employeeService = employeeService;


            employee = new Employee
            {
                Prenom = string.Empty,
                Nom = string.Empty,
                Courriel = string.Empty,
                Telephone = string.Empty,
                Departement = string.Empty,
                Poste = string.Empty
            };
            selectedEmployee = new Employee
            {
                Prenom = string.Empty,
                Nom = string.Empty,
                Courriel = string.Empty,
                Telephone = string.Empty,
                Departement = string.Empty,
                Poste = string.Empty
            };

            _ = LoadEmployees();
            _ = LoadShiftAndClockingToApprove();

        }

        // ajouter filtre date?
        // Peux  seulement créer un shift qui est  sur une journée
        public async Task CreateAndAssignShift(Employee selectedEmployee, DateTime unused1, DateTime unused2, int typeQuart, bool isPausePayee)
        {
            if (selectedEmployee == null) return;

            // Calcule l'heure de début et de fin à partir des propriétés sélectionnées
            DateTime heureDebut = SelectedDate.Date + SelectedTime;
            DateTime heureFin = SelectedDate.Date + EndTime;



            var nouveauQuart = new CeduleQuart
            {
                IdEmployee = selectedEmployee.Id,
                HeureDebut = heureDebut,
                HeureFin = heureFin,
                TypeQuart = typeQuart,
                IsPausePayee = isPausePayee,
                IsPointageApprouve = false,
                IdCreateur = gestionnaireId
            };

            await _ceduleQuartService.AddCeduleQuartAsync(nouveauQuart);
            await LoadShiftAndClockingToApprove();
        }


        public async Task LoadShiftAndClockingToApprove()
        {
            var shiftList = await _ceduleQuartService.GetAllCeduleQuartAsync();
            ShiftList = new ObservableCollection<CeduleQuart>(shiftList);
        }

        public async Task LoadShiftsForEmployee(Employee selectedEmployee)
        {
            if (selectedEmployee == null) return;
            var shifts = await _ceduleQuartService.GetQuartListByEmployeeId(selectedEmployee.Id);
            ShiftList = new ObservableCollection<CeduleQuart>(shifts);
        }

        public async Task LoadEmployees()
        {

            var employees = await _employeeService.GetAllEmployeesAsync();

            Employees = new ObservableCollection<Employee>(employees);
        }

    }
}
