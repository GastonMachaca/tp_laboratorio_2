using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefoniaCelular;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Central c = new Central("Movistar");
            Local l1 = new Local("011", 30, "56216544", 2.65f);
            Provincial l2 = new Provincial("351", Provincial.Franja.Cordoba, 21, "52166452");
            Provincial l3 = new Provincial("261", Provincial.Franja.Mendoza, 44, "43921062");
            Provincial l4 = new Provincial(Provincial.Franja.Jujuy, l2);

            c += l1;
            c += l2;
            c += l3;
            c += l4;

            c.OrdenarLlamadas();

            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
