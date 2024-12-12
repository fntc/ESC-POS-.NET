using System;

namespace ESCPOS_NET;

public class BitmapFormatException : Exception
{
    public BitmapFormatException(string message) : base(message)
    {
        
    }
}