using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Interfaces
{
    public class Document : IStore, ICompress
    {

        public void Read()
        {
            Console.WriteLine("Executing Document's Read Method for IStore");
        }

        public void Write()
        {
            Console.WriteLine("Executing Document's Write Method for IStore");
        }

        public void Compress()
        {
            Console.WriteLine("Executing Document's Compress Method for ICompress");
        }
        public void Decompress()
        {
            Console.WriteLine("Executing Document's Decompress Method for ICompress");
        }

    }
}
