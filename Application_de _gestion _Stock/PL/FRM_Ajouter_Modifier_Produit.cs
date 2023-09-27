using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Application_de__gestion__Stock.PL
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private dbStockContext db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl User)
        {
            InitializeComponent();
            db = new dbStockContext();
            this.userProduit = User;
            comboCatigorier.DataSource = db.Categories.ToList();
            comboCatigorier.DisplayMember = "Nom_Categorie";
            comboCatigorier.ValueMember = "ID_CATEGORIE";
        }
        string testobligatoire()
        {
            if (textNomProduit.Text == "Nom Produit" || textNomProduit.Text == "")
            {
                return "Entrer Le nom de Produit";
            }
            if (textQte.Text == "Quantité" || textQte.Text == "")
            {
                return "Entrer La Quantite de Produit";
            }
            if (textPrix.Text == "Prix" || textPrix.Text == "")
            {
                return "Entrer Le Prix de Produit";
            }
            if (picProduit.Image == null)
            {
                return "Entrer L'image de Produit";
            }
            if (comboCatigorier.Text == "")
            {
                return "Entrer La catigorie de Produit";
            }
            return null;
        }
        private void textPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void textQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void textNomProduit_Leave(object sender, EventArgs e)
        {
            if (textNomProduit.Text == "")
            {
                textNomProduit.Text = "Nom Produit";
                textNomProduit.ForeColor = Color.Silver;
            }
        }

        private void textNomProduit_Enter(object sender, EventArgs e)
        {
            if (textNomProduit.Text == "Nom Produit")
            {
                textNomProduit.Text = "";
                textNomProduit.ForeColor = Color.White;
            }
        }

        private void textQte_Leave(object sender, EventArgs e)
        {
            if (textQte.Text == "")
            {
                textQte.Text = "Quantité";
                textQte.ForeColor = Color.Silver;
            }
        }

        private void textQte_Enter(object sender, EventArgs e)
        {
            if (textQte.Text == "Quantité")
            {
                textQte.Text = "";
                textQte.ForeColor = Color.White;
            }
        }

        private void textPrix_Leave(object sender, EventArgs e)
        {
            if (textPrix.Text == "")
            {
                textPrix.Text = "Prix";
                textPrix.ForeColor = Color.Silver;
            }
        }

        private void textPrix_Enter(object sender, EventArgs e)
        {
            if (textPrix.Text == "Prix")
            {
                textPrix.Text = "";
                textPrix.ForeColor = Color.White;
            }
        }

        private void buttonParcourire_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";
            if (OP.ShowDialog() == DialogResult.OK)
            {
                picProduit.Image = Image.FromFile(OP.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            textNomProduit.Text = "Nom Produit";
            textNomProduit.ForeColor = Color.Silver;

            textQte.Text = "Quantité";
            textQte.ForeColor = Color.Silver;

            textPrix.Text = "Prix";
            textPrix.ForeColor = Color.Silver;
            comboCatigorier.Text = "";
            picProduit.Image = null;
        }
        public int IDPRODUIT;
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (LblTitle.Text == "Ajouter Produit")
                {
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();
                    if (clproduit.Ajouter_Produit(textNomProduit.Text, int.Parse(textQte.Text), textPrix.Text, byteimageP, Convert.ToInt32(comboCatigorier.SelectedValue)) == true)
                    {
                        MessageBox.Show("Produit ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as USER_Liste_Produit).Actualiserdvg();
                    }
                    else
                    {
                        MessageBox.Show("Produit Existe d'eja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();
                    BL.CLS_Produit clsproduit = new BL.CLS_Produit();
                    DialogResult R = MessageBox.Show("Voulez_vous vraiment modifier le  Produit", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsproduit.Modifier_Produit(IDPRODUIT, textNomProduit.Text, int.Parse(textQte.Text), textPrix.Text, byteimageP, Convert.ToInt32(comboCatigorier.SelectedValue));
                        (userProduit as USER_Liste_Produit).Actualiserdvg();
                        MessageBox.Show("Produit Modifier avec succés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FRM_Ajouter_Modifier_Produit_Load(object sender, EventArgs e)
        {

        }
    }
}
