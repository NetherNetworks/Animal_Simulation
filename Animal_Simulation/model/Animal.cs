using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Animal_Simulation.model
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int EnergyLevel { get; set; }

        public AnimalState State{ get; private set; }

        public Animal(string name, int age, int energyLevel, AnimalState animalState)
        {
            this.Name = name;
            this.Age = age;
            this.EnergyLevel = energyLevel;
            this.State = animalState;
        }
        public void ChangeState(AnimalState newState)
        {
            this.State = newState;
        }
        public abstract void MakeSound();

        public void GetAllDetails(View option)
        {
            Type type = this.GetType();

            foreach (PropertyInfo property in type.GetProperties())
            {
                string propertyName = property.Name;
                object propertyValue = property.GetValue(this);

                if (option == View.List)
                {
                    Console.Write(propertyName + ": " + propertyValue + "    ");
                }
                else if (option == View.Tab)
                {
                    Console.WriteLine(propertyName + ": " + propertyValue);
                }
            }
        }
    }
}
