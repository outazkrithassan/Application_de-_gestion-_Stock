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
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit Userproduit;
        private dbStockContext db;
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (Userproduit == null)
                {
                    Userproduit = new USER_Liste_Produit();
                }
                return Userproduit;
            }
        }
        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        public void Actualiserdvg()
        {
            db = new dbStockContext();
            dvgProduit.Rows.Clear();
            Categorie Cat = new Categorie();
            foreach (var Lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == Lis.ID_CATEGORIE);
                if (Cat != null)
                {
                    dvgProduit.Rows.Add(false, Lis.Id_Produit, Lis.Nom_Produit, Lis.Quantite_Produit, Lis.Prix_Produit, Cat.Nom_Categorie);
                }
            }
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((int)dvgProduit.Rows[i].Cells[3].Value == 0)
                {
                    dvgProduit.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgProduit.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;

                }
            }
        }

        public string selectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner le Produit";
            }
            if (Nombreligneselect > 1)
            {
                return "Selectionner Seulmment 1 seul Produit";
            }
            return null;
        }
        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {

        }

        private void buttonajouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new FRM_Ajouter_Modifier_Produit(this);
            frmProduit.ShowDialog();
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Produits.ToList();
            listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dvgProduit.Rows.Clear();
            Categorie Cat = new Categorie();
            foreach (var l in listerecherche)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == l.ID_CATEGORIE);
                dvgProduit.Rows.Add(false, l.Id_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit, Cat.ID_CATEGORIE);
            }
        }

        private void buttonACT_Click(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        private void buttonModifierProduit_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if (selectVerif() != null)
            {
                MessageBox.Show(selectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.FRM_Ajouter_Modifier_Produit frmProduit = new FRM_Ajouter_Modifier_Produit(this);
                frmProduit.LblTitle.Text = "Modifier Client";
                frmProduit.buttonActualiser.Visible = false;
                for (int i = 0; i < dvgProduit.Rows.Count; i++)
                {
                    if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int)dvgProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.Id_Produit == MYIDSELECT);
                        if (PR != null)
                        {
                            frmProduit.IDPRODUIT = (int)dvgProduit.Rows[i].Cells[1].Value;
                            frmProduit.textNomProduit.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                            frmProduit.textQte.Text = dvgProduit.Rows[i].Cells[3].Value.ToString();
                            frmProduit.textPrix.Text = dvgProduit.Rows[i].Cells[4].Value.ToString();
                            frmProduit.comboCatigorier.Text = dvgProduit.Rows[i].Cells[5].Value.ToString();
                            MemoryStream MS = new MemoryStream(PR.Image_Produit);
                            frmProduit.picProduit.Image = Image.FromStream(MS);

                        }



                    }
                }
                frmProduit.ShowDialog();

            }
        }

        private void btnAfficherProduit_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if (selectVerif() != null)
            {
                MessageBox.Show(selectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                for (int i = 0; i < dvgProduit.Rows.Count; i++)
                {
                    if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int)dvgProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.Id_Produit == MYIDSELECT);
                        if (PR != null)
                        {
                            FRM_Photo_Produit frmP = new FRM_Photo_Produit();
                            MemoryStream MS = new MemoryStream(PR.Image_Produit);
                            frmP.ProduitImage.Image = Image.FromStream(MS);
                            frmP.NomProduit.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                            frmP.ShowDialog();
                        }



                    }
                }

            }
        }

        private void textrecherche_Enter(object sender, EventArgs e)
        {
            if (textrecherche.Text == "Rechercher")
            {
                textrecherche.Text = "";
                textrecherche.ForeColor = Color.White;
            }
        }

        private void textrecherche_Leave(object sender, EventArgs e)
        {
            if (textrecherche.Text == "")
            {
                textrecherche.Text = "Rechercher";
                textrecherche.ForeColor = Color.DimGray;
            }
        }

        private void buttonsupremeProduit_Click(object sender, EventArgs e)
        {
            BL.CLS_Produit clclient = new BL.CLS_Produit();
            int select = 0;
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun Produit selectionnes", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous Vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dvgProduit.Rows.Count; i++)
                    {
                        if ((bool)dvgProduit.Rows[i].Cells[0].Selected == true)
                        {
                            clclient.Supprimer_Produit(int.Parse(dvgProduit.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    Actualiserdvg();
                    MessageBox.Show("Suppresion avec succées", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("suppresion est annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonImprimerSelect_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            int idselect = 0;
            string NomCategorie = null;
            RAP.FRM_RAPORT frmpt = new RAP.FRM_RAPORT();
            Produit PR = new Produit();
            if (selectVerif() != null)
            {
                MessageBox.Show(selectVerif(), "Imprimer Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                for (int i = 0; i < dvgProduit.Rows.Count; i++)
                {
                    if ((bool)dvgProduit.Rows[i].Cells[0].Selected == true)
                    {
                        idselect = (int)dvgProduit.Rows[i].Cells[1].Value;
                        NomCategorie = dvgProduit.Rows[i].Cells[5].Value.ToString();
                    }
                }
                PR = db.Produits.SingleOrDefault(s => s.Id_Produit == idselect);
                if (PR != null)
                {
                    frmpt.RPAfficher.LocalReport.ReportEmbeddedResource= "Application_de__gestion__Stock.RAP.RPT_Produit.rdlc";
                    ReportParameter Pcategorie = new ReportParameter("RPCategorie", NomCategorie);
                    ReportParameter PNom = new ReportParameter("RPNom", PR.Nom_Produit);

                    // Check if PR.Quantite_Produit is not null before converting to string
                    ReportParameter Pquantite = new ReportParameter("RPQuantite", PR.Quantite_Produit.ToString());

                    // Check if PR.Prix_Produit is not null before converting to string
                    ReportParameter PPrix = new ReportParameter("RPPrix", PR.Prix_Produit.ToString() );

                    // Make sure the Image_Produit property is not null before converting to base64
                    string ImageString = PR.Image_Produit != null ? Convert.ToBase64String(PR.Image_Produit) : null;
                    ReportParameter Pimage = new ReportParameter("RPImage", ImageString);

                    frmpt.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { Pcategorie, PNom, Pquantite, PPrix, Pimage });

                    frmpt.RPAfficher.RefreshReport();
                    frmpt.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selected product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonImprimerTouts_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPORT frrpt = new RAP.FRM_RAPORT();
            db = new dbStockContext();
            try
            {
                var listeProduit = db.Produits.ToList();
                frrpt.RPAfficher.LocalReport.ReportEmbeddedResource = "Application_de__gestion__Stock.RAP.RPT_Liste_Produit.rdlc";
                frrpt.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("DataBaseProduit", listeProduit));
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString());
                frrpt.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { date });
                frrpt.RPAfficher.RefreshReport();
                frrpt.ShowDialog();
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Id Produit";
                    ws.Cells[1, 2] = "Nom Produit";
                    ws.Cells[1, 3] = "Quantite";
                    ws.Cells[1, 4] = "Prix";
                    var ListeProduit = db.Produits.ToList();
                    int i = 2;
                    foreach (var L in ListeProduit)
                    {
                        ws.Cells[i, 1] = L.Id_Produit;
                        ws.Cells[i, 2] = L.Nom_Produit;
                        ws.Cells[i, 3] = L.Quantite_Produit;
                        ws.Cells[i, 4] = L.Prix_Produit;
                        i++;
                    }
                    ws.Range["A1:D1"].Interior.Color = Color.Teal;
                    ws.Range["A1:D1"].Font.Color = Color.White;
                    ws.Range["A1:D1"].Font.Size = 15;
                    ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Range["A1:D1"].ColumnWidth = 16;
                    wb.SaveAs(SFD.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvagarde avec Succees dans Excel", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }
    }
}
