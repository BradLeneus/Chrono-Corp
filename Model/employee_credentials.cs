namespace ChronoCorp.Models
{
    public class employee_credentials
    {
        public int id_employee { get; set; }
        public string username { get; set; }
        public string mdp { get; set; }
        public string role { get; set; }

        // Navigation property
        public virtual employee employee { get; set; }
    }
}
