using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_de__gestion__Stock.PL
{
    public partial class Frm_Client_Commande : Form
    {
        private dbStockContext db;
        public Frm_Client_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void Frm_Client_Commande_Load(object sender, EventArgs e)
        {
            foreach (var LC in db.Clients)
            {
                dvgClient.Rows.Add(LC.ID_Client, LC.Nom_Client, LC.Prenom_Client, LC.Adresse_Client, LC.Telephonne_Client, LC.Email_Client, LC.Pays_Client, LC.Ville_Client);
            }
        }

        private void dvgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgClient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
