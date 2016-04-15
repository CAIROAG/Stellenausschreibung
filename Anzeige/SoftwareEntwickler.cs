using System;
using System.Collections.Generic;
using System.Text;

namespace Stellenausschreibung
{
    // Q: Why do Java developers wear glasses?
    // A: Because they can't C#

    // Interessierte Bewerber sollten mit den folgenden Zeilen etwas anfangen können. 
    // Fachinformatiker sollten etwas genauer hinsehen :-)
    public class SoftwareEntwickler
    {
        public static void Main(string[] args)
        {
            var deinProfil = new Profil
            {
                MindestBerufserfahrungInJahren = 1,
                HatInformatikStudiert = true,
                IstFachInformatiker = true,
                HatDotNetErfahrung = true,
                HatCSharpErfahrung = true,
                HatSqlKenntnisse = true,
                HatObjectRelationalMapperErfahrung = true,
                HatBusinessLayerErfharung = true,
                HatModelViewControllerErfahrung = true,
                HatWebServiceErfahrung = true,
                HatUserInterfaceErfahrung = true,
                IstBegeisterungsfähig = true, 
                IstTeamfähig = true,
                IstKreativ = true
            };

            var unserUmfeld = new Umfeld
            {
                EinsatzOrt = "Mannheim",
                Angebot = new List<string>
                {
                    "spannende Aufgaben",
                    "individuelle Entwicklungsmöglichkeiten",
                    "engagiertes Team",
                    "agile Softwareentwicklung",
                    "hervorrangende Weiterbildungsmöglichkeiten",
                    "familiäres Betriebsklima",
                    "kreatives Arbeiten",
                    "Work-Life-Balance",
                    "Gewinnbeteiligung nach dem Motto 'Teile und Gewinne'",
                    "offene und faire Kommunikation",
                    "und natürlich guten Kaffee."
                },
                BewerbungAn = new Adresse
                {
                    Name = "CAIRO AG",
                    Zuständig = "Wolfram Theymann",
                    HomeUrl = "http://www.cairo.ag/karriere/",
                    Strasse = "Voltastraße 19-21",
                    Postleitzahl = "68199", Ort = "Mannheim",
                    EMail = "wolfram.theymann@cairo.ag", Telefon = "0621-867510"
                },
                IstInteressant = true
            };

            if (deinProfil.HatAnforderungenErfüllt && unserUmfeld.IstInteressant)
            {
                Bewerben(unserUmfeld);
            }
            else
            {
                Console.WriteLine("nicht aufgeben... :-)");
            }
        }

        private static void Bewerben(Umfeld unserUmfeld)
        {


            string[] angaben = unserUmfeld.Angebot.ToArray();
            for (int i = 0; i < angaben.Length; i++)
            {
                angaben[i] = " - " + angaben[i];
            }
            string angebot = string.Join(Environment.NewLine, angaben);
            
            var ausgabeText = new StringBuilder();

            ausgabeText.Append("Vielen Dank für dein Intresse.");
            ausgabeText.Append($"{Environment.NewLine}{Environment.NewLine}");
            ausgabeText.Append("Wir, das sympatische Softwareentwicklungs-Team von ");
            ausgabeText.Append($"{unserUmfeld.BewerbungAn.Name} bieten: {Environment.NewLine}");
            ausgabeText.Append($"{angebot}{Environment.NewLine}{Environment.NewLine}");
            ausgabeText.Append("Weitere Informationen unter: ");
            ausgabeText.Append($"{Environment.NewLine}{unserUmfeld.BewerbungAn.Info}");
            ausgabeText.Append($"{Environment.NewLine}{Environment.NewLine}");
            ausgabeText.Append("Bitte richte deine Bewerbung per e-Mail an:");
            ausgabeText.Append($"{Environment.NewLine}{unserUmfeld.BewerbungAn.EMail}");
            ausgabeText.Append($"{Environment.NewLine}{Environment.NewLine}");
            ausgabeText.Append($"bzw. per Post an: {Environment.NewLine}{unserUmfeld.BewerbungAn}");

            Console.WriteLine(ausgabeText);
        }
    }
}
