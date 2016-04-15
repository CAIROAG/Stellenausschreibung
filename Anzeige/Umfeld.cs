using System.Collections.Generic;

namespace Stellenausschreibung
{
    public class Umfeld
    {
        public string EinsatzOrt { get; set; }
        public List<string> Angebot { get; set; }
        public Adresse BewerbungAn { get; set; }
        public bool IstInteressant { get; set; }
    }
}