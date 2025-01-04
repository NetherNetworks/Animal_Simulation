using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Simulation.repository
{
    public interface ICarnivore
    {
        void Hunt(int energyLevel, object prey);
    }
}
