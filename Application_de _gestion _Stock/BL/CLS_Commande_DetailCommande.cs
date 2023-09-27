using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_de__gestion__Stock.BL
{
    class CLS_Commande_DetailCommande
    {
        private dbStockContext db = new dbStockContext();
        private Commande clscmd;
        private Details_Commande clsD;
        public int IDCommande;
        public void Ajouter_Commande(DateTime dateCommande, int Idclient, string totalht, string tva, string totalttc)
        {
            clscmd = new Commande();
            clscmd.DATE_Commande = dateCommande;
            clscmd.ID_Client = Idclient;
            clscmd.ToTal_Ht = totalht;
            clscmd.TVA = tva;
            clscmd.Total_TTC = totalttc;
            db.Commandes.Add(clscmd);
            db.SaveChanges();
            IDCommande = clscmd.ID_Commande;

        }
        public void Ajoutr_Detail(int idproduit, string Nomproduit, int quantite, string prix, string remis, string total)
        {
            clsD = new Details_Commande();
            clsD.ID_Commande = IDCommande;
            clsD.ID_Produit = idproduit;
            clsD.Nom_Produit = Nomproduit;
            clsD.Quantite = quantite;
            clsD.Prix = prix;
            clsD.Remise = remis;
            clsD.Total = total;
            db.Details_Commande.Add(clsD);
            db.SaveChanges();
        }
    }
}
