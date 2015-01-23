using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphaIdents;

namespace TestAlphaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortId newId = new ShortId();
            string alphaId = newId.Encode(10);
            Console.WriteLine("alphaId: " + alphaId);
            Console.WriteLine("originalId: " + newId.Decode(alphaId));
            Console.WriteLine("Any key to continue");
            Console.ReadLine();
        }
    }
}
