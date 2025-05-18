using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace ChronoCorp.ViewModel
{
    public partial class NewLeaveViewModel : ObservableObject
    {
        private readonly IDemandeCongeService _demandeCongeService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private int typeQuart;

        [ObservableProperty]
        private DateTime dateDebut = DateTime.Now;

        [ObservableProperty]
        private DateTime dateFin = DateTime.Now;

        [ObservableProperty]
        private string commentaire;

        public NewLeaveViewModel(Employee employee, IDemandeCongeService demandeCongeService)
        {
            Employee = employee;
            _demandeCongeService = demandeCongeService;
        }

        [RelayCommand]
        private async Task SendLeaveRequest()
        {
            if (DateFin < DateDebut)
            {
                MessageBox.Show("La date de fin doit être supérieure ou égale à la date de début.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (TypeQuart == 0)
            {
                MessageBox.Show("Veuillez spécifier le type de la demande.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var demande = new DemandeConge
            {
                IdEmetteur = Employee.Id,
                IdDestinataire = Employee.IdSuperieur ?? 0,
                TempsSoumission = DateTime.Now,
                DateDebut = DateDebut,
                DateFin = DateFin,
                TypeQuart = TypeQuart,
                Commentaire = Commentaire ?? string.Empty,
                EstApprouve = null,
                Reponse = null,
                TempsModif = null
            };

            try
            {
                await _demandeCongeService.AddDemandeCongeAsync(demande);
                MessageBox.Show("Demande de congé envoyée avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                // Optionally clear form or navigate away
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'envoi de la demande : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
