using Animal_Simulation.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Simulation.model
{
    public class Deer : Animal, IHerbivore
    {    

        public Deer(string name, int age, int energyLevel, AnimalState animalState)
        : base(name, age, energyLevel, animalState)
        { 
            this.Name = name;
            this.Age = age;
            this.EnergyLevel = energyLevel;
            this.ChangeState(animalState);
        }
        
        public override void MakeSound()
        {
            Console.WriteLine("The Deer makes a sound");
        }

        public void eatPlants(int energyLevel)
        {
            if (this.EnergyLevel < 85)
            this.EnergyLevel = energyLevel+15;
            else
            {
                this.EnergyLevel = 100;
            }
        }
    }
}
