namespace ClairEtNet.Model;

public class Employer
{
    public int Id_employer { get; set; }

    //! FK
    public int? Id_utilisateur { get; set; }

    public DateTime Created_at_employer { get; set; }
    public DateTime Updated_at_employer { get; set; }

    //! Objts
    public Utilisateur? Utilisateur { get; set; }
    public ICollection<Affectation>? Affectations { get; set; }
    public ICollection<Incident>? Incidents { get; set; }
}