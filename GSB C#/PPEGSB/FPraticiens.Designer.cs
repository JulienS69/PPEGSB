namespace PPEGSB
{
    partial class FPraticiens
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
            this.lvPraticiens = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coefNotoriete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvPraticiens
            // 
            this.lvPraticiens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.nom,
            this.prenom,
            this.adresse,
            this.codePostal,
            this.ville,
            this.coefNotoriete,
            this.codeType});
            this.lvPraticiens.HideSelection = false;
            this.lvPraticiens.Location = new System.Drawing.Point(7, 53);
            this.lvPraticiens.Name = "lvPraticiens";
            this.lvPraticiens.Size = new System.Drawing.Size(1000, 488);
            this.lvPraticiens.TabIndex = 0;
            this.lvPraticiens.UseCompatibleStateImageBehavior = false;
            this.lvPraticiens.View = System.Windows.Forms.View.Details;
            this.lvPraticiens.Click += new System.EventHandler(this.lvPraticiens_Click);
            // 
            // num
            // 
            this.num.Text = "Numéro";
            this.num.Width = 125;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 125;
            // 
            // prenom
            // 
            this.prenom.Text = "Prénom";
            this.prenom.Width = 125;
            // 
            // adresse
            // 
            this.adresse.Text = "Adresse";
            this.adresse.Width = 125;
            // 
            // codePostal
            // 
            this.codePostal.Text = "Code Postal";
            this.codePostal.Width = 125;
            // 
            // ville
            // 
            this.ville.Text = "Ville";
            this.ville.Width = 125;
            // 
            // coefNotoriete
            // 
            this.coefNotoriete.Text = "Coefficient de notoriété";
            this.coefNotoriete.Width = 125;
            // 
            // codeType
            // 
            this.codeType.Text = "Code du type de praticien";
            this.codeType.Width = 125;
            // 
            // FPraticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 562);
            this.Controls.Add(this.lvPraticiens);
            this.Name = "FPraticiens";
            this.Text = "FPraticiens";
            this.Load += new System.EventHandler(this.FPraticiens_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPraticiens;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader codePostal;
        private System.Windows.Forms.ColumnHeader ville;
        private System.Windows.Forms.ColumnHeader coefNotoriete;
        private System.Windows.Forms.ColumnHeader codeType;
    }
}