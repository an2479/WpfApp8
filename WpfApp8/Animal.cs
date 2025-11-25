using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    public class Animal
    {
        private string name;
        private DateTime birth;
        private string type;
        private string gender;
        private double weight;
        public Animal(string name, DateTime birth, string type, string gender, double weight)
        {
            this.name = name;
            this.birth = birth;
            this.type = type;
            this.gender = gender;
            this.weight = weight;
        }
        public string Name { get => name; set => name = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Type { get => type; set => type = value; }
        public string Gender { get => gender; set => gender = value; }
        public double Weight { get => weight; set => weight = value; }
        public override string ToString()
        {
            return $"name: {name},birth: {birth},type: {type},gender: {gender},weight: {weight}";
        }
    }
}
