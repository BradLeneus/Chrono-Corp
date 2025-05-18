using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

namespace ChronoCorp.ViewModel
{
    public partial class MyEmployeesLeaveRequestViewModel : ObservableObject
    {
        private readonly IDemandeCongeService _demandeCongeService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private ObservableCollection<DemandeConge> leaveRequest = new();

        [ObservableProperty]
        private DemandeConge selectedLeaveRequest;

        public MyEmployeesLeaveRequestViewModel(Employee employee, IDemandeCongeService demandeCongeService)
        {
            Employee = employee;
            _demandeCongeService = demandeCongeService;
            _ = LoadMyLeaveRequest(employee);
        }

        private async Task LoadMyLeaveRequest(Employee employee)
        {
            var leaveRequestList = await _demandeCongeService.GetDemandeCongeListByIdDestinataire(employee.Id);
            LeaveRequest = new ObservableCollection<DemandeConge>(leaveRequestList);
        }

        [RelayCommand]
        public async Task ApproveRequest(DemandeConge demande)
        {
            if (demande == null) return;

            demande.EstApprouve = true;
            demande.Reponse = "Votre demande de congé a été approuvée.";
            await UpdateRequest(demande);
        }

        [RelayCommand]
        public async Task RejectRequest(DemandeConge demande)
        {
            if (demande == null) return;

            demande.EstApprouve = false;
            demande.Reponse = "Votre demande de congé a été refusée.";
            await UpdateRequest(demande);
        }

        private async Task UpdateRequest(DemandeConge demande)
        {
            try
            {
                await _demandeCongeService.UpdateDemandeCongeAsync(demande);
                MessageBox.Show("La demande a été mise à jour avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                await LoadMyLeaveRequest(Employee);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour de la demande : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
