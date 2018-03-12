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

namespace GSBCR.UI
{
    public partial class FrmListeRapport : Form
    {
        List<RAPPORT_VISITE> lesRapports;
        public FrmListeRapport(List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            lesRapports = lr;
            lblMatricule.Text = lr[0].RAP_MATRICULE;
            bsRapport.DataSource = lr;
            dgvRapport.DataSource = bsRapport;
            //bsRapport.AllowNew = true;
           
        }

        private void FrmListeRapport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnNouveau_Click(object sender, EventArgs e)
        //{
        //    bsRapport.AddNew();
        //    RAPPORT_VISITE r = (RAPPORT_VISITE)bsRapport.Current;
        //    r.RAP_MATRICULE = lblMatricule.Text;
        //    FrmSaisir f = new FrmSaisir(r);
        //    //affichage boîte de saisie sans données
        //    if ((f.ShowDialog() == System.Windows.Forms.DialogResult.OK)&&(r.RAP_ETAT=="1"))
        //    {
        //        bsRapport.EndEdit();
        //        bsRapport.ResetCurrentItem();
        //        bsRapport.Position = bsRapport.Count;
        //    }
        //    else
        //    {
        //        bsRapport.CancelEdit();
        //    }
        //    this.Show();
        //}

        private void dgvRapport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            RAPPORT_VISITE r = (RAPPORT_VISITE)bsRapport.Current;
            //r.LePraticien = PraticienDAO.ChargerLePraticien(r.PraNum);
            //r.Motif = MotifVisiteDAO.ChargerMotifVisite(r.MotCode);
            FrmSaisir f = new FrmSaisir(r, false);
            //this.Hide();
            f.ShowDialog();
        }

       
    }
}
