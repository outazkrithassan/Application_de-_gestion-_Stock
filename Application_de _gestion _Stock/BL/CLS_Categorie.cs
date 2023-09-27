using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_de__gestion__Stock.BL
{
    class CLS_Categorie
    {
        private dbStockContext db = new dbStockContext();
        private Categorie cat;
        public bool Ajouter_Categorie(string NomCat)
        {
            cat = new Categorie();
            cat.Nom_Categorie = NomCat;
            if (db.Categories.SingleOrDefault(s => s.Nom_Categorie == NomCat) == null)
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return true;
            }
            else { return false; }

        }
        public void Modifier_Categorie(int idcat, string NomCat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == idcat);
            if (cat != null)
            {
                cat.Nom_Categorie = NomCat;
                db.SaveChanges();
            }


        }
        public void Supprime_Categorie(int idcat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == idcat);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
            }
        }
    }
}
