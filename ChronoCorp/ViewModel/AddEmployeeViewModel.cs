using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChronoCorp.ViewModel
{
    public partial class AddEmployeeViewModel : ObservableObject
    {
        private readonly IEmployeeService _employeeService;


        [ObservableProperty]
        private string _prenom;

        [ObservableProperty]
        private string _nom;

        [ObservableProperty]
        private DateTime _dateNaissance;

        [ObservableProperty]
        private string? _adresseLigne1;

        [ObservableProperty]
        private string? _ville;

        [ObservableProperty]
        private string? _codePostal;

        [ObservableProperty]
        private string _telephone;

        [ObservableProperty]
        private string _courriel;


        [ObservableProperty]
        private long _id;

        [ObservableProperty]
        private long? _idSuperieur;

        [ObservableProperty]
        private Employee _gestionnaire;

        [ObservableProperty]
        private string _nomComplet;

        [ObservableProperty]
        private string _departement;

        [ObservableProperty]
        private string _poste;

        [ObservableProperty]
        private float _salaire;

        [ObservableProperty]
        private DateTime _dateEmbauche;

        [ObservableProperty]
        private bool _estActif;

        public AddEmployeeViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            Employees = new ObservableCollection<Employee>();

            NewEmployee = new Employee
            {
                Prenom = "",
                Nom = "",
                Courriel = "",
                Telephone = "",
                Departement = "",
                Poste = ""
            };
        }

        public ObservableCollection<Employee> Employees { get; }

        private Employee _newEmployee;
        public Employee NewEmployee
        {
            get => _newEmployee;
            set => SetProperty(ref _newEmployee, value);
        }

        [RelayCommand]
        public async Task SaveAsync()
        {
            await _employeeService.AddNewEmployeeAsync(NewEmployee);
            Employees.Add(NewEmployee);

            NewEmployee = new Employee
            {
                Prenom = "",
                Nom = "",
                Courriel = "",
                Telephone = "",
                Departement = "",
                Poste = ""

            };
        }

    }
}
