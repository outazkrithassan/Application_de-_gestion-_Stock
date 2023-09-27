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
    public partial class FRM_Menu : Form
    {
       
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229,583);
            panelParametre.Visible = false;
        }
        public void desactiveForm()
        {
            btnClient.Enabled = false;
            btnProduit.Enabled = false;
            btnCategorie.Enabled = false;
            btnCommande.Enabled = false; ;
            btnUyilisateur.Enabled = false;
            btncopier.Enabled = false;
            btnrestaurer.Enabled = false;
            btndeconnecter.Enabled = false;
            panelBut.Enabled = false;
            btnConnecter.Enabled = true;
        }
        public void activerform()
        {
            btnClient.Enabled = true;
            btnProduit.Enabled = true;
            btnCategorie.Enabled = true;
            btnCommande.Enabled = true; ;
            btnUyilisateur.Enabled = true;
            btncopier.Enabled = true;
            btnrestaurer.Enabled = true;
            btndeconnecter.Enabled = true;
            panelBut.Enabled = true;
            btnConnecter.Enabled = false;
            panelParametre.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            panelBut.Top = btnClient.Top;
            if (!panelafficher.Controls.Contains(USER_List_Client.Instance))
            {
                panelafficher.Controls.Add(USER_List_Client.Instance);
                USER_List_Client.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                USER_List_Client.Instance.BringToFront();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel1.Size == new Size(229, 583))
            {
                panel1.Size = new Size(79,583);
            }
            else { panel1.Size = new Size(229, 583); }
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            panelBut.Top = btnProduit.Top;
            if (!panelafficher.Controls.Contains(USER_Liste_Produit.Instance))
            {
                panelafficher.Controls.Add(USER_Liste_Produit.Instance);
                USER_Liste_Produit.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                USER_Liste_Produit.Instance.BringToFront();
            }
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            panelBut.Top = btnCategorie.Top;
            if (!panelafficher.Controls.Contains(USER_Liste_Categorie.Instance))
            {
                panelafficher.Controls.Add(USER_Liste_Categorie.Instance);
                USER_Liste_Categorie.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                USER_Liste_Categorie.Instance.BringToFront();
            }
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            panelBut.Top = btnCommande.Top;
            if (!panelafficher.Controls.Contains(USER_Liste_Commande.Instance))
            {
                panelafficher.Controls.Add(USER_Liste_Commande.Instance);
                USER_Liste_Commande.Instance.Dock = DockStyle.Fill;
                USER_Liste_Commande.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Commande.Instance.BringToFront();
            }
        }

        private void btnUyilisateur_Click(object sender, EventArgs e)
        {
            panelBut.Top = btnUyilisateur.Top;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelParametre.Size = new Size(320, 190);
            panelParametre.Visible= !panelParametre.Visible;
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            FRM_Connexion frmC = new FRM_Connexion(this);
            frmC.ShowDialog();
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            desactiveForm();
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            desactiveForm();
        }
    }
}
