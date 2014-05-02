using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEducation.Utils
{
    public static class DbUtils
    {
        static readonly int[] _guidImportance = new[] {3, 2, 1, 0, 
                                                       5, 4, 7, 6, 
                                                       9, 8, 15, 14, 
                                                       13, 12, 11, 10};

        public static Guid CreateGuidComb()
        {
            var bytes = Guid.NewGuid().ToByteArray();
            var tick = DateTime.UtcNow.Ticks;

            var dateTimeBytes = BitConverter.GetBytes(tick);

            bytes[_guidImportance[15]] = dateTimeBytes[2];
            bytes[_guidImportance[14]] = dateTimeBytes[3];
            bytes[_guidImportance[13]] = dateTimeBytes[4];
            bytes[_guidImportance[12]] = dateTimeBytes[5];
            bytes[_guidImportance[11]] = dateTimeBytes[6];
            bytes[_guidImportance[10]] = dateTimeBytes[7];

            return new Guid(bytes);
        }
    }
}
