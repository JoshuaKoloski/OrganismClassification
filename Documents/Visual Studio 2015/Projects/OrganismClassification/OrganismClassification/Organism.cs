using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrganismClassification
{
    public interface Organism
    {
        int averageYearLifespan();
        LinkedList<Organism> getDescendants();
        LinkedList<Organism> getAncestors();
        String behavior();

    }
}
