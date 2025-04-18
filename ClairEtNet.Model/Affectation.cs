namespace ClairEtNet.Model;

public class Affectation
{
    public int Id_affectation { get; set; }

    //! FK
    public int Id_employer { get; set; }
    public int Id_chantier { get; set; }

    public DateTime Date_debut_affectation { get; set; }
    public DateTime Date_fin_affectation { get; set; }
    public string Fonction_affectation { get; set; }

    //! Objts
    public Employer? Employer { get; set; }
    public Chantier? Chantier { get; set; }
}