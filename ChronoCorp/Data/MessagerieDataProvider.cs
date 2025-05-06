using ChronoCorp.Model;

namespace ChronoCorp.Data
{
    public interface IMessagerieDataProvider
    {
        public Task<IEnumerable<Messagerie>?> GetAllMessageAsync();
    }

    public class MessagerieDataProvider : IMessagerieDataProvider
    {
        public async Task<IEnumerable<Messagerie>?> GetAllMessageAsync()
        {
            await Task.Delay(500);

            var messages = new List<Messagerie>
            {
               new Messagerie{ Id = 1, IdEmetteur = 432401, IdDestinataire = 330152, TypeMessage = "demande_conge", Contenu = "Vous avez reçu une demande de congé", Temps = new DateTime(2025,05,01)},
               new Messagerie{ Id = 1, IdEmetteur = 330152, IdDestinataire = 432401, TypeMessage = "approbation_conge", Contenu = "Votre demande de congé à été approuvée", Temps = new DateTime(2025,05,02)},
               new Messagerie{ Id = 1, IdEmetteur = 330152, IdDestinataire = 432401, TypeMessage = "paie", Contenu = "Vous avez reçu une nouvelle fiche de paie", Temps = new DateTime(2025,05,01)}
            };

            return messages;
        }
    }
}
