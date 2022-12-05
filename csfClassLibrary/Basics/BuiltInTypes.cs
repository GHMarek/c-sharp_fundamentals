using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary
{
    /// <summary>
    /// Built-in types basics.
    /// </summary>
    class BuiltInTypes
    {
        string someStr = String.Empty;
        
        char someChar = 'c';
        char someCharUnicode = '\u006a';
        
        bool someBool = true;
        bool anotherBool = false;

        DateTime now = DateTime.Now;
        DateTime someDate = new DateTime(year: 2022, month: 12, day: 5);

        byte someByte = byte.MaxValue;
        short someShort = short.MaxValue;
        int someInt = int.MaxValue;
        long someLong = long.MaxValue;

        float someFloat = 1.5F;
        decimal someDecimal = 1.5M;
        double someDouble = 1.5;


    }
}
