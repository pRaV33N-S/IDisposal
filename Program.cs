using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileHandler = new FileHandler("Sam File One");
            fileHandler.GetFileDetails();
            FileHandler fileHandler2 = new FileHandler("Sam File Two");
            fileHandler2.GetFileDetails();

        }
    }
}
