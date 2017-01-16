using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganismClassification
{
    public abstract class Phylum 
    {
        public LinkedList<Class> classes;

        public abstract String phylumName();
        public abstract String nameMeaning();
        public abstract String commonName();
        public abstract String description();
    }
}
