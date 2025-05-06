using ChronoCorp.Model;

namespace ChronoCorp.Data
{
    public interface IEmployeeDataProvider
    {
        public Task<IEnumerable<Employee>?> GetAllEmployeesAsync();
    }
    public class EmployeeDataProvider : IEmployeeDataProvider
    {
        public async Task<IEnumerable<Employee>?> GetAllEmployeesAsync()
        {
            await Task.Delay(500);

            var employees = new List<Employee>
            {
                new Employee { Id = 330152, Prenom = "Amalee", Nom = "Lombard", Courriel = "alombard0@ning.com", AdresseLigne1 = "8 Linden Hill", AdresseLigne2 = "Room 325", Ville = "Yingcui", Telephone = "2619454579", DateNaissance = new DateTime(2000, 2, 16), ContactUrgenceTel = "3483298657", ContactUrgenceNom = "Amalee Lombard", DateEmbauche = new DateTime(2021, 11, 10), Departement = "Ventes", Poste = "Caissier", Salaire = 17.85f, EstActif = true },
                new Employee { Id = 431999, IdSuperieur = 330152, Prenom = "Hadlee", Nom = "Towers", Courriel = "htowers1@usa.gov", AdresseLigne1 = "9 Dahle Crossing", AdresseLigne2 = "Suite 64", Ville = "Idanre", Telephone = "5991885505", DateNaissance = new DateTime(1990, 5, 30), ContactUrgenceTel = "6901477338", ContactUrgenceNom = "Hadlee Towers", DateEmbauche = new DateTime(2021, 8, 4), Departement = "Marketing", Poste = "Chef de rayon", Salaire = 23.12f, EstActif = true },
                new Employee { Id = 432401, IdSuperieur = 330152, Prenom = "Nona", Nom = "Fillon", Courriel = "nfillon2@wordpress.com", AdresseLigne1 = "66 Spenser Circle", AdresseLigne2 = "Room 1924", Ville = "Vogan", Telephone = "3354048261", DateNaissance = new DateTime(2003, 5, 5), ContactUrgenceTel = "7365638403", ContactUrgenceNom = "Nona Fillon", DateEmbauche = new DateTime(2015, 3, 20), Departement = "Service à la clientèle", Poste = "Conseiller client", Salaire = 19.74f, EstActif = true },
                new Employee { Id = 433753, IdSuperieur = 330152, Prenom = "Lila", Nom = "Tomasoni", Courriel = "ltomasoni3@upenn.edu", AdresseLigne1 = "628 Norway Maple Plaza", AdresseLigne2 = "Suite 70", Ville = "Lazarat", Telephone = "4097371461", DateNaissance = new DateTime(1986, 7, 17), ContactUrgenceTel = "3523333007", ContactUrgenceNom = "Lila Tomasoni", DateEmbauche = new DateTime(2022, 5, 1), Departement = "Logistique", Poste = "Réceptionniste marchandises", Salaire = 22.47f, EstActif = true },
                new Employee { Id = 434212, IdSuperieur = 330152, Prenom = "Adrian", Nom = "Torbeck", Courriel = "atorbeck4@icio.us", AdresseLigne1 = "972 Bluestem Street", AdresseLigne2 = "Suite 66", Ville = "Samho-rodongjagu", Telephone = "4196268115", DateNaissance = new DateTime(2000, 2, 10), ContactUrgenceTel = "8533600489", ContactUrgenceNom = "Adrian Torbeck", DateEmbauche = new DateTime(2023, 11, 15), Departement = "Inventaire", Poste = "Préposé aux stocks", Salaire = 24.99f, EstActif = true },
                new Employee { Id = 435377, IdSuperieur = 330152, Prenom = "Esteban", Nom = "Synnot", Courriel = "esynnot5@pcworld.com", AdresseLigne1 = "298 Briar Crest Pass", AdresseLigne2 = "20th Floor", Ville = "Yangchun", Telephone = "5917379415", DateNaissance = new DateTime(1981, 7, 11), ContactUrgenceTel = "8013733112", ContactUrgenceNom = "Esteban Synnot", DateEmbauche = new DateTime(2023, 6, 21), Departement = "Ventes", Poste = "Conseiller en électronique", Salaire = 16.03f, EstActif = true },
                new Employee { Id = 436222, IdSuperieur = 330152, Prenom = "Darrel", Nom = "Chardin", Courriel = "dchardin6@ask.com", AdresseLigne1 = "5912 Charing Cross Trail", AdresseLigne2 = "Apt 1025", Ville = "Kembang", Telephone = "4004106016", DateNaissance = new DateTime(1991, 1, 1), ContactUrgenceTel = "1131519685", ContactUrgenceNom = "Darrel Chardin", DateEmbauche = new DateTime(2015, 10, 1), Departement = "Comptabilité", Poste = "Commis comptable", Salaire = 20.55f, EstActif = true },
                new Employee { Id = 437745, IdSuperieur = 330152, Prenom = "Valina", Nom = "Quakley", Courriel = "vquakley7@smh.com.au", AdresseLigne1 = "83 Paget Circle", AdresseLigne2 = "Apt 968", Ville = "Lanot", CodePostal = "5815", Telephone = "4535978928", DateNaissance = new DateTime(2000, 7, 21), ContactUrgenceTel = "9338947542", ContactUrgenceNom = "Valina Quakley", DateEmbauche = new DateTime(2024, 12, 26), Departement = "Achats", Poste = "Agent d'approvisionnement", Salaire = 18.90f, EstActif = true },
                new Employee { Id = 438412, IdSuperieur = 330152, Prenom = "Karel", Nom = "Ivashechkin", Courriel = "kivashechkin8@prnewswire.com", AdresseLigne1 = "6 Kim Crossing", AdresseLigne2 = "15th Floor", Ville = "Villarrica", Telephone = "3141376029", DateNaissance = new DateTime(1991, 6, 18), ContactUrgenceTel = "9822749277", ContactUrgenceNom = "Karel Ivashechkin", DateEmbauche = new DateTime(2022, 7, 27), Departement = "Ressources humaines", Poste = "Gestionnaire RH", Salaire = 24.01f, EstActif = true },
                new Employee { Id = 439204, IdSuperieur = 330152, Prenom = "Ferdinande", Nom = "Byles", Courriel = "fbyles9@goo.gl", AdresseLigne1 = "6825 Corben Street", AdresseLigne2 = "7th Floor", Ville = "Chonghe", Telephone = "9853481572", DateNaissance = new DateTime(2000, 9, 18), ContactUrgenceTel = "2003423397", ContactUrgenceNom = "Ferdinande Byles", DateEmbauche = new DateTime(2018, 3, 31), Departement = "Entrepôt", Poste = "Préparateur de commandes", Salaire = 16.89f, EstActif = true }
            };

            return employees;
        }
    }
}
