using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrganismClassification
{
    public abstract class Organism
    {
        bool alive = true;
        public abstract int averageYearLifespan();
        public abstract LinkedList<Organism> getDescendants();
        public abstract LinkedList<Organism> getAncestors();
        public abstract String behavior();

    }
}
