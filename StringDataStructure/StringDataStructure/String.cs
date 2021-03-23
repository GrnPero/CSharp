using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataStructure
{
    unsafe class String
    {
        private int size;
        private char* buffer;

        public String()
        {
            size = 0;
            buffer = null;
        }

        char & operator[](int i) {
            return buffer[i];
        }
    }
}
