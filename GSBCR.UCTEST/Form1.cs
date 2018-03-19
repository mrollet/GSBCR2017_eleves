using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;
using GSBCR.UC;

namespace GSBCR.UCTEST
{
    public partial class Form1 : Form
    {
              
        public Form1()
        {
            InitializeComponent();
            bsMedoc.DataSource = Manager.ChargerMedicaments();
            cbxMedoc.DataSource = bsMedoc;
            cbxMedoc.ValueMember = "MED_DEPOTLEGAL";
            cbxMedoc.DisplayMember = "MED_NOMCOMMERCIAL";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedoc.SelectedIndex = -1;
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedoc.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedoc.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }
        }
    }
}
