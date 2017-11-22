using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXML
{
    public class constants
    {

        private static readonly int ATTRIBUTE_IX_NAMESPACE_URI = 0;
        private static readonly int ATTRIBUTE_IX_NAME = 1;
        private static readonly int ATTRIBUTE_IX_VALUE_STRING = 2;
        private static readonly int ATTRIBUTE_IX_VALUE_TYPE = 3;
        private static readonly int ATTRIBUTE_IX_VALUE_DATA = 4;
        private static readonly int ATTRIBUTE_LENGHT = 5;

        private static readonly int CHUNK_AXML_FILE = 524291;
        private static readonly int CHUNK_RESOURCEIDS = 524672;
        private static readonly int CHUNK_XML_FIRST = 1048832;
        private static readonly int CHUNK_XML_START_NAMESPACE = 1048832;
        private static readonly int CHUNK_XML_END_NAMESPACE = 1048833;
        private static readonly int CHUNK_XML_START_TAG = 1048834;
        private static readonly int CHUNK_XML_END_TAG = 1048835;
        private static readonly int CHUNK_XML_TEXT = 1048836;
        private static readonly int CHUNK_XML_LAST = 1048836;

        START_DOCUMENT = 0
END_DOCUMENT = 1
START_TAG = 2
END_TAG = 3
TEXT = 4

TYPE_ATTRIBUTE = 2
TYPE_DIMENSION = 5
TYPE_FIRST_COLOR_INT = 28
TYPE_FIRST_INT = 16
TYPE_FLOAT = 4
TYPE_FRACTION = 6
TYPE_INT_BOOLEAN = 18
TYPE_INT_COLOR_ARGB4 = 30
TYPE_INT_COLOR_ARGB8 = 28
TYPE_INT_COLOR_RGB4 = 31
TYPE_INT_COLOR_RGB8 = 29
TYPE_INT_DEC = 16
TYPE_INT_HEX = 17
TYPE_LAST_COLOR_INT = 31
TYPE_LAST_INT = 31
TYPE_NULL = 0
TYPE_REFERENCE = 1
TYPE_STRING = 3

RADIX_MULTS = [0.00390625, 3.051758E-005, 1.192093E-007, 4.656613E-010]
        DIMENSION_UNITS = ["px", "dip", "sp", "pt", "in", "mm"]
        FRACTION_UNITS = ["%", "%p"]

        COMPLEX_UNIT_MASK = 15


RES_NULL_TYPE = 0x0000
RES_STRING_POOL_TYPE = 0x0001
RES_TABLE_TYPE = 0x0002
RES_XML_TYPE = 0x0003

# Chunk types in RES_XML_TYPE
RES_XML_FIRST_CHUNK_TYPE = 0x0100
RES_XML_START_NAMESPACE_TYPE = 0x0100
RES_XML_END_NAMESPACE_TYPE = 0x0101
RES_XML_START_ELEMENT_TYPE = 0x0102
RES_XML_END_ELEMENT_TYPE = 0x0103
RES_XML_CDATA_TYPE = 0x0104
RES_XML_LAST_CHUNK_TYPE = 0x017f

# This contains a uint32_t array mapping strings in the string
# pool back to resource identifiers.  It is optional.
RES_XML_RESOURCE_MAP_TYPE = 0x0180

# Chunk types in RES_TABLE_TYPE
RES_TABLE_PACKAGE_TYPE = 0x0200
RES_TABLE_TYPE_TYPE = 0x0201
RES_TABLE_TYPE_SPEC_TYPE = 0x0202

    }
}
