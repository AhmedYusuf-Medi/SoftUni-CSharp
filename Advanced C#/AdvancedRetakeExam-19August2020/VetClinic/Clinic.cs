using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;
        public int Capacity { get; set; }

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.pets = new List<Pet>();
        }

        public void Add(Pet pet)
        {
            if (this.pets.Count < Capacity)
            {
                this.pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet pet = this.pets.FirstOrDefault(p => p.Name == name);
            if (pet != null)
            {
                this.pets.Remove(pet);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = this.pets.FirstOrDefault(p => p.Name == name && p.Owner == owner);
            if (pet != null)
            {
                return pet;
            }
            else
            {
                return null;
            }
        }

        public Pet GetOldestPet()
        {
            if (this.pets.Count > 0)
            {
                Pet pet = this.pets.OrderByDescending(p => p.Age).FirstOrDefault();
                return pet;
            }
            return null;
        }

        public int Count { get { return pets.Count; } }

        public string GetStatistics()
        {
            StringBuilder statics = new StringBuilder();
            statics.AppendLine("The clinic has the following patients: ");
            if (this.pets.Count >= 0)
            {
                foreach (var pet in this.pets)
                {
                    statics.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
                }
            }

            return statics.ToString().TrimEnd();
        }
    }
}
