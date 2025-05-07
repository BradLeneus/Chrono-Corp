using ChronoCorp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.ViewModel
{
    public partial class CeduleQuartViewModel : BaseViewModel
    {
        private readonly CeduleQuart _model;

        [ObservableProperty]
        public long _id;

        [ObservableProperty]
        public long _idEmployee;

        [ObservableProperty]
        public long _idCreateur;

        [ObservableProperty]
        public int _typeQuart;

        [ObservableProperty]
        public DateTime _heureDebut;

        [ObservableProperty]
        public DateTime _heureFin;

        public CeduleQuartViewModel(CeduleQuart model)
        {
            _model = model;
            _id = model.Id;
            _idEmployee = model.IdEmployee;
            _typeQuart = model.TypeQuart;
            _heureDebut = model.HeureDebut;
            _heureFin = model.HeureFin;
        }
    }
}
