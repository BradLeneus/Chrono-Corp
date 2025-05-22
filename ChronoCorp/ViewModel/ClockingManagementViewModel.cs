using ChronoCorp.Interface;
using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ChronoCorp.ViewModel
{
    public partial class ClockingManagementViewModel : ObservableObject
    {
        private readonly ICeduleQuartService _ceduleQuartService;
        private readonly IFichePaieService _fichePaieService;

        [ObservableProperty]
        private ObservableCollection<CeduleQuart> shiftClockToApproveList = new();

        [ObservableProperty]
        private CeduleQuart selectedCeduleQuart;

        public IRelayCommand ApprovePointageCommand { get; }
        public IRelayCommand AppliquerCommand { get; }

        private readonly float tauxHoraire = 15.0f;

        public ClockingManagementViewModel(ICeduleQuartService ceduleQuartService, IFichePaieService fichePaieService)
        {
            _ceduleQuartService = ceduleQuartService;
            _fichePaieService = fichePaieService;

            ApprovePointageCommand = new RelayCommand(ApprovePointage);
            AppliquerCommand = new RelayCommand(async () => await Appliquer());

            _ = LoadShiftAndClockingToApprove();
        }

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
                await _ceduleQuartService.UpdateCeduleQuartAsync(SelectedCeduleQuart);
                await LoadShiftAndClockingToApprove();
            }
        }

        private async Task Appliquer()
        {
            DateTime dateFin = DateTime.Now;
            DateTime dateDebut = dateFin.AddDays(-7);

            var pointages = ShiftClockToApproveList
                .Where(q => q.IsPointageApprouve
                            && q.HeureEntree.HasValue
                            && q.HeureEntree.Value >= dateDebut
                            && q.HeureEntree.Value <= dateFin)
                .GroupBy(q => q.IdEmployee);

            foreach (var group in pointages)
            {
                double heuresTotal = 0;

                foreach (var shift in group)
                {
                    if (shift.HeureEntree.HasValue && shift.HeureDepart.HasValue)
                    {
                        heuresTotal += (shift.HeureDepart.Value - shift.HeureEntree.Value).TotalHours;
                    }
                }

                double montantTotal = heuresTotal * tauxHoraire;

                var fichePaie = new FichePaie
                {
                    IdEmployee = (int)group.Key,
                    DateDebut = dateDebut,
                    DateFin = dateFin,
                    NbrHeure = (float)heuresTotal,
                    Montant = (float)montantTotal,
                    VacanceCumul = 0, // Ne Marche pas pour l'instant!
                    DatePaie = dateFin
                };

                await _fichePaieService.InsererFichePaieAsync(fichePaie);
            }
        }
    }
}
