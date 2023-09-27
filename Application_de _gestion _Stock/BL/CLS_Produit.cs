using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Application_de__gestion__Stock.BL
{
    class CLS_Produit
    {
        private dbStockContext db = new dbStockContext();
        private Produit PR;
        public bool Ajouter_Produit(String NomP, int QTE, String Prix, byte[] ImageP, int idCatigorie)
        {
            PR = new Produit();
            PR.Nom_Produit = NomP;
            PR.Quantite_Produit = QTE;
            PR.Prix_Produit = Prix;
            PR.Image_Produit = ImageP;
            PR.ID_CATEGORIE = idCatigorie;
            if (db.Produits.SingleOrDefault(S => S.Nom_Produit == NomP) == null)
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }
        public void Modifier_Produit(int IDP, String NomP, int QTE, String Prix, byte[] ImageP, int idCatigorie)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.Id_Produit == IDP);
            if (PR != null)
            {
                PR.Nom_Produit = NomP;
                PR.Quantite_Produit = QTE;
                PR.Prix_Produit = Prix;
                PR.Image_Produit = ImageP;
                PR.ID_CATEGORIE = idCatigorie;
                db.SaveChanges();
            }
        }
        public void Supprimer_Produit(int id)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.Id_Produit == id);
            if (PR != null)
            {
                db.Produits.Remove(PR);
                db.SaveChanges();
            }
        }
    }
}
    
