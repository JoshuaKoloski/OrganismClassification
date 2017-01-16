using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganismClassification
{
    abstract class Phylum : AnimalKingdom
    {
        public abstract String phylumName();
        public abstract String nameMeaning();
        public abstract String commonName();
        public abstract String description();
    }
}
