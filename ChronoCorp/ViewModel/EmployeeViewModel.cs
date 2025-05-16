using CommunityToolkit.Mvvm.ComponentModel;
using ChronoCorp.Model;

public partial class EmployeeViewModel : ObservableObject
{
    private readonly Employee _model;

    [ObservableProperty]
    private long _id;

    [ObservableProperty]
    private long? _idSuperieur;

    [ObservableProperty]
    private string _prenom;

    [ObservableProperty]
    private string _nom;

    [ObservableProperty]
    private string _courriel;

    [ObservableProperty]
    private string? _adresseLigne1;

    [ObservableProperty]
    private string? _adresseLigne2;

    [ObservableProperty]
    private string? _ville;

    [ObservableProperty]
    private string? _codePostal;

    [ObservableProperty]
    private string _telephone;

    [ObservableProperty]
    private DateTime _dateNaissance;

    [ObservableProperty]
    private string? _contactUrgenceTel;

    [ObservableProperty]
    private string? _contactUrgenceNom;

    [ObservableProperty]
    private DateTime _dateEmbauche;

    [ObservableProperty]
    private string _departement;

    [ObservableProperty]
    private string _poste;

    [ObservableProperty]
    private float _salaire;

    [ObservableProperty]
    private bool _estActif;

    [ObservableProperty]
    private float? _argentGagneTotal;

    [ObservableProperty]
    private float? _nbrHeureTotal;

    [ObservableProperty]
    private float? _nbrHeureConge;

    public EmployeeViewModel(Employee model)
    {
        _model = model;
        _id = model.Id;
        _idSuperieur = model.IdSuperieur;
        _prenom = model.Prenom;
        _nom = model.Nom;
        _courriel = model.Courriel;
        _adresseLigne1 = model.AdresseLigne1;
        _adresseLigne2 = model.AdresseLigne2;
        _ville = model.Ville;
        _codePostal = model.CodePostal;
        _telephone = model.Telephone;
        _dateNaissance = model.DateNaissance;
        _contactUrgenceTel = model.ContactUrgenceTel;
        _contactUrgenceNom = model.ContactUrgenceNom;
        _dateEmbauche = model.DateEmbauche;
        _departement = model.Departement;
        _poste = model.Poste;
        _salaire = model.Salaire;
        _estActif = model.EstActif;
        _argentGagneTotal = model.ArgentGagneTotal;
        _nbrHeureTotal = model.NbrHeureTotal;
        _nbrHeureConge = model.NbrHeureConge;
    }
}
