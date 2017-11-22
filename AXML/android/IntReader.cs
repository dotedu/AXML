using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXML
{
    public readonly class IntReader
    {
        private InputStream m_stream;
        private bool m_bigEndian;
        private int m_position;

        public IntReader() { }

        public IntReader(InputStream stream, boolean bigEndian)
        {
            reset(stream, bigEndian);
        }

        public readonly void reset(InputStream stream, boolean bigEndian)
        {
            this.m_stream = stream;
            this.m_bigEndian = bigEndian;
            this.m_position = 0;
        }

        public void readFully(byte[] b)
        throws IOException
        {
    new DataInputStream(this.m_stream).readFully(b);
    }

    public readonly void close()
    {
        if (this.m_stream == null)
        {
            return;
        }
        try
        {
            this.m_stream.close();
        }
        catch (IOException localIOException) { }
        reset(null, false);
    }

    public readonly InputStream getStream()
    {
        return this.m_stream;
    }

    public readonly boolean isBigEndian()
    {
        return this.m_bigEndian;
    }

    public readonly void setBigEndian(boolean bigEndian)
    {
        this.m_bigEndian = bigEndian;
    }

    public readonly int readByte()
    throws IOException
    {
    return readInt(1);
    }

    public readonly int readShort()
    throws IOException
    {
    return readInt(2);
    }

    public readonly int readInt()
    throws IOException
    {
    return readInt(4);
    }

    public readonly int readInt(int length)
    throws IOException
    {
    if ((length < 0) || (length > 4)) {
            throw new IllegalArgumentException();
        }
    int result = 0;
    if (this.m_bigEndian)
    {
            for (int i = (length - 1) * 8; i >= 0; i -= 8)
            {
                int b = this.m_stream.read();
                if (b == -1)
                {
                    throw new EOFException();
                }
                this.m_position += 1;
                result |= b << i;
            }
        }
    else
    {
            length *= 8;
            for (int i = 0; i != length; i += 8)
            {
                int b = this.m_stream.read();
                if (b == -1)
                {
                    throw new EOFException();
                }
                this.m_position += 1;
                result |= b << i;
            }
        }
    return result;
    }

    public readonly int[] readIntArray(int length)
    throws IOException
    {
    int[]
        array = new int[length];
    readIntArray(array, 0, length);
    return array;
  }

public readonly void readIntArray(int[] array, int offset, int length)
    throws IOException
{
    for (; length > 0; length--) {
        array[(offset++)] = readInt();
    }
}

public readonly byte[] readByteArray(int length)
    throws IOException
{
    byte[]
    array = new byte[length];
    int read = this.m_stream.read(array);
    this.m_position += read;
    if (read != length) {
    throw new EOFException();
}
    return array;
}

public readonly void skip(int bytes)
    throws IOException
{
    if (bytes <= 0) {
        return;
    }
    long skipped = this.m_stream.skip(bytes);
    this.m_position = ((int)(this.m_position + skipped));
    if (skipped != bytes) {
        throw new EOFException();
    }
}

public readonly void skipInt()
    throws IOException
{
    skip(4);
}

public readonly int available()
    throws IOException
{
    return this.m_stream.available();
}

public readonly int getPosition()
{
    return this.m_position;
}
}
}
