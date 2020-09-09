namespace PPEGSB
{
    partial class FMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rapportVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.praticienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccesEspaceConnexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportVisiteToolStripMenuItem,
            this.visiteursToolStripMenuItem,
            this.praticienToolStripMenuItem,
            this.médicamentToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1398, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rapportVisiteToolStripMenuItem
            // 
            this.rapportVisiteToolStripMenuItem.Name = "rapportVisiteToolStripMenuItem";
            this.rapportVisiteToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.rapportVisiteToolStripMenuItem.Text = "Rapport Visite";
            // 
            // visiteursToolStripMenuItem
            // 
            this.visiteursToolStripMenuItem.Name = "visiteursToolStripMenuItem";
            this.visiteursToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.visiteursToolStripMenuItem.Text = "Visiteur";
            // 
            // praticienToolStripMenuItem
            // 
            this.praticienToolStripMenuItem.Name = "praticienToolStripMenuItem";
            this.praticienToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.praticienToolStripMenuItem.Text = "Praticien";
            // 
            // médicamentToolStripMenuItem
            // 
            this.médicamentToolStripMenuItem.Name = "médicamentToolStripMenuItem";
            this.médicamentToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.médicamentToolStripMenuItem.Text = "Médicament";
            this.médicamentToolStripMenuItem.Click += new System.EventHandler(this.médicamentToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem1});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.aProposToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem1
            // 
            this.aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            this.aProposToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.aProposToolStripMenuItem1.Text = "A propos";
            this.aProposToolStripMenuItem1.Click += new System.EventHandler(this.aProposToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterLapplicationToolStripMenuItem});
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // quitterLapplicationToolStripMenuItem
            // 
            this.quitterLapplicationToolStripMenuItem.Name = "quitterLapplicationToolStripMenuItem";
            this.quitterLapplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.quitterLapplicationToolStripMenuItem.Text = "Se Déconnecter";
            this.quitterLapplicationToolStripMenuItem.Click += new System.EventHandler(this.quitterLapplicationToolStripMenuItem_Click);
            // 
            // AccesEspaceConnexion
            // 
            this.AccesEspaceConnexion.AutoSize = true;
            this.AccesEspaceConnexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccesEspaceConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccesEspaceConnexion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccesEspaceConnexion.Location = new System.Drawing.Point(1031, 44);
            this.AccesEspaceConnexion.Name = "AccesEspaceConnexion";
            this.AccesEspaceConnexion.Size = new System.Drawing.Size(355, 25);
            this.AccesEspaceConnexion.TabIndex = 2;
            this.AccesEspaceConnexion.Text = "Bienvenue dans votre espace personnel";
            // 
            // FMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1398, 562);
            this.Controls.Add(this.AccesEspaceConnexion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application GSB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem praticienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLapplicationToolStripMenuItem;
        private System.Windows.Forms.Label AccesEspaceConnexion;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rapportVisiteToolStripMenuItem;
    }
}