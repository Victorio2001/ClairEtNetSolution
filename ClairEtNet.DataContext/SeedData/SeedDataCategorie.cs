using ClairEtNet.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClairEtNet.DataContext.SeedData
{
    public static class SeedDataCategorie
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            var date = new DateTime(2020, 1, 1);

            modelBuilder.Entity<Categorie>().HasData(
                new Categorie
                {
                    Id_categorie           = 1,
                    Libelle_categorie      = "Produits d’entretien",
                    Description_categorie  = "Détergents, désinfectants, nettoyants multi-surfaces et vitres",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                },
                new Categorie
                {
                    Id_categorie           = 2,
                    Libelle_categorie      = "Consommables hygiène",
                    Description_categorie  = "Papier toilette, essuie-mains, savon, sacs-poubelle, recharges",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                },
                new Categorie
                {
                    Id_categorie           = 3,
                    Libelle_categorie      = "Matériel manuel",
                    Description_categorie  = "Balais, raclettes, microfibres, seaux, manches télescopiques",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                },
                new Categorie
                {
                    Id_categorie           = 4,
                    Libelle_categorie      = "Équipements motorisés",
                    Description_categorie  = "Autolaveuses, aspirateurs, monobrosses, balayeuses",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                },
                new Categorie
                {
                    Id_categorie           = 5,
                    Libelle_categorie      = "Équipements de protection (EPI)",
                    Description_categorie  = "Gants, lunettes, masques, casques, chaussures de sécurité",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                },
                new Categorie
                {
                    Id_categorie           = 6,
                    Libelle_categorie      = "Pièces détachées & accessoires",
                    Description_categorie  = "Filtres, batteries, brosses, tuyaux et autres pièces de rechange",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                },
                new Categorie
                {
                    Id_categorie           = 7,
                    Libelle_categorie      = "Signalisation & sécurité",
                    Description_categorie  = "Panneaux sol glissant, rubalise, cônes, trousses de secours",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                },
                new Categorie
                {
                    Id_categorie           = 8,
                    Libelle_categorie      = "Produits spéciaux",
                    Description_categorie  = "Traitements sols, anti-graffiti, détachants textiles, détartrants",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                },
                new Categorie
                {
                    Id_categorie           = 9,
                    Libelle_categorie      = "Outillage léger",
                    Description_categorie  = "Tournevis, pinces, clés, petits outils de maintenance",
                    Created_at_categorie   = date,
                    Updated_at_categorie   = date
                }
            );
        }
    }
}
