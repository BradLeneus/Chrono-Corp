namespace ChronoCorp.Model
{
    public class Messagerie
    {
        public long Id { get; set; }
        public long IdEmetteur { get; set; }
        public long IdDestinataire { get; set; }
        public string TypeMessage { get; set; }
        //public string Titre { get; set; }
        public string Contenu { get; set; }
        //public byte[]? Fichier { get; set; }
        public DateTime Temps { get; set; }
        //public bool EstLu { get; set; }
    }
}
