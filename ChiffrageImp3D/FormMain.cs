using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;

namespace ChiffrageImp3D;

public partial class FormMain : Form
{
    public double coutMatiere;
    public double coutAnnexe;
    public double coutMainDOeuvre;
    public double coutGlobal;
    public double marge;
    public double prixPlateau;
    public string tmpTauxCotisation;

    private Dictionary<string, double> parametres;

    public FormMain()
    {
        InitializeComponent();

    }

    private void btnImporter_Click(object sender, EventArgs e)
    {
        openFileDialog1.ShowDialog();
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
        txtBoxNomFichier.Text = openFileDialog1.SafeFileName;

        RecupPoidsPlastique();
        RecupTempsImpression();
        openFileDialog1.Dispose();

        MettreAJourCalculs();
    }

    private void MettreAJourCalculs()
    {
        parametres = ChargerParametres();

        CoutMatiere();
        CoutAnnexes();
        CoutMainDOeuvre();
        CoutGlobal();
        Marge();
        PrixPlateau();
        PrixUnitaire();
    }

    // Lecture des paramètres du fichier config.xml avec gestion d'erreurs
    private Dictionary<string, double> ChargerParametres()
    {
        var valeurs = new Dictionary<string, double>();

        try
        {
            var doc = XDocument.Load("config.xml");

            foreach (var el in doc.Root.Elements())
            {
                if (double.TryParse(el.Value.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var val))
                    valeurs[el.Name.LocalName] = val;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors du chargement des paramètres :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return valeurs;
    }

    private static string FormaterDevise(double valeur)
    {
        return valeur.ToString("C", new System.Globalization.CultureInfo("fr-FR"));
    }

    private void RecupPoidsPlastique()
    {
        using var reader = new StreamReader(openFileDialog1.OpenFile());
        string ligne;
        const string tag = "; total filament used [g] = ";

        while ((ligne = reader.ReadLine()) != null)
        {
            if (ligne.Contains(tag))
            {
                string poidsStr = ligne.Substring(tag.Length).Replace(".", ",");
                textBoxPoids.Text = poidsStr + " g";
                break;
            }
        }
    }

    private void RecupTempsImpression()
    {
        using var reader = new StreamReader(openFileDialog1.OpenFile());
        string ligne;
        const string tag = "; estimated printing time (normal mode) = ";

        while ((ligne = reader.ReadLine()) != null)
        {
            if (ligne.Contains(tag))
            {
                string temps = ligne.Substring(tag.Length);
                textBoxTempsImpression.Text = temps;
                break;
            }
        }
    }

    private double ConvertTempsEnHeures(string temps)
    {
        int heures = 0, minutes = 0, secondes = 0;

        if (temps.Contains("h"))
        {
            var splitH = temps.Split("h");
            heures = int.Parse(splitH[0]);
            temps = splitH[1];
        }

        if (temps.Contains("m"))
        {
            var splitM = temps.Split("m");
            minutes = int.Parse(splitM[0]);
            temps = splitM[1];
        }

        if (temps.Contains("s"))
        {
            var splitS = temps.Split("s");
            secondes = int.Parse(splitS[0]);
        }

        return heures + minutes / 60.0 + secondes / 3600.0;
    }

    private double CalculCoutEnergie(double temps)
    {
        return temps * parametres["CoutkWH"] * parametres["consoMachine"] / 1000;
    }

    private double CalculAmmortissement(double temps)
    {
        return temps * parametres["ammortissementMachineHoraire"];
    }

    private void CoutMatiere()
    {
        var poidsStr = textBoxPoids.Text.Replace("g", "").Trim();
        double poids = double.Parse(poidsStr.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

        coutMatiere = ((parametres["prixMatiere"] * poids) * (1 + parametres["coeffPertes"])) / 1000;

        textBoxCoutMatiere.Text = FormaterDevise(coutMatiere);
    }

    private void CoutAnnexes()
    {
        double temps = ConvertTempsEnHeures(textBoxTempsImpression.Text);

        double coutEnergie = CalculCoutEnergie(temps);
        double coutAmmortissement = CalculAmmortissement(temps);

        coutAnnexe = (coutEnergie + coutAmmortissement) * (1 + parametres["coeffPertes"]);

        textBoxCoutAnnexe.Text = FormaterDevise(coutAnnexe);
    }

    private void CoutMainDOeuvre()
    {
        coutMainDOeuvre = parametres["tempsMO"] * parametres["tauxHoraireMO"];
        textBoxMainOeuvre.Text = FormaterDevise(coutMainDOeuvre);
    }

    private void CoutGlobal()
    {
        tmpTauxCotisation = parametres["tauxCotisation"].ToString();
        coutGlobal = (coutMatiere + coutAnnexe + coutMainDOeuvre) / (1 - parametres["tauxCotisation"] / 100);
        textBoxCoutGlobal.Text = FormaterDevise(coutGlobal);
    }

    private void Marge()
    {
        marge = coutGlobal * parametres["tauxMarge"] / 100;
        textBoxMarge.Text = FormaterDevise(marge);
    }

    private void PrixPlateau()
    {
        prixPlateau = coutGlobal + marge / (1 - parametres["tauxCotisation"] / 100);
        textBoxPrixPlateau.Text = FormaterDevise(prixPlateau);
    }

    private void PrixUnitaire()
    {
        double prixUnitaire = prixPlateau / (double)numericUpDown1.Value;
        labelPrixUnitaireValeur.Text = FormaterDevise(prixUnitaire);
    }

    private void buttonParametres_Click(object sender, EventArgs e)
    {
        var parametresForm = new FormParametres();
        parametresForm.ShowDialog();
        buttonActualiser.BackColor = Color.IndianRed;
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        PrixUnitaire();
    }

    private void buttonActualiser_Click(object sender, EventArgs e)
    {
        buttonActualiser.BackColor = SystemColors.Control;
        if (string.IsNullOrWhiteSpace(txtBoxNomFichier.Text))
        {
            MessageBox.Show("Aucun fichier chargé !\nVeuillez charger un fichier gcode" , "Erreur Fichier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            MettreAJourCalculs();
        }
    }
}