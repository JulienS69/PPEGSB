namespace PPEGSB
{
    partial class FVisiteurs
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
            this.lvVisiteurs = new System.Windows.Forms.ListView();
            this.matricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateEmbauche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvVisiteurs
            // 
            this.lvVisiteurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matricule,
            this.nom,
            this.prenom,
            this.adresse,
            this.cp,
            this.ville,
            this.dateEmbauche});
            this.lvVisiteurs.HideSelection = false;
            this.lvVisiteurs.Location = new System.Drawing.Point(22, 27);
            this.lvVisiteurs.Name = "lvVisiteurs";
            this.lvVisiteurs.Size = new System.Drawing.Size(1050, 388);
            this.lvVisiteurs.TabIndex = 0;
            this.lvVisiteurs.UseCompatibleStateImageBehavior = false;
            this.lvVisiteurs.View = System.Windows.Forms.View.Details;
            // 
            // matricule
            // 
            this.matricule.Text = "Matricule";
            this.matricule.Width = 150;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 150;
            // 
            // prenom
            // 
            this.prenom.Text = "Prénom";
            this.prenom.Width = 150;
            // 
            // adresse
            // 
            this.adresse.Text = "Adresse";
            this.adresse.Width = 150;
            // 
            // cp
            // 
            this.cp.Text = "Code Postal";
            this.cp.Width = 150;
            // 
            // ville
            // 
            this.ville.Text = "Ville";
            this.ville.Width = 150;
            // 
            // dateEmbauche
            // 
            this.dateEmbauche.Text = "Date d\'Embauche";
            this.dateEmbauche.Width = 150;
            // 
            // FVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 448);
            this.Controls.Add(this.lvVisiteurs);
            this.Name = "FVisiteurs";
            this.Text = "FVisiteurs";
            this.Load += new System.EventHandler(this.FVisiteurs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVisiteurs;
        private System.Windows.Forms.ColumnHeader matricule;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader cp;
        private System.Windows.Forms.ColumnHeader ville;
        private System.Windows.Forms.ColumnHeader dateEmbauche;
    }
}