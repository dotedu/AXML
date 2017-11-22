using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXML.android
{
    public class TypedValue
    {
        public int type;
       // public CharSequence string;
  public int data;
        public int assetCookie;
        public int resourceId;
        public int changingConfigurations;
        public static readonly int TYPE_NULL = 0;
        public static readonly int TYPE_REFERENCE = 1;
        public static readonly int TYPE_ATTRIBUTE = 2;
        public static readonly int TYPE_STRING = 3;
        public static readonly int TYPE_FLOAT = 4;
        public static readonly int TYPE_DIMENSION = 5;
        public static readonly int TYPE_FRACTION = 6;
        public static readonly int TYPE_FIRST_INT = 16;
        public static readonly int TYPE_INT_DEC = 16;
        public static readonly int TYPE_INT_HEX = 17;
        public static readonly int TYPE_INT_BOOLEAN = 18;
        public static readonly int TYPE_FIRST_COLOR_INT = 28;
        public static readonly int TYPE_INT_COLOR_ARGB8 = 28;
        public static readonly int TYPE_INT_COLOR_RGB8 = 29;
        public static readonly int TYPE_INT_COLOR_ARGB4 = 30;
        public static readonly int TYPE_INT_COLOR_RGB4 = 31;
        public static readonly int TYPE_LAST_COLOR_INT = 31;
        public static readonly int TYPE_LAST_INT = 31;
        public static readonly int COMPLEX_UNIT_PX = 0;
        public static readonly int COMPLEX_UNIT_DIP = 1;
        public static readonly int COMPLEX_UNIT_SP = 2;
        public static readonly int COMPLEX_UNIT_PT = 3;
        public static readonly int COMPLEX_UNIT_IN = 4;
        public static readonly int COMPLEX_UNIT_MM = 5;
        public static readonly int COMPLEX_UNIT_SHIFT = 0;
        public static readonly int COMPLEX_UNIT_MASK = 15;
        public static readonly int COMPLEX_UNIT_FRACTION = 0;
        public static readonly int COMPLEX_UNIT_FRACTION_PARENT = 1;
        public static readonly int COMPLEX_RADIX_23p0 = 0;
        public static readonly int COMPLEX_RADIX_16p7 = 1;
        public static readonly int COMPLEX_RADIX_8p15 = 2;
        public static readonly int COMPLEX_RADIX_0p23 = 3;
        public static readonly int COMPLEX_RADIX_SHIFT = 4;
        public static readonly int COMPLEX_RADIX_MASK = 3;
        public static readonly int COMPLEX_MANTISSA_SHIFT = 8;
        public static readonly int COMPLEX_MANTISSA_MASK = 16777215;
    }
}
