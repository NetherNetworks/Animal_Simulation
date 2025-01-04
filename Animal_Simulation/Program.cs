using Animal_Simulation.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion("Simba", 5, 100, AnimalState.Hunting);
            Deer deer1 = new Deer("Bambi", 4, 50, AnimalState.Resting);

            deer1.GetAllDetails(View.Vertikal);
            lion1.GetAllDetails(View.Vertikal);

            lion1.Hunt(deer1);

            
        }
    }
}
