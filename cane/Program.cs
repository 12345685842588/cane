using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane c=new Cane();
            c.Razza = "labrador";
            c.Nome = "ringhio";
            c.Proprietario.Nome = "simone";

            Persona p=new Persona();

            

            Console.ReadLine();
        }
    }
}
