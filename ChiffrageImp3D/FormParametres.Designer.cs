namespace ChiffrageImp3D
{
    partial class FormParametres
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametres));
            buttonAccepter = new Button();
            buttonAnnuler = new Button();
            labelCoeffPerte = new Label();
            textBoxCoeffPertes = new TextBox();
            labelCoutElec = new Label();
            textBoxCoutElec = new TextBox();
            labelConsoMachine = new Label();
            textBoxConsoMachine = new TextBox();
            labelAmmortissementMachine = new Label();
            textBoxAmmortissementMachine = new TextBox();
            labelPrixMatiere = new Label();
            textBoxPrixMatiere = new TextBox();
            labelTempsMO = new Label();
            labelCoutMO = new Label();
            textBoxTempsMO = new TextBox();
            textBoxCoutMO = new TextBox();
            labelCotisationSociale = new Label();
            textBoxCotisationSociale = new TextBox();
            labelMarge = new Label();
            textBoxMarge = new TextBox();
            SuspendLayout();
            // 
            // buttonAccepter
            // 
            buttonAccepter.Font = FontLoader.GetFont("GUNPLAY",12);
            buttonAccepter.Location = new Point(375, 452);
            buttonAccepter.Name = "buttonAccepter";
            buttonAccepter.Size = new Size(123, 52);
            buttonAccepter.TabIndex = 0;
            buttonAccepter.Text = "Accepter";
            buttonAccepter.UseVisualStyleBackColor = true;
            buttonAccepter.Click += buttonAccepter_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Font = FontLoader.GetFont("GUNPLAY",12);
            buttonAnnuler.ForeColor = Color.Firebrick;
            buttonAnnuler.Location = new Point(246, 452);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(123, 52);
            buttonAnnuler.TabIndex = 1;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelCoeffPerte
            // 
            labelCoeffPerte.AutoSize = true;
            labelCoeffPerte.Font = FontLoader.GetFont("GUNPLAY",9);
            labelCoeffPerte.Location = new Point(31, 27);
            labelCoeffPerte.Name = "labelCoeffPerte";
            labelCoeffPerte.Size = new Size(100, 19);
            labelCoeffPerte.TabIndex = 4;
            labelCoeffPerte.Text = "Coeff Pertes";
            labelCoeffPerte.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCoeffPertes
            // 
            textBoxCoeffPertes.BorderStyle = BorderStyle.None;
            textBoxCoeffPertes.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxCoeffPertes.Location = new Point(207, 27);
            textBoxCoeffPertes.MaxLength = 5;
            textBoxCoeffPertes.Name = "textBoxCoeffPertes";
            textBoxCoeffPertes.Size = new Size(94, 19);
            textBoxCoeffPertes.TabIndex = 5;
            textBoxCoeffPertes.Text = "0,2";
            // 
            // labelCoutElec
            // 
            labelCoutElec.AutoSize = true;
            labelCoutElec.Font = FontLoader.GetFont("GUNPLAY",9);
            labelCoutElec.Location = new Point(31, 64);
            labelCoutElec.Name = "labelCoutElec";
            labelCoutElec.Size = new Size(103, 19);
            labelCoutElec.TabIndex = 6;
            labelCoutElec.Text = "Coût KWH (€)";
            labelCoutElec.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCoutElec
            // 
            textBoxCoutElec.BorderStyle = BorderStyle.None;
            textBoxCoutElec.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxCoutElec.Location = new Point(207, 64);
            textBoxCoutElec.Name = "textBoxCoutElec";
            textBoxCoutElec.Size = new Size(94, 19);
            textBoxCoutElec.TabIndex = 7;
            textBoxCoutElec.Text = "0,2";
            // 
            // labelConsoMachine
            // 
            labelConsoMachine.AutoSize = true;
            labelConsoMachine.Font = FontLoader.GetFont("GUNPLAY",9);
            labelConsoMachine.Location = new Point(31, 102);
            labelConsoMachine.Name = "labelConsoMachine";
            labelConsoMachine.Size = new Size(141, 19);
            labelConsoMachine.TabIndex = 8;
            labelConsoMachine.Text = "Conso Machine (W)";
            labelConsoMachine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxConsoMachine
            // 
            textBoxConsoMachine.BorderStyle = BorderStyle.None;
            textBoxConsoMachine.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxConsoMachine.Location = new Point(207, 102);
            textBoxConsoMachine.Name = "textBoxConsoMachine";
            textBoxConsoMachine.Size = new Size(94, 19);
            textBoxConsoMachine.TabIndex = 9;
            textBoxConsoMachine.Text = "0,2";
            // 
            // labelAmmortissementMachine
            // 
            labelAmmortissementMachine.AutoSize = true;
            labelAmmortissementMachine.Font = FontLoader.GetFont("GUNPLAY",9);
            labelAmmortissementMachine.Location = new Point(31, 142);
            labelAmmortissementMachine.Name = "labelAmmortissementMachine";
            labelAmmortissementMachine.Size = new Size(243, 19);
            labelAmmortissementMachine.TabIndex = 10;
            labelAmmortissementMachine.Text = "Ammortissement Machine / h (€)";
            labelAmmortissementMachine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxAmmortissementMachine
            // 
            textBoxAmmortissementMachine.BorderStyle = BorderStyle.None;
            textBoxAmmortissementMachine.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxAmmortissementMachine.Location = new Point(303, 142);
            textBoxAmmortissementMachine.Name = "textBoxAmmortissementMachine";
            textBoxAmmortissementMachine.Size = new Size(94, 19);
            textBoxAmmortissementMachine.TabIndex = 11;
            textBoxAmmortissementMachine.Text = "0,2";
            // 
            // labelPrixMatiere
            // 
            labelPrixMatiere.AutoSize = true;
            labelPrixMatiere.Font = FontLoader.GetFont("GUNPLAY",9);
            labelPrixMatiere.Location = new Point(31, 181);
            labelPrixMatiere.Name = "labelPrixMatiere";
            labelPrixMatiere.Size = new Size(147, 19);
            labelPrixMatiere.TabIndex = 12;
            labelPrixMatiere.Text = "Prix Matière (€/Kg)";
            labelPrixMatiere.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPrixMatiere
            // 
            textBoxPrixMatiere.BorderStyle = BorderStyle.None;
            textBoxPrixMatiere.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxPrixMatiere.Location = new Point(207, 181);
            textBoxPrixMatiere.Name = "textBoxPrixMatiere";
            textBoxPrixMatiere.Size = new Size(94, 19);
            textBoxPrixMatiere.TabIndex = 13;
            textBoxPrixMatiere.Text = "0,2";
            // 
            // labelTempsMO
            // 
            labelTempsMO.AutoSize = true;
            labelTempsMO.Font = FontLoader.GetFont("GUNPLAY",9);
            labelTempsMO.Location = new Point(31, 226);
            labelTempsMO.Name = "labelTempsMO";
            labelTempsMO.Size = new Size(181, 19);
            labelTempsMO.TabIndex = 14;
            labelTempsMO.Text = "Temps Main d'Oeuvre (h)";
            labelTempsMO.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCoutMO
            // 
            labelCoutMO.AutoSize = true;
            labelCoutMO.Font = FontLoader.GetFont("GUNPLAY",9);
            labelCoutMO.Location = new Point(31, 272);
            labelCoutMO.Name = "labelCoutMO";
            labelCoutMO.Size = new Size(183, 19);
            labelCoutMO.TabIndex = 15;
            labelCoutMO.Text = "Cout Main d'Oeuvre (€/h)";
            labelCoutMO.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTempsMO
            // 
            textBoxTempsMO.BorderStyle = BorderStyle.None;
            textBoxTempsMO.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxTempsMO.Location = new Point(246, 226);
            textBoxTempsMO.Name = "textBoxTempsMO";
            textBoxTempsMO.Size = new Size(94, 19);
            textBoxTempsMO.TabIndex = 16;
            textBoxTempsMO.Text = "0,2";
            // 
            // textBoxCoutMO
            // 
            textBoxCoutMO.BorderStyle = BorderStyle.None;
            textBoxCoutMO.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxCoutMO.Location = new Point(246, 272);
            textBoxCoutMO.Name = "textBoxCoutMO";
            textBoxCoutMO.Size = new Size(94, 19);
            textBoxCoutMO.TabIndex = 17;
            textBoxCoutMO.Text = "0,2";
            // 
            // labelCotisationSociale
            // 
            labelCotisationSociale.AutoSize = true;
            labelCotisationSociale.Font = FontLoader.GetFont("GUNPLAY",9);
            labelCotisationSociale.Location = new Point(31, 314);
            labelCotisationSociale.Name = "labelCotisationSociale";
            labelCotisationSociale.Size = new Size(170, 19);
            labelCotisationSociale.TabIndex = 18;
            labelCotisationSociale.Text = "Cotisation Sociales (%)";
            labelCotisationSociale.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCotisationSociale
            // 
            textBoxCotisationSociale.BorderStyle = BorderStyle.None;
            textBoxCotisationSociale.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxCotisationSociale.Location = new Point(246, 314);
            textBoxCotisationSociale.Name = "textBoxCotisationSociale";
            textBoxCotisationSociale.Size = new Size(94, 19);
            textBoxCotisationSociale.TabIndex = 19;
            textBoxCotisationSociale.Text = "0,2";
            // 
            // labelMarge
            // 
            labelMarge.AutoSize = true;
            labelMarge.Font = FontLoader.GetFont("GUNPLAY",9);
            labelMarge.Location = new Point(31, 358);
            labelMarge.Name = "labelMarge";
            labelMarge.Size = new Size(80, 19);
            labelMarge.TabIndex = 20;
            labelMarge.Text = "Marge (%)";
            labelMarge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxMarge
            // 
            textBoxMarge.BorderStyle = BorderStyle.None;
            textBoxMarge.Font = FontLoader.GetFont("GUNPLAY",9);
            textBoxMarge.Location = new Point(207, 358);
            textBoxMarge.Name = "textBoxMarge";
            textBoxMarge.Size = new Size(94, 19);
            textBoxMarge.TabIndex = 21;
            textBoxMarge.Text = "0,2";
            // 
            // FormParametres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonAnnuler;
            ClientSize = new Size(510, 516);
            ControlBox = false;
            Controls.Add(textBoxMarge);
            Controls.Add(labelMarge);
            Controls.Add(textBoxCotisationSociale);
            Controls.Add(labelCotisationSociale);
            Controls.Add(textBoxCoutMO);
            Controls.Add(textBoxTempsMO);
            Controls.Add(labelCoutMO);
            Controls.Add(labelTempsMO);
            Controls.Add(textBoxPrixMatiere);
            Controls.Add(labelPrixMatiere);
            Controls.Add(textBoxAmmortissementMachine);
            Controls.Add(labelAmmortissementMachine);
            Controls.Add(textBoxConsoMachine);
            Controls.Add(labelConsoMachine);
            Controls.Add(textBoxCoutElec);
            Controls.Add(labelCoutElec);
            Controls.Add(textBoxCoeffPertes);
            Controls.Add(labelCoeffPerte);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonAccepter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormParametres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parametres";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button buttonAccepter;
        private Button buttonAnnuler;
        private Label labelCoeffPerte;
        private TextBox textBoxCoeffPertes;
        private Label labelCoutElec;
        private TextBox textBoxCoutElec;
        private Label labelConsoMachine;
        private TextBox textBoxConsoMachine;
        private Label labelAmmortissementMachine;
        private TextBox textBoxAmmortissementMachine;
        private Label labelPrixMatiere;
        private TextBox textBoxPrixMatiere;
        private Label labelTempsMO;
        private Label labelCoutMO;
        private TextBox textBoxTempsMO;
        private TextBox textBoxCoutMO;
        private Label labelCotisationSociale;
        private TextBox textBoxCotisationSociale;
        private Label labelMarge;
        private TextBox textBoxMarge;
    }
}