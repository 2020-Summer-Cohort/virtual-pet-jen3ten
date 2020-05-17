using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        //private string name;

        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;
        }

        public int GetHunger()
        {
            return Hunger;
        }

        public int GetBoredom()
        {
            return Boredom;
        }
        
        public int GetHealth()
        {
            return Health;
        }

        public void Feed()
        {
            Hunger -= 40;
        }

        public void SeeDoctor()
        {
            Health += 30;
        }
    }
}
