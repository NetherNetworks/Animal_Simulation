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


        public void Hunt(int energyLevel, object prey)
        {
            for (int i = this.EnergyLevel; i < 1; i--)
            {
                prey.EnergyLevel--;

                if (prey.EnergyLevel == 0)
                {
                    Console.WriteLine("The lion hunted the prey down");
                    prey = null;
                    return;
                }
                else
                {
                    Console.WriteLine("The prey escaped the lion");
                }
            }  
        }

        public override void MakeSound()
        {
            Console.WriteLine("The Lion roars");                
        }
    }
}
