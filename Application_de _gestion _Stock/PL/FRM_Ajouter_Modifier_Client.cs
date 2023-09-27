using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_de__gestion__Stock.PL
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajouter_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }
        string testobligatoire()
        {
            if (textNom.Text == "" || textNom.Text == "Nom de Client")
            {
                return "Entrer le Nom de Client";
            }
            if (textPrenom.Text == "" || textPrenom.Text == "Prenom de Client")
            {
                return "Entrer le Prenom de Client";
            }
            if (textAdresse.Text == "" || textAdresse.Text == "Adresse Client")
            {
                return "Entrer l'adresse de Client";
            }
            if (textTelephone.Text == "" || textTelephone.Text == "Telephone Client")
            {
                return "Entrer Telephone de Client";
            }
            if (textEmail.Text == "" || textEmail.Text == "Email Client")
            {
                return "Entrer Email de Client";
            }
            if (textPays.Text == "" || textPays.Text == "Pays Client")
            {
                return "Entrer le Pays de Client";
            }
            if (textVille.Text == "" || textVille.Text == "Ville Client")
            {
                return "Entrer la Ville de Client";
            }
            if (textEmail.Text == "" || textEmail.Text == "Email Client")
            {
                try
                {
                    new MailAddress(textEmail.Text);
                }
                catch { return "Email Invalide"; }
            }
            return null;
        }
        private void FRM_Ajouter_Modifier_Client_Load(object sender, EventArgs e)
        {

        }

        private void textTelephone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textNom_Enter(object sender, EventArgs e)
        {
            if (textNom.Text == "Nom de Client")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.White;
            }
        }

        private void textAdresse_Enter(object sender, EventArgs e)
        {
            if (textAdresse.Text == "Adresse Client")
            {
                textAdresse.Text = "";
                textAdresse.ForeColor = Color.White;
            }
        }

        private void textPays_Enter(object sender, EventArgs e)
        {
            if (textPays.Text == "Pays Client")
            {
                textPays.Text = "";
                textPays.ForeColor = Color.White;
            }
        }

        private void textPrenom_Enter(object sender, EventArgs e)
        {
            if (textPrenom.Text == "Prenom de Client")
            {
                textPrenom.Text = "";
                textPrenom.ForeColor = Color.White;
            }
        }

        private void textTelephone_Enter(object sender, EventArgs e)
        {
            if (textTelephone.Text == "Telephone Client")
            {
                textTelephone.Text = "";
                textTelephone.ForeColor = Color.White;
            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "Email Client")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.White;
            }
        }

        private void textVille_Enter(object sender, EventArgs e)
        {
            if (textVille.Text == "Ville Client")
            {
                textVille.Text = "";
                textVille.ForeColor = Color.White;
            }
        }

        private void textNom_Leave(object sender, EventArgs e)
        {
            if (textNom.Text == "")
            {
                textNom.Text = "Nom de Client";
                textNom.ForeColor = Color.Silver;
            }
        }

        private void textAdresse_Leave(object sender, EventArgs e)
        {
            if (textAdresse.Text == "")
            {
                textAdresse.Text = "Adresse Client";
                textAdresse.ForeColor = Color.Silver;
            }
        }

        private void textPays_Leave(object sender, EventArgs e)
        {
            if (textPays.Text == "")
            {
                textPays.Text = "Pays Client";
                textPays.ForeColor = Color.Silver;
            }
        }

        private void textPrenom_Leave(object sender, EventArgs e)
        {
            if (textPrenom.Text == "")
            {
                textPrenom.Text = "Prenom de Client";
                textPrenom.ForeColor = Color.Silver;
            }
        }

        private void textTelephone_Leave(object sender, EventArgs e)
        {
            if (textTelephone.Text == "")
            {
                textTelephone.Text = "Telephone Client";
                textTelephone.ForeColor = Color.Silver;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "Email Client";
                textEmail.ForeColor = Color.Silver;
            }
        }

        private void textVille_Leave(object sender, EventArgs e)
        {
            if (textVille.Text == "")
            {
                textVille.Text = "Ville Client";
                textVille.ForeColor = Color.Silver;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int IdSELECT;
        private void button2_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (LblTitle.Text == "Ajouter Client")
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if (clclient.Ajouter_Client(textNom.Text, textPrenom.Text, textAdresse.Text, textTelephone.Text, textEmail.Text, textPays.Text, textVille.Text) == true)
                {
                    MessageBox.Show("Client Ajouter avec Succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as USER_List_Client).Actualiserdatagrid();
                }
                else
                {
                    MessageBox.Show("Nom et Prénom de client d'éja existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                DialogResult R = MessageBox.Show("Voulez_vous vraiment modifier le  client", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    clclient.Modifier_Client(IdSELECT, textNom.Text, textPrenom.Text, textAdresse.Text, textTelephone.Text, textEmail.Text, textPays.Text, textVille.Text);
                    (usclient as USER_List_Client).Actualiserdatagrid();
                    MessageBox.Show("Client Modifier avec succés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                else
                {
                    MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            textNom.Text = "Nom de Client";
            textNom.ForeColor = Color.Silver;

            textPrenom.Text = "Prenom de Client";
            textPrenom.ForeColor = Color.Silver;

            textAdresse.Text = "Adresse Client";
            textAdresse.ForeColor = Color.Silver;

            textTelephone.Text = "Telephone Client";
            textTelephone.ForeColor = Color.Silver;

            textEmail.Text = "Email Client";
            textEmail.ForeColor = Color.Silver;

            textPays.Text = "Pays Client";
            textPays.ForeColor = Color.Silver;

            textVille.Text = "Ville Client";
            textVille.ForeColor = Color.Silver;
        }
    }
}
