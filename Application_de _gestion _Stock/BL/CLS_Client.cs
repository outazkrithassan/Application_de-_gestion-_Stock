using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_de__gestion__Stock.BL
{
    class CLS_Client
    {
        private dbStockContext db = new dbStockContext();
        private Client C;
        public bool Ajouter_Client(string Nom, string prenom, string Adresse, string Telephone, string Email, string pays, string Ville)
        {
            C = new Client();
            C.Nom_Client = Nom;
            C.Prenom_Client = prenom;
            C.Adresse_Client = Adresse;
            C.Telephonne_Client = Telephone;
            C.Email_Client = Email;
            C.Pays_Client = pays;
            C.Ville_Client = Ville;
            if (db.Clients.SingleOrDefault(s => s.Nom_Client == Nom && C.Prenom_Client == prenom) == null)
            {
                db.Clients.Add(C);
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }
        public void Modifier_Client(int Id, string Nom, string prenom, string Adresse, string Telephone, string Email, string pays, string Ville)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == Id);

            if (C != null)
            {
                C.Nom_Client = Nom;
                C.Prenom_Client = prenom;
                C.Adresse_Client = Adresse;
                C.Telephonne_Client = Telephone;
                C.Email_Client = Email;
                C.Pays_Client = pays;
                C.Ville_Client = Ville;
                db.SaveChanges();

            }

        }
        public void Suprimer_Client(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if (C != null)
            {
                db.Clients.Remove(C);
                db.SaveChanges();
            }
        }
    }
}
