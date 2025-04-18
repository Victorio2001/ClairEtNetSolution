namespace ClairEtNet.Model;

public class Contact
{
    public int Id_contact { get; set; }
    public string Email_contact { get; set; }
    public string Sujet_contact { get; set; }
    public string Message_contact { get; set; }
    public bool Lu_contact { get; set; }
    public bool Traite_contact { get; set; }
    public string? Reponse_contact { get; set; }
    public DateTime Created_at_contact { get; set; }
}