using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;

namespace Application_de__gestion__Stock.PL
{
    public partial class USER_Liste_Commande : UserControl
    {
        private static USER_Liste_Commande UserCommande;
        private dbStockContext db;
        public static USER_Liste_Commande Instance
        {
            get
            {
                if (UserCommande == null)
                {
                    UserCommande = new USER_Liste_Commande();
                }
                return UserCommande;
            }
        }
        public USER_Liste_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        public void Remplirdata()
        {
            dvgCommande.Rows.Clear();
            Client c = new Client();
            string NomPrenom;
            foreach (var lc in db.Commandes)
            {
                c = db.Clients.Single(s => s.ID_Client == lc.ID_Client);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                dvgCommande.Rows.Add(lc.ID_Commande, lc.DATE_Commande, NomPrenom, lc.ToTal_Ht, lc.TVA, lc.Total_TTC);
            }
        }
        private void USER_Liste_Commande_Load(object sender, EventArgs e)
        {
            Remplirdata();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var listecommande = db.Commandes.ToList();
            if (dvgCommande.Rows.Count != 0)
            {
                listecommande = listecommande.Where(s => s.DATE_Commande.Date >= DateD.Value.Date && s.DATE_Commande.Date <= DateF.Value.Date).ToList();
                dvgCommande.Rows.Clear();
                Client c = new Client();
                string NomPrenom;
                foreach (var lc in listecommande)
                {
                    c = db.Clients.Single(s => s.ID_Client == lc.ID_Client);
                    NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                    dvgCommande.Rows.Add(lc.ID_Commande, lc.DATE_Commande, NomPrenom, lc.ToTal_Ht, lc.TVA, lc.Total_TTC);
                }
            }
        }

        private void buttonajouterCommande_Click(object sender, EventArgs e)
        {
            PL.FRM_Detaile_Commande frmC = new FRM_Detaile_Commande(this);
            frmC.ShowDialog();
        }

        private void buttonImprimerCommand_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPORT frmrp = new RAP.FRM_RAPORT();
            db = new dbStockContext();
            try
            {
                int Idcommande = (int)dvgCommande.CurrentRow.Cells[0].Value;
                var Commande = db.Commandes.Single(s => s.ID_Commande == Idcommande);
                var ClientCommande = db.Clients.Single(s => s.ID_Client == Commande.ID_Client);
                var listdetail = db.Details_Commande.Where(s => s.ID_Commande == Idcommande).ToList();
                frmrp.RPAfficher.LocalReport.ReportEmbeddedResource = "Application_de__gestion__Stock.RAP.RPT_Commande.rdlc";
                frmrp.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("dataCommande", listdetail));
                ReportParameter NomProm = new ReportParameter("NomPrenomClient", ClientCommande.Nom_Client + " " + ClientCommande.Prenom_Client);
                ReportParameter Adresse = new ReportParameter("AdresseC", ClientCommande.Adresse_Client);
                ReportParameter Telephone = new ReportParameter("TelephoneC", ClientCommande.Telephonne_Client);
                ReportParameter Email = new ReportParameter("EmailC", ClientCommande.Email_Client);
                ReportParameter NumeroCommande = new ReportParameter("IDCommande", Idcommande.ToString());
                ReportParameter DatCommande = new ReportParameter("DateCommande", Commande.DATE_Commande.ToShortDateString());
                ReportParameter Totalht = new ReportParameter("Totalht", Commande.ToTal_Ht);
                ReportParameter Tva = new ReportParameter("tva", Commande.TVA);
                ReportParameter TotalTTC = new ReportParameter("Totalttc", Commande.Total_TTC);
                frmrp.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { NomProm, Adresse, Telephone, Email, NumeroCommande, DatCommande, Totalht, Tva, TotalTTC });
                frmrp.RPAfficher.RefreshReport();
                frmrp.ShowDialog();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
