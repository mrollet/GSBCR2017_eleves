using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmVoirMedicament : Form
    {
        public FrmVoirMedicament(MEDICAMENT m)
        {
            InitializeComponent();
            ucMedicament1.LeMedicament = m;
            ucMedicament1.Visible = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
