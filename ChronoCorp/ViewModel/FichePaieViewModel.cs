using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class FichePaieViewModel : BaseViewModel
    {
        private readonly FichePaie _model;

        [ObservableProperty]
        private long _id;

        [ObservableProperty]
        private long _idEmployee;

        [ObservableProperty]
        private DateTime _dateDebut;

        [ObservableProperty]
        private DateTime _dateFin;

        [ObservableProperty]
        private float _montant;

        [ObservableProperty]
        private float _nbrHeure;

        [ObservableProperty]
        private float _vacanceCumul;

        [ObservableProperty]
        private DateTime _datePaie;

        public FichePaieViewModel(FichePaie model)
        {
            _model = model;
            _id = model.Id;
            _idEmployee = model.IdEmployee;
            _dateDebut = model.DateDebut;
            _dateFin = model.DateFin;
            _montant = model.Montant;
            _nbrHeure = model.NbrHeure;
            _vacanceCumul = model.VacanceCumul;
            _datePaie = model.DatePaie;
        }
    }
}
