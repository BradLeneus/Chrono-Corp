using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class MessagerieViewModel : BaseViewModel
    {
        private readonly Messagerie _model;

        [ObservableProperty]
        private long _id;

        [ObservableProperty]
        private long _idEmetteur;

        [ObservableProperty]
        private long _idDestinataire;

        [ObservableProperty]
        private string _typeMessage;

        [ObservableProperty]
        private string _contenu;

        [ObservableProperty]
        private DateTime _temps;
        
        public MessagerieViewModel(Messagerie model)
        {
            _model = model;
            _id = model.Id;
            _idEmetteur = model.IdEmetteur;
            _idDestinataire = model.IdDestinataire;
            _typeMessage = model.TypeMessage;
            _contenu = model.Contenu;
            _temps = model.Temps;
        }



    }
}
