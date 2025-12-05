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
        private string birth;
        private string type;
        private string gender;
        private double weight;
        public string Name { get => name; set => name = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Type { get => type; set => type = value; }
        public string Gender { get => gender; set => gender = value; }
        public double Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return $"name: {name},birth: {birth:yyyy-MM-dd},type: {type},gender: {gender},weight: {weight}";
        }
    }
}
