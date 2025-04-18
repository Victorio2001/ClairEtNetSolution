namespace ClairEtNet.Model;

public class Utilisateur
{
    public int Id_utilisateur { get; set; }
    public string Nom_utilisateur { get; set; }
    public string Prenom_utilisateur { get; set; }
    public string Email_utilisateur { get; set; }
    public DateTime Date_naissance_utilisateur { get; set; }
    public bool Donnees_supprimes_utilisateur { get; set; }
    public string Mot_de_passe { get; set; }
    public bool Verified_utilisateur { get; set; }
    public string Telephone_utilisateur { get; set; }
    public string Adresse_utilisateur { get; set; }
    public DateTime Created_at_utilisateur { get; set; }
    public DateTime Updated_at_utilisateur { get; set; }


    //! Objts
    public Employer? Employer { get; set; }
    public ICollection<MouvementStock>? MouvementsStock { get; set; }
}