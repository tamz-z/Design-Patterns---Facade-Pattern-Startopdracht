using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Screen
    {
        public void Up()
        {
            Console.WriteLine("Scherm omhoog");
        }
        public void Down()
        {
            Console.WriteLine("Scherm omlaag");
        }
    }
}
