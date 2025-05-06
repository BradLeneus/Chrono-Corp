using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class CedulePointageViewModel : BaseViewModel
    {
        private readonly CedulePointage _model;

        [ObservableProperty]
        private long _id;

        [ObservableProperty]
        private long _idEmployee;

        [ObservableProperty]
        private DateTime _heureDebut;

        [ObservableProperty]
        private DateTime _heureFin;

        [ObservableProperty]
        private bool _isPause;

        public CedulePointageViewModel(CedulePointage model)
        {
            _model = model;
            _id = model.Id;
            _idEmployee = model.IdEmployee;
            _heureDebut = model.HeureDebut;
            _heureFin = model.HeureFin;
            _isPause = model.IsPause;
        }
    }
}
