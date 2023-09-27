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
    public partial class FRM_Produit_Commande : Form
    {
        public Form frmdetail;
        public FRM_Produit_Commande(Form frm)
        {
            InitializeComponent();
            frmdetail = frm;
        }

        private void FRM_Produit_Commande_Load(object sender, EventArgs e)
        {

        }

        private void textQuantite_TextChanged(object sender, EventArgs e)
        {
            if (textQuantite.Text != "")
            {
                int quantite = int.Parse(textQuantite.Text);
                int prix = int.Parse(lbPrix.Text);
                if (int.Parse(textQuantite.Text) > int.Parse(lbStock.Text))
                {
                    MessageBox.Show("Il ya selment " + int.Parse(lbStock.Text) + "dans Stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textQuantite.Text = "";
                    textTotal.Text = lbPrix.Text;
                }
                else { textTotal.Text = (quantite * prix).ToString(); }


            }
            else { textTotal.Text = lbPrix.Text; }
        }

        private void textRemise_TextChanged(object sender, EventArgs e)
        {
            if (textRemise.Text != "")
            {

                int quantite;
                if (textQuantite.Text != "")
                { quantite = int.Parse(textQuantite.Text); }
                else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lbPrix.Text);
                int total = quantite * prix;
                int remis = int.Parse(textRemise.Text);
                textTotal.Text = (total - (total * remis / 100)).ToString();
            }
            else
            {
                int quantite;
                if (textQuantite.Text != "")
                { quantite = int.Parse(textQuantite.Text); }
                else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lbPrix.Text);
                textTotal.Text = (quantite * prix).ToString();
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            int QTE, Re;
            if (textQuantite.Text != "")
            { QTE = int.Parse(textQuantite.Text); }
            else
            {
                QTE = 1;
            }
            if (textRemise.Text != "")
            { Re = int.Parse(textRemise.Text); }
            else
            {
                Re = 0;
            }
            BL.D_Commande DETAIL = new BL.D_Commande
            {

                Id = int.Parse(labelID.Text),
                Nom = lbNom.Text,
                Quantite = QTE,
                Prix = lbPrix.Text,
                Remise = Re.ToString(),
                Total = textTotal.Text,
            };
            if (grpproduit.Text == "Vendre Produit")
            {
                if (BL.D_Commande.listeDetail.SingleOrDefault(s => s.Id == DETAIL.Id) != null)
                {
                    MessageBox.Show("Produit d'eja exist dans Commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { BL.D_Commande.listeDetail.Add(DETAIL); }
            }
            else
            {
                DialogResult PR = MessageBox.Show("Voulez_vous vraiment Modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    int index = BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(labelID.Text));
                    BL.D_Commande.listeDetail[index] = DETAIL;
                    MessageBox.Show("Modification succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();

                }
                else
                {
                    MessageBox.Show("Modification Annule", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }

            (frmdetail as FRM_Detaile_Commande).Actualise_DetailCommande();
        }
    }
}
