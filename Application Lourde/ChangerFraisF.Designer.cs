namespace Application_Lourde
{
    partial class ChangerFraisF
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
            this.BoxPrixNuitee = new System.Windows.Forms.TextBox();
            this.BoxPrixMidi = new System.Windows.Forms.TextBox();
            this.BoxPrixRepasRelais = new System.Windows.Forms.TextBox();
            this.labelNuitee = new System.Windows.Forms.Label();
            this.labelPrixMidi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxPrixKm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BoxPrixNuitee
            // 
            this.BoxPrixNuitee.Location = new System.Drawing.Point(139, 47);
            this.BoxPrixNuitee.Name = "BoxPrixNuitee";
            this.BoxPrixNuitee.Size = new System.Drawing.Size(100, 20);
            this.BoxPrixNuitee.TabIndex = 0;
            // 
            // BoxPrixMidi
            // 
            this.BoxPrixMidi.Location = new System.Drawing.Point(401, 47);
            this.BoxPrixMidi.Name = "BoxPrixMidi";
            this.BoxPrixMidi.Size = new System.Drawing.Size(100, 20);
            this.BoxPrixMidi.TabIndex = 1;
            // 
            // BoxPrixRepasRelais
            // 
            this.BoxPrixRepasRelais.Location = new System.Drawing.Point(672, 47);
            this.BoxPrixRepasRelais.Name = "BoxPrixRepasRelais";
            this.BoxPrixRepasRelais.Size = new System.Drawing.Size(100, 20);
            this.BoxPrixRepasRelais.TabIndex = 2;
            // 
            // labelNuitee
            // 
            this.labelNuitee.AutoSize = true;
            this.labelNuitee.Location = new System.Drawing.Point(40, 50);
            this.labelNuitee.Name = "labelNuitee";
            this.labelNuitee.Size = new System.Drawing.Size(82, 13);
            this.labelNuitee.TabIndex = 3;
            this.labelNuitee.Text = "Prix de la nuitée";
            // 
            // labelPrixMidi
            // 
            this.labelPrixMidi.AutoSize = true;
            this.labelPrixMidi.Location = new System.Drawing.Point(293, 50);
            this.labelPrixMidi.Name = "labelPrixMidi";
            this.labelPrixMidi.Size = new System.Drawing.Size(89, 13);
            this.labelPrixMidi.TabIndex = 4;
            this.labelPrixMidi.Text = "Prix du repas midi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix d\'un repas relais";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(307, 146);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(672, 146);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(836, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prix km";
            // 
            // BoxPrixKm
            // 
            this.BoxPrixKm.Location = new System.Drawing.Point(898, 47);
            this.BoxPrixKm.Name = "BoxPrixKm";
            this.BoxPrixKm.Size = new System.Drawing.Size(100, 20);
            this.BoxPrixKm.TabIndex = 9;
            // 
            // ChangerFraisF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 219);
            this.Controls.Add(this.BoxPrixKm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPrixMidi);
            this.Controls.Add(this.labelNuitee);
            this.Controls.Add(this.BoxPrixRepasRelais);
            this.Controls.Add(this.BoxPrixMidi);
            this.Controls.Add(this.BoxPrixNuitee);
            this.Name = "ChangerFraisF";
            this.Text = "ChangerFraisF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxPrixNuitee;
        private System.Windows.Forms.TextBox BoxPrixMidi;
        private System.Windows.Forms.TextBox BoxPrixRepasRelais;
        private System.Windows.Forms.Label labelNuitee;
        private System.Windows.Forms.Label labelPrixMidi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxPrixKm;
    }
}