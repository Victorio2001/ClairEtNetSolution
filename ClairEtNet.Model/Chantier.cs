namespace ClairEtNet.Model;

public class Chantier
{
    public int Id_chantier { get; set; }
    public string Nom_chantier { get; set; }
    public string Adresse_chantier { get; set; }
    public string Longitude_chantier { get; set; }
    public string Latitude_chantier { get; set; }

    //! Objts
    public ICollection<MouvementStock>? MouvementsStock { get; set; }
    public ICollection<Incident>? Incidents { get; set; }
    public ICollection<Affectation>? Affectations { get; set; }
}