namespace ChiffrageImp3D;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        FontLoader.LoadFontFromResource("ChiffrageImp3D.Resources.GUNPLAY.ttf");

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        btnImporter = new Button();
        txtBoxNomFichier = new TextBox();
        labelNomFichier = new Label();
        openFileDialog1 = new OpenFileDialog();
        labelPoids = new Label();
        textBoxPoids = new TextBox();
        labelTempsImpression = new Label();
        textBoxTempsImpression = new TextBox();
        buttonParametres = new Button();
        labelCoutMatiere = new Label();
        textBoxCoutMatiere = new TextBox();
        labelCoutAnnexes = new Label();
        textBoxCoutAnnexe = new TextBox();
        labelMainOeuvre = new Label();
        textBoxMainOeuvre = new TextBox();
        labelCoutGlobal = new Label();
        textBoxCoutGlobal = new TextBox();
        labelMarge = new Label();
        textBoxMarge = new TextBox();
        labelPrixPlateau = new Label();
        textBoxPrixPlateau = new TextBox();
        numericUpDown1 = new NumericUpDown();
        labelNbrePieces = new Label();
        panel1 = new Panel();
        labelPrixUnitaireValeur = new Label();
        labelPrixUnitaire = new Label();
        buttonActualiser = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // btnImporter
        // 
        btnImporter.Location = new Point(246, 53);
        btnImporter.Name = "btnImporter";
        btnImporter.Size = new Size(196, 34);
        btnImporter.TabIndex = 0;
        btnImporter.Text = "Importer Fichier";
        btnImporter.UseVisualStyleBackColor = true;
        btnImporter.Click += btnImporter_Click;
        // 
        // txtBoxNomFichier
        // 
        txtBoxNomFichier.Location = new Point(64, 126);
        txtBoxNomFichier.Name = "txtBoxNomFichier";
        txtBoxNomFichier.ReadOnly = true;
        txtBoxNomFichier.RightToLeft = RightToLeft.No;
        txtBoxNomFichier.Size = new Size(562, 26);
        txtBoxNomFichier.TabIndex = 1;
        // 
        // labelNomFichier
        // 
        labelNomFichier.Location = new Point(64, 104);
        labelNomFichier.Name = "labelNomFichier";
        labelNomFichier.Size = new Size(495, 20);
        labelNomFichier.TabIndex = 2;
        labelNomFichier.Text = "Nom du Fichier";
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        openFileDialog1.Filter = "Fichiers GCODE|*.gcode";
        openFileDialog1.FileOk += openFileDialog1_FileOk;
        // 
        // labelPoids
        // 
        labelPoids.AutoSize = true;
        labelPoids.Location = new Point(64, 229);
        labelPoids.Name = "labelPoids";
        labelPoids.Size = new Size(154, 19);
        labelPoids.TabIndex = 3;
        labelPoids.Text = "Plastique Consommé";
        labelPoids.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxPoids
        // 
        textBoxPoids.BackColor = SystemColors.Window;
        textBoxPoids.BorderStyle = BorderStyle.None;
        textBoxPoids.Location = new Point(246, 229);
        textBoxPoids.Name = "textBoxPoids";
        textBoxPoids.ReadOnly = true;
        textBoxPoids.Size = new Size(102, 19);
        textBoxPoids.TabIndex = 4;
        textBoxPoids.TextAlign = HorizontalAlignment.Right;
        // 
        // labelTempsImpression
        // 
        labelTempsImpression.AutoSize = true;
        labelTempsImpression.Location = new Point(64, 259);
        labelTempsImpression.Name = "labelTempsImpression";
        labelTempsImpression.Size = new Size(151, 19);
        labelTempsImpression.TabIndex = 5;
        labelTempsImpression.Text = "Temps d'Impression";
        labelTempsImpression.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxTempsImpression
        // 
        textBoxTempsImpression.BackColor = SystemColors.Window;
        textBoxTempsImpression.BorderStyle = BorderStyle.None;
        textBoxTempsImpression.Location = new Point(246, 259);
        textBoxTempsImpression.Name = "textBoxTempsImpression";
        textBoxTempsImpression.ReadOnly = true;
        textBoxTempsImpression.Size = new Size(102, 19);
        textBoxTempsImpression.TabIndex = 6;
        textBoxTempsImpression.TextAlign = HorizontalAlignment.Right;
        // 
        // buttonParametres
        // 
        buttonParametres.Image = Properties.Resources.png_clipart_computer_icons_symbol_settings_miscellaneous_desktop_wallpaper1;
        buttonParametres.Location = new Point(616, 12);
        buttonParametres.Name = "buttonParametres";
        buttonParametres.Size = new Size(57, 53);
        buttonParametres.TabIndex = 7;
        buttonParametres.UseVisualStyleBackColor = true;
        buttonParametres.Click += buttonParametres_Click;
        // 
        // labelCoutMatiere
        // 
        labelCoutMatiere.AutoSize = true;
        labelCoutMatiere.Location = new Point(64, 333);
        labelCoutMatiere.Name = "labelCoutMatiere";
        labelCoutMatiere.Size = new Size(100, 19);
        labelCoutMatiere.TabIndex = 8;
        labelCoutMatiere.Text = "Coût Matière";
        labelCoutMatiere.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxCoutMatiere
        // 
        textBoxCoutMatiere.BackColor = SystemColors.Window;
        textBoxCoutMatiere.BorderStyle = BorderStyle.None;
        textBoxCoutMatiere.Location = new Point(246, 333);
        textBoxCoutMatiere.Name = "textBoxCoutMatiere";
        textBoxCoutMatiere.ReadOnly = true;
        textBoxCoutMatiere.Size = new Size(102, 19);
        textBoxCoutMatiere.TabIndex = 9;
        textBoxCoutMatiere.TextAlign = HorizontalAlignment.Right;
        // 
        // labelCoutAnnexes
        // 
        labelCoutAnnexes.AutoSize = true;
        labelCoutAnnexes.Location = new Point(64, 365);
        labelCoutAnnexes.Name = "labelCoutAnnexes";
        labelCoutAnnexes.Size = new Size(106, 19);
        labelCoutAnnexes.TabIndex = 10;
        labelCoutAnnexes.Text = "Coût Annexes";
        labelCoutAnnexes.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxCoutAnnexe
        // 
        textBoxCoutAnnexe.BackColor = SystemColors.Window;
        textBoxCoutAnnexe.BorderStyle = BorderStyle.None;
        textBoxCoutAnnexe.Location = new Point(246, 365);
        textBoxCoutAnnexe.Name = "textBoxCoutAnnexe";
        textBoxCoutAnnexe.ReadOnly = true;
        textBoxCoutAnnexe.Size = new Size(102, 19);
        textBoxCoutAnnexe.TabIndex = 11;
        textBoxCoutAnnexe.TextAlign = HorizontalAlignment.Right;
        // 
        // labelMainOeuvre
        // 
        labelMainOeuvre.AutoSize = true;
        labelMainOeuvre.Location = new Point(64, 396);
        labelMainOeuvre.Name = "labelMainOeuvre";
        labelMainOeuvre.Size = new Size(144, 19);
        labelMainOeuvre.TabIndex = 12;
        labelMainOeuvre.Text = "Coût Main d'Oeuvre";
        labelMainOeuvre.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxMainOeuvre
        // 
        textBoxMainOeuvre.BackColor = SystemColors.Window;
        textBoxMainOeuvre.BorderStyle = BorderStyle.None;
        textBoxMainOeuvre.Location = new Point(246, 396);
        textBoxMainOeuvre.Name = "textBoxMainOeuvre";
        textBoxMainOeuvre.ReadOnly = true;
        textBoxMainOeuvre.Size = new Size(102, 19);
        textBoxMainOeuvre.TabIndex = 13;
        textBoxMainOeuvre.TextAlign = HorizontalAlignment.Right;
        // 
        // labelCoutGlobal
        // 
        labelCoutGlobal.AutoSize = true;
        labelCoutGlobal.Location = new Point(401, 365);
        labelCoutGlobal.Name = "labelCoutGlobal";
        labelCoutGlobal.Size = new Size(87, 19);
        labelCoutGlobal.TabIndex = 14;
        labelCoutGlobal.Text = "Coût Global";
        labelCoutGlobal.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxCoutGlobal
        // 
        textBoxCoutGlobal.BackColor = SystemColors.Window;
        textBoxCoutGlobal.BorderStyle = BorderStyle.None;
        textBoxCoutGlobal.Location = new Point(536, 365);
        textBoxCoutGlobal.Name = "textBoxCoutGlobal";
        textBoxCoutGlobal.ReadOnly = true;
        textBoxCoutGlobal.Size = new Size(102, 19);
        textBoxCoutGlobal.TabIndex = 15;
        textBoxCoutGlobal.TextAlign = HorizontalAlignment.Right;
        // 
        // labelMarge
        // 
        labelMarge.AutoSize = true;
        labelMarge.Location = new Point(64, 468);
        labelMarge.Name = "labelMarge";
        labelMarge.Size = new Size(53, 19);
        labelMarge.TabIndex = 16;
        labelMarge.Text = "Marge";
        labelMarge.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxMarge
        // 
        textBoxMarge.BackColor = SystemColors.Window;
        textBoxMarge.BorderStyle = BorderStyle.None;
        textBoxMarge.Location = new Point(246, 468);
        textBoxMarge.Name = "textBoxMarge";
        textBoxMarge.ReadOnly = true;
        textBoxMarge.Size = new Size(102, 19);
        textBoxMarge.TabIndex = 17;
        textBoxMarge.TextAlign = HorizontalAlignment.Right;
        // 
        // labelPrixPlateau
        // 
        labelPrixPlateau.AutoSize = true;
        labelPrixPlateau.Location = new Point(64, 530);
        labelPrixPlateau.Name = "labelPrixPlateau";
        labelPrixPlateau.Size = new Size(152, 19);
        labelPrixPlateau.TabIndex = 18;
        labelPrixPlateau.Text = "Prix Plateau Facturé";
        labelPrixPlateau.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxPrixPlateau
        // 
        textBoxPrixPlateau.BackColor = SystemColors.Window;
        textBoxPrixPlateau.BorderStyle = BorderStyle.None;
        textBoxPrixPlateau.Location = new Point(246, 530);
        textBoxPrixPlateau.Name = "textBoxPrixPlateau";
        textBoxPrixPlateau.ReadOnly = true;
        textBoxPrixPlateau.Size = new Size(102, 19);
        textBoxPrixPlateau.TabIndex = 19;
        textBoxPrixPlateau.TextAlign = HorizontalAlignment.Right;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(536, 227);
        numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(97, 26);
        numericUpDown1.TabIndex = 20;
        numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        // 
        // labelNbrePieces
        // 
        labelNbrePieces.AutoSize = true;
        labelNbrePieces.Location = new Point(401, 229);
        labelNbrePieces.Name = "labelNbrePieces";
        labelNbrePieces.Size = new Size(93, 19);
        labelNbrePieces.TabIndex = 21;
        labelNbrePieces.Text = "Nbre Pièces";
        labelNbrePieces.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.InactiveCaption;
        panel1.BorderStyle = BorderStyle.Fixed3D;
        panel1.Controls.Add(labelPrixUnitaireValeur);
        panel1.Controls.Add(labelPrixUnitaire);
        panel1.Location = new Point(401, 418);
        panel1.Name = "panel1";
        panel1.Size = new Size(268, 220);
        panel1.TabIndex = 22;
        // 
        // labelPrixUnitaireValeur
        // 
        labelPrixUnitaireValeur.AutoSize = true;
        labelPrixUnitaireValeur.Font = FontLoader.GetFont("GUNPLAY",22);
        labelPrixUnitaireValeur.ForeColor = Color.OrangeRed;
        labelPrixUnitaireValeur.Location = new Point(86, 110);
        labelPrixUnitaireValeur.Name = "labelPrixUnitaireValeur";
        labelPrixUnitaireValeur.Size = new Size(109, 46);
        labelPrixUnitaireValeur.TabIndex = 1;
        labelPrixUnitaireValeur.Text = "NDEF";
        labelPrixUnitaireValeur.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelPrixUnitaire
        // 
        labelPrixUnitaire.AutoSize = true;
        labelPrixUnitaire.Font = FontLoader.GetFont("GUNPLAY",16);
        labelPrixUnitaire.ForeColor = Color.OrangeRed;
        labelPrixUnitaire.Location = new Point(35, 36);
        labelPrixUnitaire.Name = "labelPrixUnitaire";
        labelPrixUnitaire.Size = new Size(209, 35);
        labelPrixUnitaire.TabIndex = 0;
        labelPrixUnitaire.Text = "PRIX UNITAIRE";
        // 
        // buttonActualiser
        // 
        buttonActualiser.Location = new Point(137, 589);
        buttonActualiser.Name = "buttonActualiser";
        buttonActualiser.Size = new Size(122, 34);
        buttonActualiser.TabIndex = 23;
        buttonActualiser.Text = "Recalculer";
        buttonActualiser.UseVisualStyleBackColor = true;
        buttonActualiser.Click += buttonActualiser_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(687, 660);
        Controls.Add(buttonActualiser);
        Controls.Add(panel1);
        Controls.Add(labelNbrePieces);
        Controls.Add(numericUpDown1);
        Controls.Add(textBoxPrixPlateau);
        Controls.Add(labelPrixPlateau);
        Controls.Add(textBoxMarge);
        Controls.Add(labelMarge);
        Controls.Add(textBoxCoutGlobal);
        Controls.Add(labelCoutGlobal);
        Controls.Add(textBoxMainOeuvre);
        Controls.Add(labelMainOeuvre);
        Controls.Add(textBoxCoutAnnexe);
        Controls.Add(labelCoutAnnexes);
        Controls.Add(textBoxCoutMatiere);
        Controls.Add(labelCoutMatiere);
        Controls.Add(buttonParametres);
        Controls.Add(textBoxTempsImpression);
        Controls.Add(labelTempsImpression);
        Controls.Add(textBoxPoids);
        Controls.Add(labelPoids);
        Controls.Add(txtBoxNomFichier);
        Controls.Add(labelNomFichier);
        Controls.Add(btnImporter);
        Font = FontLoader.GetFont("Gunplay", 9);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "2dCraft3d - Chiffrage";
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label labelNomFichier;
    private System.Windows.Forms.Button btnImporter;
    private System.Windows.Forms.TextBox txtBoxNomFichier;

    #endregion

    private OpenFileDialog openFileDialog1;
    private Label labelPoids;
    private TextBox textBoxPoids;
    private Label labelTempsImpression;
    private TextBox textBoxTempsImpression;
    private Button buttonParametres;
    private Label labelCoutMatiere;
    private TextBox textBoxCoutMatiere;
    private Label labelCoutAnnexes;
    private TextBox textBoxCoutAnnexe;
    private Label labelMainOeuvre;
    private TextBox textBoxMainOeuvre;
    private Label labelCoutGlobal;
    private TextBox textBoxCoutGlobal;
    private Label labelMarge;
    private TextBox textBoxMarge;
    private Label labelPrixPlateau;
    private TextBox textBoxPrixPlateau;
    private NumericUpDown numericUpDown1;
    private Label labelNbrePieces;
    private Panel panel1;
    private Label labelPrixUnitaire;
    private Label labelPrixUnitaireValeur;
    private Button buttonActualiser;
}