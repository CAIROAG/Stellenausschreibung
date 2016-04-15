namespace Stellenausschreibung
{
    public class Profil
    {
        private int ErmittleQualifikation()
        {
            int score = 0;
            bool hasPersonalskills = (MindestBerufserfahrungInJahren >= 1 && HatInformatikStudiert) ||
                                     (MindestBerufserfahrungInJahren >= 3 && IstFachInformatiker);

            bool hasSoftskills = IstBegeisterungsfähig &&
                                 IstTeamfähig &&
                                 IstKreativ;

            bool hasHardskills = HatDotNetErfahrung &&
                                 HatCSharpErfahrung &&
                                 HatSqlKenntnisse;

            bool hasExpertskills = HatObjectRelationalMapperErfahrung &&
                                   HatBusinessLayerErfharung &&
                                   HatWebServiceErfahrung &&
                                   HatModelViewControllerErfahrung &&
                                   HatUserInterfaceErfahrung;

            IsFullStackDeveloper = hasPersonalskills &&
                                   hasSoftskills &&
                                   hasHardskills &&
                                   hasExpertskills;

            if (hasPersonalskills) score += 1;
            if (hasHardskills) score += 2;
            if (hasSoftskills) score += 4;
            if (hasExpertskills) score += 8;

            return score;
        }
        public bool HatAnforderungenErfüllt => ErmittleQualifikation() >= 4;
        public int MindestBerufserfahrungInJahren { get; set; }
        public bool HatCSharpErfahrung { get; set; }
        public bool HatDotNetErfahrung { get; set; }
        public bool HatSqlKenntnisse { get; set; }
        public bool HatObjectRelationalMapperErfahrung { get; set; }
        public bool HatUserInterfaceErfahrung { get; set; }
        public bool HatBusinessLayerErfharung { get; set; }
        public bool HatModelViewControllerErfahrung { get; set; }
        public bool HatWebServiceErfahrung { get; set; }
        public bool IstBegeisterungsfähig { get; set; }
        public bool IstTeamfähig { get; set; }
        public bool IstKreativ { get; set; }
        public bool HatInformatikStudiert { get; set; }
        public bool IstFachInformatiker { get; set; }
        public bool IsFullStackDeveloper { get; set; }
        
    }
}