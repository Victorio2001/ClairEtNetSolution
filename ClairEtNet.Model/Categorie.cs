namespace ClairEtNet.Model;

public class Categorie
{
    public int Id_categorie { get; set; }
    public string Libelle_categorie { get; set; }
    public string Description_categorie { get; set; }
    public DateTime Created_at_categorie { get; set; }
    public DateTime Updated_at_categorie { get; set; }

    //! Objts
    public ICollection<Stock>? Stocks { get; set; }
}