using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.latijn.woorden
{
    public enum Genus
    {
        m,v,o
    }
    public class Woord
    {
        public int Id { get; set; }
        public string GrondWoord { get; set; }
        public Genus Genus { get; set; }
        public IEnumerable<Vertaling> Vertalingen { get; set; }
        public IEnumerable<AanvullendGegeven> AanvullendeGegevens { get; set; }
    }
}
