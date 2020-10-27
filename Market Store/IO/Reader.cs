using Market_Store.IO.Contracts;
using System;

namespace Market_Store.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
