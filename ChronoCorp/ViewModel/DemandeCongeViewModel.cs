using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class DemandeCongeViewModel : BaseViewModel
    {
        private readonly DemandeConge _model;

        [ObservableProperty]
        private long _id;

        [ObservableProperty]
        private long _idEmetteur;

        [ObservableProperty]
        private long _idDestinateur;

        [ObservableProperty]
        private DateTime _tempsSoumission;

        [ObservableProperty]
        private DateTime _dateDebut;

        [ObservableProperty]
        private DateTime _dateFin;

        [ObservableProperty]
        private int _typeQuart;

        [ObservableProperty]
        private string _commentaire;

        [ObservableProperty]
        private string? _reponse;

        [ObservableProperty]
        private bool? _estApprouve;

        [ObservableProperty]
        private DateTime? _tempsModif;

        public DemandeCongeViewModel(DemandeConge model)
        {
            _model = model;
            _id = model.Id;
            _idEmetteur = model.IdEmetteur;
            _idDestinateur = model.IdDestinataire;
            _tempsSoumission = model.TempsSoumission;
            _dateDebut = model.DateDebut;
            _dateFin = model.DateFin;
            _typeQuart = model.TypeQuart;
            _commentaire = model.Commentaire;
            _reponse = model.Reponse;
            _estApprouve = model.EstApprouve;
            _tempsModif = model.TempsModif;
        }
    }
}
