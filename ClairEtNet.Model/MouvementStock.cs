namespace ClairEtNet.Model;

public class MouvementStock
{
    public int Id_mouvementstock { get; set; }
    public int Quantite_mouvementstock { get; set; }
    public string Type_mouvementstock { get; set; }
    public string Description_mouvementstock { get; set; }
    public DateTime Created_at_mouvementstock { get; set; }
    public DateTime Updated_at_mouvementstock { get; set; }

    //! FK
    public int Id_stock { get; set; }
    public int Id_utilisateur { get; set; }
    public int Id_chantier { get; set; }

    //! Objts
    public Stock? Stock { get; set; }
    public Utilisateur? Utilisateur { get; set; }
    public Chantier? Chantier { get; set; }
}