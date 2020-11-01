namespace PPEGSB
{
    partial class FPraticien
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
            this.labTitre = new System.Windows.Forms.Label();
            this.lvPraticien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btInfosTypePraticien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTitre
            // 
            this.labTitre.AutoSize = true;
            this.labTitre.Location = new System.Drawing.Point(111, 9);
            this.labTitre.Name = "labTitre";
            this.labTitre.Size = new System.Drawing.Size(35, 13);
            this.labTitre.TabIndex = 0;
            this.labTitre.Text = "label1";
            // 
            // lvPraticien
            // 
            this.lvPraticien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvPraticien.HideSelection = false;
            this.lvPraticien.Location = new System.Drawing.Point(64, 82);
            this.lvPraticien.Name = "lvPraticien";
            this.lvPraticien.Size = new System.Drawing.Size(951, 295);
            this.lvPraticien.TabIndex = 1;
            this.lvPraticien.UseCompatibleStateImageBehavior = false;
            this.lvPraticien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Champ";
            this.columnHeader1.Width = 191;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valeur";
            this.columnHeader2.Width = 408;
            // 
            // btInfosTypePraticien
            // 
            this.btInfosTypePraticien.Location = new System.Drawing.Point(857, 400);
            this.btInfosTypePraticien.Name = "btInfosTypePraticien";
            this.btInfosTypePraticien.Size = new System.Drawing.Size(158, 38);
            this.btInfosTypePraticien.TabIndex = 2;
            this.btInfosTypePraticien.Text = "Informations sur le  type de praticien";
            this.btInfosTypePraticien.UseVisualStyleBackColor = true;
            // 
            // FPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.btInfosTypePraticien);
            this.Controls.Add(this.lvPraticien);
            this.Controls.Add(this.labTitre);
            this.Name = "FPraticien";
            this.Text = "Praticien";
            this.Load += new System.EventHandler(this.FPraticien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitre;
        private System.Windows.Forms.ListView lvPraticien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btInfosTypePraticien;
    }
}