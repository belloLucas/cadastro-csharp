using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender {  get; set; }


        public override string ToString()
        {
            return $"{Name}, {City}, {Gender}";
        }
    }
}
