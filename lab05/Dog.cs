using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
   public class Dog//class
    {
        public string Species;


        public Dog(string Species)  // constructor
        {
            this.Species = Species;

        }

        //method return type string
        public string Whoami()
        {
            return this.Species + " say box box";
        }
        public string DisplaySpecies()
        {
            return this.Species;
        }
    }


}
