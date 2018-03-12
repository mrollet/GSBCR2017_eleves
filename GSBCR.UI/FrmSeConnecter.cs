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
    public partial class FrmSeConnecter : Form
    {
        private VISITEUR leVisiteur = null;
        public FrmSeConnecter()
        {
            InitializeComponent();
            txtId.Focus();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                leVisiteur = Manager.ChargerVisiteur(txtId.Text, txtMdp.Text);
                
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            if (leVisiteur != null)
            {
                FrmMenuVisiteur menu = new FrmMenuVisiteur(leVisiteur);
                menu.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Erreur de connexion";
                lblMessage.Visible = true;
            }
        }
    }
}
