using System;

namespace Stellenausschreibung
{
    public class Adresse
    {
        public string Name { get; set; }
        public string Strasse { get; set; }
        public string Postleitzahl { get; set; }
        public string Ort { get; set; }
        public string EMail { get; set; }
        public string HomeUrl { get; set; }
        public string Telefon { get; set; }
        public string Zuständig { get; set; }

        public string Info => $"{HomeUrl}{Environment.NewLine}{EMail}{Environment.NewLine}{Telefon}";

        public override string ToString()
        {
            return $"{Name}{Environment.NewLine}" +
                   $"{Zuständig}{Environment.NewLine}" +
                   $"{Strasse}{Environment.NewLine}" +
                   $"{Postleitzahl} {Ort}{Environment.NewLine}";
        }
    }
}