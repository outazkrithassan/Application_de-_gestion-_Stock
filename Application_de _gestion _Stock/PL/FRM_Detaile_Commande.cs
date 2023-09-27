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
    public partial class FRM_Detaile_Commande : Form
    {
        private UserControl usercommande;
        private dbStockContext db;
        public FRM_Detaile_Commande(UserControl user)
        {
            InitializeComponent();
            usercommande = user;
            db = new dbStockContext();
        }
        public void Actualise_DetailCommande()
        {
            float Totalht = 0, TVA = 0, Totalttc;
            if (textTva.Text != "")
            {
                TVA = float.Parse(textTva.Text);
            }
            dvgCommande.Rows.Clear();
            foreach (var L in BL.D_Commande.listeDetail)
            {
                dvgCommande.Rows.Add(L.Id, L.Nom, L.Quantite, L.Prix, L.Remise, L.Total);
                Totalht = Totalht + float.Parse(L.Total);
            }
            textTotalHt.Text = Totalht.ToString();
            Totalttc = (Totalht + (Totalht * TVA / 100));
            textTotalTtc.Text = Totalttc.ToString();
        }
        public void RemplirdvgProduit()
        {
            db = new dbStockContext();
            foreach (var l in db.Produits)
            {
                dvgProduit.Rows.Add(l.Id_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((int)dvgProduit.Rows[i].Cells[2].Value == 0)
                {
                    dvgProduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgProduit.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;

                }
            }
            dvgProduit.ClearSelection();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            BL.D_Commande.listeDetail.Clear();
        }

        private void textrecherche_Enter(object sender, EventArgs e)
        {
            if (textrecherche.Text == "Rechercher")
            {
                textrecherche.Text = "";
                textrecherche.ForeColor = Color.Black;
            }
        }

        private void FRM_Detaile_Commande_Load(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Produits.ToList();
            listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dvgProduit.Rows.Clear();
            foreach (var l in listerecherche)
            {
                dvgProduit.Rows.Add(l.Id_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
        }
        public int IDCLIENT;
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Commande_DetailCommande clscommande = new BL.CLS_Commande_DetailCommande();
            if (dvgCommande.Rows.Count == 0)
            {
                MessageBox.Show("Ajouter des Produits", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textNom.Text == "")
                {
                    MessageBox.Show(" Ajouter un Client", "Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clscommande.Ajouter_Commande(commandeData.Value, IDCLIENT, textTotalHt.Text, textTva.Text, textTotalTtc.Text);
                    foreach (var LD in BL.D_Commande.listeDetail)
                    {
                        clscommande.Ajoutr_Detail(LD.Id, LD.Nom, LD.Quantite, LD.Prix, LD.Remise, LD.Total);
                    }
                   (usercommande as USER_Liste_Commande).Remplirdata();
                    BL.D_Commande.listeDetail.Clear();
                    Close();
                    MessageBox.Show("Commande Ajouter avec succes", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PL.Frm_Client_Commande frmC = new Frm_Client_Commande();
            frmC.ShowDialog();
            IDCLIENT = (int)frmC.dvgClient.CurrentRow.Cells[0].Value;
            textNom.Text = frmC.dvgClient.CurrentRow.Cells[1].Value.ToString();
            textPrenom.Text = frmC.dvgClient.CurrentRow.Cells[2].Value.ToString();
            textTelephoneC.Text = frmC.dvgClient.CurrentRow.Cells[4].Value.ToString();
            textEmailC.Text = frmC.dvgClient.CurrentRow.Cells[5].Value.ToString();
            textPaysC.Text = frmC.dvgClient.CurrentRow.Cells[6].Value.ToString();
            textVille.Text = frmC.dvgClient.CurrentRow.Cells[7].Value.ToString();
        }

        private void dvgProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            if ((int)dvgProduit.CurrentRow.Cells[2].Value == 0)
            {
                MessageBox.Show("Stock vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmp.labelID.Text = dvgProduit.CurrentRow.Cells[0].Value.ToString();

                frmp.lbNom.Text = dvgProduit.CurrentRow.Cells[1].Value.ToString();
                frmp.lbStock.Text = dvgProduit.CurrentRow.Cells[2].Value.ToString();
                frmp.lbPrix.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.textTotal.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();

                frmp.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvgCommande.CurrentRow != null)
            {
                DialogResult R =
                   MessageBox.Show("Voulez-vous Vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    int index = BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(dvgCommande.CurrentRow.Cells[0].Value.ToString()));
                    BL.D_Commande.listeDetail.RemoveAt(index);
                    Actualise_DetailCommande();
                    MessageBox.Show("Suppresion avec succées", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("suppresion est annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frm = new FRM_Produit_Commande(this);
            Produit pr = new Produit();
            if (dvgCommande.CurrentRow != null)
            {
                frm.grpproduit.Text = "Modifier Produit";
                frm.labelID.Text = dvgCommande.CurrentRow.Cells[0].Value.ToString();
                frm.lbNom.Text = dvgCommande.CurrentRow.Cells[1].Value.ToString();
                int IDP = int.Parse(dvgCommande.CurrentRow.Cells[0].Value.ToString());
                pr = db.Produits.Single(s => s.Id_Produit == IDP);
                frm.lbStock.Text = pr.Quantite_Produit.ToString();
                frm.lbPrix.Text = dvgCommande.CurrentRow.Cells[3].Value.ToString();
                frm.textQuantite.Text = dvgCommande.CurrentRow.Cells[2].Value.ToString();
                frm.textRemise.Text = dvgCommande.CurrentRow.Cells[4].Value.ToString();
                frm.textTotal.Text = dvgCommande.CurrentRow.Cells[5].Value.ToString();


                frm.ShowDialog();
            }
        }

        private void textTotalTtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTva_TextChanged(object sender, EventArgs e)
        {
            Actualise_DetailCommande();
        }
    }
    
}
