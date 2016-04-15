using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Stellenausschreibung
{
    // Q: Why do Java developers wear glasses?
    // A: Because they can't C#

    // Interessierte Bewerber sollten mit den folgenden Ausführungen etwas anfangen können.
    // Fachinformatiker sollten etwas genauer hinsehen :-)
    public class SoftwareEntwickler
    {
        public static void Main(string[] args)
        {
            var deinProfil = new Profil
            {
                Berufserfahrung = 2,
                HatInformatikStudiert = true,
                IstFachInfoirmatiker = false,
                HatDotNetErfahrung = true,
                HatCSharpErfahrung = true,
                HatSqlKenntnisse = true,
                HatObjectRelationalMapperErfahrung = true,
                HatBusinessLayerErfharung = true,
                HatModelViewControlerErfahrung = true,
                HatWebServiceErfahrung = true,
                HatUserInterfaceErfahrung = true,
                IstBegeisterungsfähig = true,
                IstTeamfähig = true,
                IstKreativ = true
            };

            var unserUmfeld = new Umfeld
            {
                EinsatzOrt = "Mannheim beim Kunden",
                Angebot = new List<string>
                {
                    "Spannende Aufgaben",
                    "Sympatische Kollegen",
                    "Engagiertes Team",
                    "Agile Softwareentwicklung",
                    "Hervorrangende Weiterbildungsmöglichkeiten",
                    "Kreatives arbeiten"
                },
                BewerbungAn = new Adresse
                {
                    Name = "CAIRO AG",
                    HomeUrl = "www.cairo.ag",
                    Strasse = "Voltastraße 19-21",
                    Postleitzahl = "68199",
                    Ort = "Mannheim",
                    EMail = "wolfram.theymann@cairo.ag",
                    Telefon = "Telefon: 0621-867510"
                },
                IstInteressant = true
            };

            if (deinProfil.HatAnforderungErfüllt && unserUmfeld.IstInteressant)
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
            string ausgabeText = @"Vielen Dank für dein Intresse.

                                   Wir das sympatische Softwareentwicklungs-Team von {0}.
                                   Unser Angebot an Dich:
                                   {1}
 
                                   Bitte richte deine Bewerbung an:
                                   {3}";

            string angebot = unserUmfeld.Angebot.Aggregate(string.Empty, (current, zeile) => current + zeile);

            Console.WriteLine(ausgabeText, unserUmfeld.BewerbungAn.Name, angebot, unserUmfeld.BewerbungAn);
        }
    }

    public class Profil
    {
        [Range(1, 5, ErrorMessage = "Sie sollten zwischen {0} und {1} Jahren Berufserfahrung verfügen.")]
        public int Berufserfahrung { get; set; }
        public bool HatCSharpErfahrung { get; set; }
        public bool HatDotNetErfahrung { get; set; }
        public bool HatSqlKenntnisse { get; set; }
        public bool HatObjectRelationalMapperErfahrung { get; set; }
        public bool HatUserInterfaceErfahrung { get; set; }
        public bool HatBusinessLayerErfharung { get; set; }
        public bool HatModelViewControlerErfahrung { get; set; }
        public bool HatWebServiceErfahrung { get; set; }
        public bool IstBegeisterungsfähig { get; set; }
        public bool IstTeamfähig { get; set; }
        public bool IstKreativ { get; set; }
        public bool HatInformatikStudiert { get; set; }
        public bool IstFachInfoirmatiker { get; set; }
        public bool IsFullStackDeveloper { get; set; }

        public bool HatAnforderungErfüllt => ErmittleQualifikation() >= 4;
        private int ErmittleQualifikation()
        {
            int score = 0;
            bool hasPersonalskills = (Berufserfahrung >= 1 && HatInformatikStudiert) || (Berufserfahrung >= 3 && IstFachInfoirmatiker);

            bool hasSoftskills = IstBegeisterungsfähig && IstTeamfähig && IstKreativ; 

            bool hasHardskills = HatDotNetErfahrung && HatCSharpErfahrung && HatSqlKenntnisse;

            bool hasExpertskills = HatObjectRelationalMapperErfahrung && HatBusinessLayerErfharung &&
                                   HatWebServiceErfahrung && HatModelViewControlerErfahrung &&
                                   HatUserInterfaceErfahrung;

            IsFullStackDeveloper = hasPersonalskills && hasSoftskills && hasHardskills && hasExpertskills;

            if (hasPersonalskills)
                score += 1;
            if (hasHardskills)
                score += 2;
            if (hasSoftskills)
                score += 4;
            if (hasExpertskills)
                score += 8;

            return score;
        }
    }

    public class Umfeld
    {
        public string EinsatzOrt { get; set; }
        public List<string> Angebot { get; set; }
        public Adresse BewerbungAn { get; set; }
        public bool IstInteressant { get; set; }
    }

    public class Adresse
    {
        public string Name { get; set; }
        public string Strasse { get; set; }
        public string Postleitzahl { get; set; }
        public string Ort { get; set; }
        public string EMail { get; set; }
        public string HomeUrl { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return $"{Name}{Environment.NewLine}" +
                   $"{HomeUrl}{Environment.NewLine}" +
                   $"{Strasse}{Environment.NewLine}" +
                   $"{Postleitzahl} {Ort}{Environment.NewLine}" +
                   $"{EMail}{Environment.NewLine}" +
                   $"{Telefon}";
        }
    }
}
