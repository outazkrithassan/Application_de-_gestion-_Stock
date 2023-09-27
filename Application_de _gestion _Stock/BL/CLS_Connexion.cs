using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_de__gestion__Stock.BL
{
    class CLS_Connexion
    {
        public bool ConnexionValide(dbStockContext db, String Nom, String Mote_De_Passe)
        {
            Utilisateur U = new Utilisateur();
            U.NomUtilisateur = Nom;
            U.Mot_De_Passe = Mote_De_Passe;
            if (db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nom && s.Mot_De_Passe == Mote_De_Passe) != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}
