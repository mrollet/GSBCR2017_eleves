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
    public partial class FrmMenuVisiteur : Form
    {
        private VISITEUR leVisiteur;
        private VAFFECTATION leProfil;
        public FrmMenuVisiteur(VISITEUR v)
        {
            InitializeComponent();
            //visiteur
            //leVisiteur = Manager.ChargerVisiteur("a131", "30BFD069");
            //délégue
            //leVisiteur = Manager.ChargerVisiteur("r58", "0CC56730");
            leVisiteur = v;
            try
            {
                leProfil = Manager.ChargerAffectationVisiteur(v.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FrmMenuVisiteur_Load(object sender, EventArgs e)
        {
            label2.Text = leProfil.TRA_ROLE + " " + leVisiteur.Vis_PRENOM + " " + leVisiteur.VIS_NOM;
            label3.Text = "Region : " + leProfil.REG_CODE;
            //string profil = leVisiteur.LesAffectations.ElementAt(0).TRA_ROLE;
            if (leProfil.TRA_ROLE == "Visiteur")
            {
                btnNewRapportRegion.Visible = false;
                btnNewRapportRegion.TabStop = false;
                btnNewRapportRegion.Enabled = false;
                btnHistoRapportRegion.Visible = false;
                btnHistoRapportRegion.TabStop = false;
                btnHistoRapportRegion.Enabled = false;
            }
            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
        }

        private void btnEnCours_Click(object sender, EventArgs e)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            try
            {
                lesRapports = Manager.ChargerRapportVisiteurEncours(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (lesRapports != null && lesRapports.Count != 0)
            {
                FrmRapportEnCours f = new FrmRapportEnCours(lesRapports);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun rapport en cours","Gestion Rapports de visite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
       // private void btnSaisie_Click(object sender, EventArgs e)
       // {
            //List<RAPPORT_VISITE> lesRapports = Manager.ChargerRapportVisiteurEncours(leVisiteur.VIS_MATRICULE);
            //int nb = lesRapports.Count;
            //if (nb != 0)
            //{

            //    FrmListeRapport f = new FrmListeRapport(lesRapports);
            //    this.Hide();
            //    f.ShowDialog();
            //}
            //else
            //{
            //    RAPPORT_VISITE r = new RAPPORT_VISITE();
            //    r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            //    FrmSaisir f = new FrmSaisir(r);
            //    this.Hide();
            //    f.ShowDialog();
            //}


            //this.Show();
      //  }

        private void btnVoir_Click(object sender, EventArgs e)
        {
            List < RAPPORT_VISITE > lesRapports = null;
            try
            {
                lesRapports = Manager.ChargerRapportVisiteurFinis(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (lesRapports != null && lesRapports.Count != 0)
            {
                FrmListeRapport f = new FrmListeRapport(lesRapports);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun rapport validés", "Gestion Rapports de visite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPraticien_Click(object sender, EventArgs e)
        {

        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {

        }

       
    }
}
