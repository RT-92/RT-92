using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
    internal class Prueba
    {
        public int edad { get; set; }  
        public string Name { get; set; }
        public Prueba(int edad, string name ) 
        {
            this.edad = edad; this.Name = name;
        }
    }
}
