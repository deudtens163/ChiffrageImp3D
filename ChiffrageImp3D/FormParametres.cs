using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ChiffrageImp3D
{
    public partial class FormParametres : Form
    {
        private Dictionary<string, TextBox> parametres;
        private Dictionary<TextBox, Func<string, (bool IsValid, string ErrorMessage)>> reglesValidation;
        private ErrorProvider errorProvider1 = new ErrorProvider();

        public FormParametres()
        {
            InitializeComponent();

            parametres = new Dictionary<string, TextBox>
            {
                { "coeffPertes", textBoxCoeffPertes },
                { "ammortissementMachineHoraire", textBoxAmmortissementMachine },
                { "consoMachine", textBoxConsoMachine },
                { "tauxCotisation", textBoxCotisationSociale },
                { "CoutkWH", textBoxCoutElec },
                { "tauxHoraireMO", textBoxCoutMO },
                { "tauxMarge", textBoxMarge },
                { "tempsMO", textBoxTempsMO },
                { "prixMatiere", textBoxPrixMatiere }
            };

            reglesValidation = new Dictionary<TextBox, Func<string, (bool, string)>>()
            {
                { textBoxCoeffPertes, ValiderDecimal },
                { textBoxAmmortissementMachine, ValiderDecimal },
                { textBoxConsoMachine, ValiderDecimal },
                { textBoxCotisationSociale, ValiderPourcentage },
                { textBoxCoutElec, ValiderDecimal },
                { textBoxCoutMO, ValiderDecimal },
                { textBoxMarge, ValiderPourcentage },
                { textBoxTempsMO, ValiderDecimal },
                { textBoxPrixMatiere, ValiderDecimal }
            };

            foreach (var tb in reglesValidation.Keys)
            {
                tb.Validating += TextBox_Validating;
            }

            ChargerParametres();

        }

        private void ChargerParametres()
        {
            var doc = XDocument.Load("config.xml");
            foreach (var param in parametres)
            {
                param.Value.Text = (string)doc.Root.Element(param.Key);
            }
        }

        private void buttonAccepter_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) // force la validation de tous les contrôles
                return;

            var doc = XDocument.Load("config.xml");
            foreach (var param in parametres)
            {
                doc.Root.SetElementValue(param.Key, param.Value.Text);
            }

            doc.Save("config.xml");
            this.Close();
        }

        // Validation des données

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var textBox = sender as TextBox;

            if (reglesValidation.TryGetValue(textBox, out var regle))
            {
                var (isValid, message) = regle(textBox.Text);
                if (!isValid)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(textBox, message);
                }
                else
                {
                    errorProvider1.SetError(textBox, "");
                }
            }
        }

        private (bool, string) ValiderDecimal(string valeur)
        {
            if (string.IsNullOrWhiteSpace(valeur))
                return (false, "Veuillez entrer une valeur !");
            if (!decimal.TryParse(valeur, out _))
                return (false, "Veuillez entrer un nombre décimal valide !");
            return (true, "");
        }

        private (bool, string) ValiderPourcentage(string valeur)
        {
            if (!decimal.TryParse(valeur, out var nombre))
                return (false, "Pourcentage invalide !");
            if (nombre < 0)
                return (false, "Le pourcentage doit être positif !");
            return (true, "");
        }

    }
}
