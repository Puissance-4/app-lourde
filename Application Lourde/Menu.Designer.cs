namespace Application_Lourde
{
    partial class Menu
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
            this.BtnModifPrixFraisF = new System.Windows.Forms.Button();
            this.BtnChoixDuVis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnModifPrixFraisF
            // 
            this.BtnModifPrixFraisF.Location = new System.Drawing.Point(117, 168);
            this.BtnModifPrixFraisF.Name = "BtnModifPrixFraisF";
            this.BtnModifPrixFraisF.Size = new System.Drawing.Size(212, 23);
            this.BtnModifPrixFraisF.TabIndex = 0;
            this.BtnModifPrixFraisF.Text = "Modifier les prix Forfaitisés";
            this.BtnModifPrixFraisF.UseVisualStyleBackColor = true;
            this.BtnModifPrixFraisF.Click += new System.EventHandler(this.BtnModifPrixFraisF_Click);
            // 
            // BtnChoixDuVis
            // 
            this.BtnChoixDuVis.Location = new System.Drawing.Point(459, 168);
            this.BtnChoixDuVis.Name = "BtnChoixDuVis";
            this.BtnChoixDuVis.Size = new System.Drawing.Size(231, 23);
            this.BtnChoixDuVis.TabIndex = 1;
            this.BtnChoixDuVis.Text = "Choix du visiteur";
            this.BtnChoixDuVis.UseVisualStyleBackColor = true;
            this.BtnChoixDuVis.Click += new System.EventHandler(this.BtnChoixDuVis_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnChoixDuVis);
            this.Controls.Add(this.BtnModifPrixFraisF);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnModifPrixFraisF;
        private System.Windows.Forms.Button BtnChoixDuVis;
    }
}