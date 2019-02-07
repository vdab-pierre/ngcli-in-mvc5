using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models.latijn.woorden
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
        public virtual IEnumerable<Vertaling> Vertalingen { get; set; }
        public virtual IEnumerable<AanvullendGegeven> AanvullendeGegevens { get; set; }
    }
}
