namespace ClairEtNet.Model;

public class Incident
{
    public int Id_incident { get; set; }
    public string Titre_incident { get; set; }
    public string Description_incident { get; set; }
    public string Statut_incident { get; set; }     // enum en base
    public string Type_incident { get; set; }       // enum en base
    public bool Priorite_incident { get; set; }

    public DateTime Created_at_incident { get; set; }
    public DateTime Updated_at_incident { get; set; }

    //! FK
    public int Id_chantier { get; set; }
    public int Id_employer { get; set; }

    //! Objts
    public Chantier? Chantier { get; set; }
    public Employer? Employer { get; set; }
}