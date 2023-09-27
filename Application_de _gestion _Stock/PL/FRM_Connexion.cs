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
    public partial class FRM_Connexion : Form
    {
        private dbStockContext db;
        private Form frmenu;
        BL.CLS_Connexion C = new BL.CLS_Connexion();
        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmenu = Menu;
            db = new dbStockContext();
        }
        string testobligatoire()
        {
            if (textNomUtili.Text == "" || textNomUtili.Text == "Nom d'utilisateur")
            {
                return "Entrer votre Nom";
            }
            if (textMoteDePasse.Text == "" || textMoteDePasse.Text == "Mote de Passe")
            {
                return "Entrer votre Mote De Passe";
            }
            return null;
        }
        private void textMoteDePasse_Enter(object sender, EventArgs e)
        {
            if (textMoteDePasse.Text == "Mote de Passe")
            {
                textMoteDePasse.Text = "";
                textMoteDePasse.UseSystemPasswordChar = false;
                textMoteDePasse.PasswordChar = '*';
                textMoteDePasse.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textNomUtili_Enter(object sender, EventArgs e)
        {
            if (textNomUtili.Text == "Nom d'utilisateur")
            {
                textNomUtili.Text = "";
                textNomUtili.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textNomUtili_Leave(object sender, EventArgs e)
        {
            if (textNomUtili.Text == "")
            {
                textNomUtili.Text = "Nom d'utilisateur";
                textNomUtili.ForeColor = Color.Silver;
            }
        }

        private void textMoteDePasse_Leave(object sender, EventArgs e)
        {
            if (textMoteDePasse.Text == "")
            {
                textMoteDePasse.Text = "Mote de Passe";
                textMoteDePasse.UseSystemPasswordChar = true;
                textMoteDePasse.ForeColor = Color.Silver;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testobligatoire() == null)
            {
                if (C.ConnexionValide(db, textNomUtili.Text, textMoteDePasse.Text) == true)
                {
                    MessageBox.Show("Connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmenu as PL.FRM_Menu).activerform();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
