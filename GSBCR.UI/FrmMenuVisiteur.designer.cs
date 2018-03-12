namespace GSBCR.UI
{
    partial class FrmMenuVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnVoir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPraticien = new System.Windows.Forms.Button();
            this.btnMedicament = new System.Windows.Forms.Button();
            this.btnNewRapportRegion = new System.Windows.Forms.Button();
            this.btnHistoRapportRegion = new System.Windows.Forms.Button();
            this.btnEnCours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion rapports de visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(154, 162);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(200, 23);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau rapport de visite";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(154, 361);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(208, 23);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnVoir
            // 
            this.btnVoir.Location = new System.Drawing.Point(154, 133);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(200, 23);
            this.btnVoir.TabIndex = 4;
            this.btnVoir.Text = "Mes rapports validés";
            this.btnVoir.UseVisualStyleBackColor = true;
            this.btnVoir.Click += new System.EventHandler(this.btnVoir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnPraticien
            // 
            this.btnPraticien.Location = new System.Drawing.Point(154, 202);
            this.btnPraticien.Name = "btnPraticien";
            this.btnPraticien.Size = new System.Drawing.Size(200, 23);
            this.btnPraticien.TabIndex = 6;
            this.btnPraticien.Text = "Consulter un praticien";
            this.btnPraticien.UseVisualStyleBackColor = true;
            this.btnPraticien.Click += new System.EventHandler(this.btnPraticien_Click);
            // 
            // btnMedicament
            // 
            this.btnMedicament.Location = new System.Drawing.Point(154, 231);
            this.btnMedicament.Name = "btnMedicament";
            this.btnMedicament.Size = new System.Drawing.Size(200, 23);
            this.btnMedicament.TabIndex = 7;
            this.btnMedicament.Text = "Consulter un medicament";
            this.btnMedicament.UseVisualStyleBackColor = true;
            this.btnMedicament.Click += new System.EventHandler(this.btnMedicament_Click);
            // 
            // btnNewRapportRegion
            // 
            this.btnNewRapportRegion.Location = new System.Drawing.Point(154, 277);
            this.btnNewRapportRegion.Name = "btnNewRapportRegion";
            this.btnNewRapportRegion.Size = new System.Drawing.Size(208, 23);
            this.btnNewRapportRegion.TabIndex = 8;
            this.btnNewRapportRegion.Text = "Consulter les nouveaux rapports région";
            this.btnNewRapportRegion.UseVisualStyleBackColor = true;
            // 
            // btnHistoRapportRegion
            // 
            this.btnHistoRapportRegion.Location = new System.Drawing.Point(154, 306);
            this.btnHistoRapportRegion.Name = "btnHistoRapportRegion";
            this.btnHistoRapportRegion.Size = new System.Drawing.Size(208, 23);
            this.btnHistoRapportRegion.TabIndex = 9;
            this.btnHistoRapportRegion.Text = "Consulter l\'historique des rapports région";
            this.btnHistoRapportRegion.UseVisualStyleBackColor = true;
            // 
            // btnEnCours
            // 
            this.btnEnCours.Location = new System.Drawing.Point(154, 104);
            this.btnEnCours.Name = "btnEnCours";
            this.btnEnCours.Size = new System.Drawing.Size(200, 23);
            this.btnEnCours.TabIndex = 11;
            this.btnEnCours.Text = "Mes rapports en cours";
            this.btnEnCours.UseVisualStyleBackColor = true;
            this.btnEnCours.Click += new System.EventHandler(this.btnEnCours_Click);
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 411);
            this.Controls.Add(this.btnEnCours);
            this.Controls.Add(this.btnHistoRapportRegion);
            this.Controls.Add(this.btnNewRapportRegion);
            this.Controls.Add(this.btnMedicament);
            this.Controls.Add(this.btnPraticien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoir);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenuVisiteur";
            this.Text = "FrmMenuVisiteur";
            this.Load += new System.EventHandler(this.FrmMenuVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnVoir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPraticien;
        private System.Windows.Forms.Button btnMedicament;
        private System.Windows.Forms.Button btnNewRapportRegion;
        private System.Windows.Forms.Button btnHistoRapportRegion;
        private System.Windows.Forms.Button btnEnCours;
    }
}