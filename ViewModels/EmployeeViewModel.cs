using ChronoCorp.Models;

public class EmployeeViewModel : BaseViewModel
{
    private readonly employee _model;

    public EmployeeViewModel(employee model)
    {
        _model = model;
    }

    public string Nom
    {
        get => _model.nom;
        set
        {
            if (_model.nom != value)
            {
                _model.nom = value;
                OnPropertyChanged();
            }
        }
    }

    public string Prenom
    {
        get => _model.prenom;
        set
        {
            if (_model.prenom != value)
            {
                _model.prenom = value;
                OnPropertyChanged();
            }
        }
    }
}
