using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.ViewModel
{
    public partial class TypeQuartViewModel : BaseViewModel
    {
        private readonly TypeQuart _model;

        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private string _nom;

        [ObservableProperty]
        private string _code;

        [ObservableProperty]
        public bool _estConge;

        [ObservableProperty]
        public float _tauxMajoration;

        [ObservableProperty]
        public string? _description;

        public TypeQuartViewModel(TypeQuart model)
        {
            _model = model;
            _id = model.Id;
            _nom = model.Nom;
            _code = model.Code;
            _estConge = model.EstConge;
            _tauxMajoration = model.TauxMajoration;
            _description = model.Description;
        }
    }
}
