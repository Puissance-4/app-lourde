namespace Application_Lourde
{
    partial class FormFiche
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
            this.label_NomClient = new System.Windows.Forms.Label();
            this.textBox_NomClient = new System.Windows.Forms.TextBox();
            this.comboBox_Mois = new System.Windows.Forms.ComboBox();
            this.label_Mois = new System.Windows.Forms.Label();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.button_Cloture = new System.Windows.Forms.Button();
            this.listView_Fiches = new System.Windows.Forms.ListView();
            this.Button_validee = new System.Windows.Forms.Button();
            this.Button_Remboursee = new System.Windows.Forms.Button();
            this.Button_Mep = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            this.ListViewFraisHF = new System.Windows.Forms.ListView();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_NomClient
            // 
            this.label_NomClient.AutoSize = true;
            this.label_NomClient.Location = new System.Drawing.Point(22, 69);
            this.label_NomClient.Name = "label_NomClient";
            this.label_NomClient.Size = new System.Drawing.Size(89, 13);
            this.label_NomClient.TabIndex = 0;
            this.label_NomClient.Text = "Nom du visiteur : ";
            // 
            // textBox_NomClient
            // 
            this.textBox_NomClient.Location = new System.Drawing.Point(117, 65);
            this.textBox_NomClient.Name = "textBox_NomClient";
            this.textBox_NomClient.Size = new System.Drawing.Size(100, 20);
            this.textBox_NomClient.TabIndex = 1;
            // 
            // comboBox_Mois
            // 
            this.comboBox_Mois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mois.FormattingEnabled = true;
            this.comboBox_Mois.Location = new System.Drawing.Point(281, 66);
            this.comboBox_Mois.Name = "comboBox_Mois";
            this.comboBox_Mois.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Mois.TabIndex = 2;
            // 
            // label_Mois
            // 
            this.label_Mois.AutoSize = true;
            this.label_Mois.Location = new System.Drawing.Point(237, 69);
            this.label_Mois.Name = "label_Mois";
            this.label_Mois.Size = new System.Drawing.Size(38, 13);
            this.label_Mois.TabIndex = 3;
            this.label_Mois.Text = "Mois : ";
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.Location = new System.Drawing.Point(429, 65);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_Rechercher.TabIndex = 4;
            this.button_Rechercher.Text = "Rechercher";
            this.button_Rechercher.UseVisualStyleBackColor = true;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // button_Cloture
            // 
            this.button_Cloture.Location = new System.Drawing.Point(264, 452);
            this.button_Cloture.Name = "button_Cloture";
            this.button_Cloture.Size = new System.Drawing.Size(165, 23);
            this.button_Cloture.TabIndex = 5;
            this.button_Cloture.Text = "Clôturer les fiches sélectionnées";
            this.button_Cloture.UseVisualStyleBackColor = true;
            this.button_Cloture.Visible = false;
            this.button_Cloture.Click += new System.EventHandler(this.Button_Cloture_Click);
            // 
            // listView_Fiches
            // 
            this.listView_Fiches.HideSelection = false;
            this.listView_Fiches.Location = new System.Drawing.Point(12, 106);
            this.listView_Fiches.Name = "listView_Fiches";
            this.listView_Fiches.Size = new System.Drawing.Size(291, 273);
            this.listView_Fiches.TabIndex = 6;
            this.listView_Fiches.UseCompatibleStateImageBehavior = false;
            this.listView_Fiches.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Fiches_MouseDoubleClick);
            // 
            // Button_validee
            // 
            this.Button_validee.Location = new System.Drawing.Point(25, 452);
            this.Button_validee.Name = "Button_validee";
            this.Button_validee.Size = new System.Drawing.Size(184, 23);
            this.Button_validee.TabIndex = 7;
            this.Button_validee.Text = "Valider les fiches sélectionnées";
            this.Button_validee.UseVisualStyleBackColor = true;
            this.Button_validee.Visible = false;
            this.Button_validee.Click += new System.EventHandler(this.Button_Valider);
            // 
            // Button_Remboursee
            // 
            this.Button_Remboursee.Location = new System.Drawing.Point(251, 481);
            this.Button_Remboursee.Name = "Button_Remboursee";
            this.Button_Remboursee.Size = new System.Drawing.Size(215, 23);
            this.Button_Remboursee.TabIndex = 9;
            this.Button_Remboursee.Text = "Rembourser les fiches sélectionnées";
            this.Button_Remboursee.UseVisualStyleBackColor = true;
            this.Button_Remboursee.Visible = false;
            this.Button_Remboursee.Click += new System.EventHandler(this.Button_Remboursee_Click);
            // 
            // Button_Mep
            // 
            this.Button_Mep.Location = new System.Drawing.Point(12, 481);
            this.Button_Mep.Name = "Button_Mep";
            this.Button_Mep.Size = new System.Drawing.Size(224, 23);
            this.Button_Mep.TabIndex = 10;
            this.Button_Mep.Text = "Mettre en paiment les fiches sélectionnées";
            this.Button_Mep.UseVisualStyleBackColor = true;
            this.Button_Mep.Visible = false;
            this.Button_Mep.Click += new System.EventHandler(this.Button_Mep_Click);
            // 
            // btnretour
            // 
            this.btnretour.Location = new System.Drawing.Point(533, 66);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(75, 23);
            this.btnretour.TabIndex = 11;
            this.btnretour.Text = "Retour";
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.Btnretour_Click);
            // 
            // ListViewFraisHF
            // 
            this.ListViewFraisHF.HideSelection = false;
            this.ListViewFraisHF.Location = new System.Drawing.Point(624, 106);
            this.ListViewFraisHF.Name = "ListViewFraisHF";
            this.ListViewFraisHF.Size = new System.Drawing.Size(290, 273);
            this.ListViewFraisHF.TabIndex = 12;
            this.ListViewFraisHF.UseCompatibleStateImageBehavior = false;
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(682, 452);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(75, 23);
            this.BtnModifier.TabIndex = 13;
            this.BtnModifier.Text = "Modifier frais ";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // FormFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 533);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.ListViewFraisHF);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.Button_Mep);
            this.Controls.Add(this.Button_Remboursee);
            this.Controls.Add(this.Button_validee);
            this.Controls.Add(this.listView_Fiches);
            this.Controls.Add(this.button_Cloture);
            this.Controls.Add(this.button_Rechercher);
            this.Controls.Add(this.label_Mois);
            this.Controls.Add(this.comboBox_Mois);
            this.Controls.Add(this.textBox_NomClient);
            this.Controls.Add(this.label_NomClient);
            this.Name = "FormFiche";
            this.Text = "FormFiche";
            this.Load += new System.EventHandler(this.FormFiche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NomClient;
        private System.Windows.Forms.TextBox textBox_NomClient;
        private System.Windows.Forms.ComboBox comboBox_Mois;
        private System.Windows.Forms.Label label_Mois;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.Button button_Cloture;
        private System.Windows.Forms.ListView listView_Fiches;
        private System.Windows.Forms.Button Button_validee;
        private System.Windows.Forms.Button Button_Remboursee;
        private System.Windows.Forms.Button Button_Mep;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.ListView ListViewFraisHF;
        private System.Windows.Forms.Button BtnModifier;
    }
}