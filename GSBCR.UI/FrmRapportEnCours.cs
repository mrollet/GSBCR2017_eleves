using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmRapportEnCours : Form
    {
        List<RAPPORT_VISITE> lesRapports;
        public FrmRapportEnCours(List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            lesRapports = lr;
            bsRapportEnCours.DataSource = lesRapports;
            dgvRapportEnCours.DataSource = bsRapportEnCours;
            //Vous ne pouvez pas définir le SelectedIndex d’un ComboBox élément - 1 si l’élément est un élément lié aux données.
            //  cbxRapportEnCours.SelectedIndex = -1;
            //cbxRapportEnCours.DisplayMember = "RAP_NUM";
            //cbxRapportEnCours.ValueMember = "RAP_NUM";
            
        }
        private void FrmRapportEnCours_Load(object sender, EventArgs e)
        {
            
        }
        private void dgvRapportEnCours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = (RAPPORT_VISITE)bsRapportEnCours.Current;
            //r.LePraticien = PraticienDAO.ChargerLePraticien(r.PraNum);
            //r.Motif = MotifVisiteDAO.ChargerMotifVisite(r.MotCode);
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
            //On relance la liaison de données pour actualiser l'état des rapports
            if (r.RAP_ETAT == "2")
            {
                //les rapports à l'état 2 ('saisie terminée') ne doivent pas apparaitre dans la liste
                bsRapportEnCours.RemoveCurrent();
            }
            else
            {
                bsRapportEnCours.ResetCurrentItem();
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
