using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application_de__gestion__Stock.BL
{ 
    class D_Commande
    {
        public static List<D_Commande> listeDetail = new List<D_Commande>();
        public int Id { get; set; }
        public String Nom { get; set; }
        public int Quantite { get; set; }
        public String Prix { get; set; }
        public String Remise { get; set; }
        public String Total { get; set; }
    }
}
