using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_de__gestion__Stock.PL
{
    public partial class USER_List_Client : UserControl
    {
        private static USER_List_Client Userclient;
        private dbStockContext db;
        public static USER_List_Client Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_List_Client();
                }
                return Userclient;
            }
        }
        
        public USER_List_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void USER_List_Client_Load(object sender, EventArgs e)
        {
            Actualiserdatagrid();
        }

        private void textrecherche_Enter(object sender, EventArgs e)
        {
            if (textrecherche.Text == "Rechercher")
            {
                textrecherche.Text = "";
                textrecherche.ForeColor = Color.Black;
            }
        }
        public void Actualiserdatagrid()
        {
            db = new dbStockContext();
            dvgClient.Rows.Clear();
            foreach (var S in db.Clients)
            {
                dvgClient.Rows.Add(false, S.ID_Client, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Telephonne_Client, S.Email_Client, S.Pays_Client, S.Ville_Client);
            }
        }
        public string selectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgClient.Rows.Count; i++)
            {
                if ((bool)dvgClient.Rows[i].Cells[0].Selected == true)
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner le Client Que vous_voulez modifier";
            }
            if (Nombreligneselect > 1)
            {
                return "Selectionner Seulmment 1 seul Client pour modifier";
            }
            return null;
        }
        private void buttonajouterClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmClient = new FRM_Ajouter_Modifier_Client(this);
            frmClient.ShowDialog();
        }
        public int IdSELECT;
        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmclient = new FRM_Ajouter_Modifier_Client(this);
            if (selectVerif() == null)
            {
                for (int i = 0; i < dvgClient.Rows.Count; i++)
                {
                    if ((bool)dvgClient.Rows[i].Cells[0].Selected == true)
                    {
                        frmclient.IdSELECT = (int)dvgClient.Rows[i].Cells[1].Value;
                        frmclient.textNom.Text = dvgClient.Rows[i].Cells[2].Value.ToString();
                        frmclient.textPrenom.Text = dvgClient.Rows[i].Cells[3].Value.ToString();
                        frmclient.textAdresse.Text = dvgClient.Rows[i].Cells[4].Value.ToString();
                        frmclient.textTelephone.Text = dvgClient.Rows[i].Cells[5].Value.ToString();
                        frmclient.textEmail.Text = dvgClient.Rows[i].Cells[6].Value.ToString();
                        frmclient.textPays.Text = dvgClient.Rows[i].Cells[7].Value.ToString();
                        frmclient.textVille.Text = dvgClient.Rows[i].Cells[8].Value.ToString();


                    }
                }
                frmclient.LblTitle.Text = "Modifier Client";
                frmclient.buttonActualiser.Visible = false;
                frmclient.ShowDialog();
            }
            else { MessageBox.Show(selectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonsupremeClient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client clclient = new BL.CLS_Client();
            int select = 0;
            for (int i = 0; i < dvgClient.Rows.Count; i++)
            {
                if ((bool)dvgClient.Rows[i].Cells[0].Selected == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun client selectionnes", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous Vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dvgClient.Rows.Count; i++)
                    {
                        if ((bool)dvgClient.Rows[i].Cells[0].Selected == true)
                        {
                            clclient.Suprimer_Client(int.Parse(dvgClient.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    Actualiserdatagrid();
                    MessageBox.Show("Suppresion avec succées", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("suppresion est annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Clients.ToList();
            if (textrecherche.Text != "")
            {
                switch (comborechercher.Text)
                {
                    case "Nom":
                        listerecherche = listerecherche.Where(s => s.Nom_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        listerecherche = listerecherche.Where(s => s.Adresse_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.Telephonne_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;


                }
            }
            dvgClient.Rows.Clear();
            foreach (var S in listerecherche)
            {
                dvgClient.Rows.Add(false, S.ID_Client, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Telephonne_Client, S.Email_Client, S.Pays_Client, S.Ville_Client);
            }
        }
    }
}
