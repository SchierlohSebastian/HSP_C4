using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        Program()
        {
            CatiaConnection cc = new CatiaConnection();
           if( cc.laeuftCatia())
            {
                cc.erzeugePart();
                cc.erstelleLeereSkizze();
            }
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
