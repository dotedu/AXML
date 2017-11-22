using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXML
{
    class ChunkUtil
    {
        public static readonly void readCheckType(IntReader reader, int expectedType)
        {
    int type = reader.readInt();
    if (type != expectedType) {
     // throw new IOException(
     //   "Expected chunk of type 0x" + Integer.toHexString(expectedType) + 
    //    ", read 0x" + Integer.toHexString(type) + ".");
    }
}
}
}
