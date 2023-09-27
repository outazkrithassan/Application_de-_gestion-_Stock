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
    public partial class FRM_Ajouter_Modifier_Categorie : Form
    {
        private UserControl usercat;
        public FRM_Ajouter_Modifier_Categorie(UserControl usercategorie)
        {
            InitializeComponent();
            this.usercat = usercategorie;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textNom_Enter(object sender, EventArgs e)
        {
            if (textNom.Text == "Nom De Categorie")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.White;
            }
        }

        private void textNom_Leave(object sender, EventArgs e)
        {
            if (textNom.Text == "")
            {
                textNom.Text = "Nom De Categorie";
                textNom.ForeColor = Color.White;
            }
        }
        public int idcategorie;
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Categorie clcat = new BL.CLS_Categorie();
            if (textNom.Text == "" || textNom.Text == "Nom De Categorie")
            {
                MessageBox.Show("Entrer Nom de categorie", "Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (LblTitle.Text == "Ajouter Categorie")
                {
                    if (clcat.Ajouter_Categorie(textNom.Text) == false)
                    {
                        MessageBox.Show("Categorie existe d'eja", "Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        MessageBox.Show("Categorie ajouter avec succes", "Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as USER_Liste_Categorie).remplirdatagrid();
                    }
                }
                else
                {
                    DialogResult DR = MessageBox.Show("Voutez_vous vraiment modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        clcat.Modifier_Categorie(idcategorie, textNom.Text);

                        MessageBox.Show("Categorie Modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as USER_Liste_Categorie).remplirdatagrid();

                    }
                    else { MessageBox.Show("Modification annulér", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
        }

        private void FRM_Ajouter_Modifier_Categorie_Load(object sender, EventArgs e)
        {

        }
    }
}
