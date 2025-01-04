using Animal_Simulation.repository;
using System;
using System.Runtime.InteropServices;

namespace Animal_Simulation.model
{
    class Lion : Animal, ICarnivore
    {
        public Lion(string name, int age, int energyLevel, AnimalState animalState)
        : base(name, age, energyLevel,animalState)
        {
            this.Name = name;
            this.Age = age;
            this.EnergyLevel = energyLevel;
            ChangeState(animalState);

        }


        public void Hunt( Animal prey, int energyLevel = -1)
        {
            if (energyLevel == -1)
            {
                energyLevel = this.EnergyLevel;
            }
            for (int i = energyLevel; i > 1; i--)
            {
                this.EnergyLevel--;
                prey.EnergyLevel--;

                if (prey.EnergyLevel == 0)
                {
                    Console.WriteLine("The lion hunted the prey down");
                    prey = null;
                    if (this.EnergyLevel < 75){this.EnergyLevel = this.EnergyLevel + 25;}
                    else{this.EnergyLevel = 100;}
                    return;
                }
                else if(energyLevel == 0) 
                {
                    this.EnergyLevel = energyLevel;
                    Console.WriteLine("The prey escaped the lion");
                    return;
                }
            }  
        }

        public override void MakeSound()
        {
            Console.WriteLine("The Lion roars");                
        }
    }
}
