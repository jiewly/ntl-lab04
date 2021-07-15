using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
   public class Cat //class
    {
       public string Species; //property
      
        
      
        public Cat(string Species)  // constructor
        {
            this.Species = Species;
            
        }

        //method return type string
        public string Whoami()
        {
            return this.Species +" say meow meow";
        }
        public string DisplaySpecies() 
        {
            return this.Species;
        }

    }
        
   
}
