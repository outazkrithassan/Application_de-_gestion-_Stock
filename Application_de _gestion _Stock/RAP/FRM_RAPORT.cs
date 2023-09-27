using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_de__gestion__Stock.RAP
{
    public partial class FRM_RAPORT : Form
    {
        public FRM_RAPORT()
        {
            InitializeComponent();
        }

        private void FRM_RAPORT_Load(object sender, EventArgs e)
        {
            this.RPAfficher.RefreshReport();
        }

        private void RPAfficher_Load(object sender, EventArgs e)
        {

        }
    }
}
