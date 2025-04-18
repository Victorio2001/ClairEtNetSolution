namespace ClairEtNet.Model;

public class Stock
{
    public int Id_stock { get; set; }
    public string Nom_article_stock { get; set; }
    public string Description_stock { get; set; }
    public int Quantite_stock { get; set; }
    public string Emplacement_stock { get; set; }
    public string Unite_stock { get; set; }
    public DateTime Created_at_stock { get; set; }
    public DateTime Updated_at_stock { get; set; }

    //! FK
    public int Id_categorie { get; set; }

    //! Objts
    public Categorie? Categorie { get; set; }
    public ICollection<MouvementStock>? MouvementsStock { get; set; }
}
