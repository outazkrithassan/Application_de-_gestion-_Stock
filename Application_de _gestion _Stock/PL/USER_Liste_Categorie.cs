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
    public partial class USER_Liste_Categorie : UserControl
    {
        private static USER_Liste_Categorie usercategorie;
        private dbStockContext db;
        public static USER_Liste_Categorie Instance
        {
            get
            {
                if (usercategorie == null)
                {
                    usercategorie = new USER_Liste_Categorie();
                }
                return usercategorie;
            }
        }
        public USER_Liste_Categorie()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        public void remplirdatagrid()
        {
            db = new dbStockContext();
            dvgCategorie.Rows.Clear();
            foreach (var Cat in db.Categories)
            {
                dvgCategorie.Rows.Add(false, Cat.ID_CATEGORIE, Cat.Nom_Categorie);
            }

        }
        public string selectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgCategorie.Rows.Count; i++)
            {
                if ((bool)dvgCategorie.Rows[i].Cells[0].Selected == true)
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner le Categorie";
            }
            if (Nombreligneselect > 1)
            {
                return "Selectionner Seulmment 1 seul Categorie";
            }
            return null;
        }

        private void USER_Liste_Categorie_Load(object sender, EventArgs e)
        {
            remplirdatagrid();
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            var maliste = db.Categories.ToList();
            maliste = maliste.Where(s => s.Nom_Categorie.IndexOf(textrecherche.Text, StringComparison.InvariantCultureIgnoreCase) != -1).ToList();
            dvgCategorie.Rows.Clear();
            foreach (var l in maliste)
            {
                dvgCategorie.Rows.Add(false, l.ID_CATEGORIE, l.Nom_Categorie);
            }
        }

        private void buttonImprimerTouts_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPORT frmR = new RAP.FRM_RAPORT();
            db = new dbStockContext();
            try
            {
                var listeCat = db.Categories.ToList();
                int NBcategorie = db.Categories.Count();
                var listeProduit = db.Produits.ToList();
                frmR.RPAfficher.LocalReport.ReportEmbeddedResource = "Application_de__gestion__Stock.RAP.RPT_LISTE_CATIGORIE.rdlc";
                frmR.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("Databasecatigorie", listeCat));
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToShortDateString());
                ReportParameter NBC = new ReportParameter("NRCategorie", NBcategorie.ToString());
                frmR.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { date, NBC });
                frmR.RPAfficher.RefreshReport();
                frmR.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            string NomCategorie = "";
            int idCategorie = 0;
            if (selectVerif() != null)
            {
                MessageBox.Show(selectVerif(), "Selectionne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                {
                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        for (int i = 0; i < dvgCategorie.Rows.Count; i++)
                        {
                            if ((bool)dvgCategorie.Rows[i].Cells[0].Selected == true)
                            {
                                NomCategorie = dvgCategorie.Rows[i].Cells[2].Value.ToString();
                                idCategorie = (int)dvgCategorie.Rows[i].Cells[1].Value;
                            }
                        }
                        ws.Range["A1:D1"].Merge();
                        ws.Range["A1:D1"].Value = NomCategorie;
                        ws.Cells[2, 1] = "Id Categorie";
                        ws.Cells[2, 2] = "Nom Categorie";
                        ws.Cells[2, 3] = "Id Categorie";
                        ws.Cells[2, 4] = "Nom Categorie";
                        var ListeCategorie = db.Categories.ToList();
                        var listeProduit = db.Produits.Where(s => s.ID_CATEGORIE == idCategorie);

                        int a = 3;
                        foreach (var L in listeProduit)
                        {
                            ws.Cells[a, 1] = L.Id_Produit;
                            ws.Cells[a, 2] = L.Nom_Produit;
                            ws.Cells[a, 3] = L.Quantite_Produit;
                            ws.Cells[a, 4] = L.Prix_Produit;

                            a++;
                        }
                        ws.Range["A2:D2"].Interior.Color = Color.Teal;
                        ws.Range["A2:D2"].Font.Color = Color.White;
                        ws.Range["A2:D2"].Font.Size = 15;
                        ws.Range["A1:D1"].Interior.Color = Color.DarkGreen;
                        ws.Range["A1:D1"].Font.Color = Color.White;
                        ws.Range["A1:D1"].Font.Size = 15;
                        ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        ws.Range["A2:D2"].ColumnWidth = 16;
                        wb.SaveAs(SFD.FileName);
                        app.Quit();
                        MessageBox.Show("Sauvagarde avec Succees dans Excel", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
            }
        }

        private void buttonajouterCategorie_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmcat = new FRM_Ajouter_Modifier_Categorie(this);
            frmcat.ShowDialog();
        }

        private void dvgCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmcat = new FRM_Ajouter_Modifier_Categorie(this);
            if (dvgCategorie.Columns[e.ColumnIndex].Name == "Modifier")
            {
                frmcat.idcategorie = (int)dvgCategorie.Rows[e.RowIndex].Cells[1].Value;
                frmcat.LblTitle.Text = "Modifier Categorie";
                frmcat.textNom.Text = dvgCategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmcat.ShowDialog();
            }
            if (dvgCategorie.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                BL.CLS_Categorie clscat = new BL.CLS_Categorie();
                DialogResult PR = MessageBox.Show("Voulez_vous vraiment supprimer Categorie", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    int idcat = (int)dvgCategorie.Rows[e.RowIndex].Cells[1].Value;
                    int p = db.Categories.Count(s => s.ID_CATEGORIE == idcat);
                    if (p == 0)
                    {
                        clscat.Supprime_Categorie(idcat);
                        remplirdatagrid();
                        MessageBox.Show("Categorie supprime avec succes", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        DialogResult PDP = MessageBox.Show("Il ya " + p + " Produit dans cette categorie voulez_vous vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (PDP == DialogResult.Yes)
                        {
                            clscat.Supprime_Categorie(idcat);
                            remplirdatagrid();
                            MessageBox.Show("Categorie supprime avec succes", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else { MessageBox.Show("suppresion annullé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                }
                else { MessageBox.Show("suppresion annullé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
        }

        private void textrecherche_Enter(object sender, EventArgs e)
        {
            if (textrecherche.Text == "Rechercher")
            {
                textrecherche.Text = "";
                textrecherche.ForeColor = Color.DimGray;
                ;
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
    }
}
