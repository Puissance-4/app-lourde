namespace Application_Lourde
{
    partial class DetailFiche
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
            this.ListFraisHF = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.labelinfos = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labid = new System.Windows.Forms.Label();
            this.BtnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListFraisHF)).BeginInit();
            this.SuspendLayout();
            // 
            // ListFraisHF
            // 
            this.ListFraisHF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFraisHF.Location = new System.Drawing.Point(42, 59);
            this.ListFraisHF.Name = "ListFraisHF";
            this.ListFraisHF.Size = new System.Drawing.Size(706, 340);
            this.ListFraisHF.TabIndex = 0;
            this.ListFraisHF.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListFraisHF_RowHeaderMouseDoubleClick);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(136, 405);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // labelinfos
            // 
            this.labelinfos.AutoSize = true;
            this.labelinfos.Location = new System.Drawing.Point(565, 28);
            this.labelinfos.Name = "labelinfos";
            this.labelinfos.Size = new System.Drawing.Size(183, 13);
            this.labelinfos.TabIndex = 4;
            this.labelinfos.Text = "Double cliquer sur l\'entete d\'une ligne";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(25, 20);
            this.txtId.TabIndex = 5;
            // 
            // labid
            // 
            this.labid.AutoSize = true;
            this.labid.Location = new System.Drawing.Point(42, 27);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(33, 13);
            this.labid.TabIndex = 6;
            this.labid.Text = "Fiche";
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(392, 405);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(190, 23);
            this.BtnModifier.TabIndex = 7;
            this.BtnModifier.Text = "modifier lignes selectionnées";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_click);
            // 
            // DetailFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.labid);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelinfos);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.ListFraisHF);
            this.Name = "DetailFiche";
            this.Text = "DetailFiche";
            this.Load += new System.EventHandler(this.DetailFiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListFraisHF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListFraisHF;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label labelinfos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labid;
        private System.Windows.Forms.Button BtnModifier;
    }
}