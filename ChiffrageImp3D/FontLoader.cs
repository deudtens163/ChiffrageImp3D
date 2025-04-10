using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

public class FontLoader
{
    // Collection pour stocker nos polices chargées
    private static PrivateFontCollection _privateFontCollection = new PrivateFontCollection();

    // Méthode pour charger la police depuis les ressources
    public static void LoadFontFromResource(string resourcePath)
    {
        try
        {
            // Obtenir l'assembly actuel
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Extraire la police vers un fichier temporaire
            string tempFontPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".ttf");

            using (Stream resourceStream = assembly.GetManifestResourceStream(resourcePath))
            {
                if (resourceStream == null)
                {
                    Console.WriteLine($"Police non trouvée: {resourcePath}");

                    // Afficher toutes les ressources disponibles pour aider au débogage
                    foreach (string name in assembly.GetManifestResourceNames())
                    {
                        Console.WriteLine($"Ressource disponible: {name}");
                    }

                    return;
                }

                using (FileStream fileStream = new FileStream(tempFontPath, FileMode.Create))
                {
                    resourceStream.CopyTo(fileStream);
                }
            }

            // Charger la police depuis le fichier temporaire
            _privateFontCollection.AddFontFile(tempFontPath);

            // On peut supprimer le fichier temporaire une fois la police chargée
            // File.Delete(tempFontPath); // Commenter cette ligne si vous voulez conserver le fichier pour debug

            Console.WriteLine($"Police chargée avec succès: {_privateFontCollection.Families[_privateFontCollection.Families.Length - 1].Name}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur lors du chargement de la police: {ex.Message}");
        }
    }

    // Obtenir une police chargée par son nom
    public static Font GetFont(string fontName, float size, FontStyle style = FontStyle.Regular)
    {
        foreach (FontFamily family in _privateFontCollection.Families)
        {
            if (family.Name.Equals(fontName, StringComparison.OrdinalIgnoreCase))
            {
                return new Font(family, size, style);
            }
        }

        // Police non trouvée, on retourne une police par défaut
        return new Font(FontFamily.GenericSansSerif, size, style);
    }
}