using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    public class CounterRef
    {
        private int _count;
        private static int _totalCount;

        public int GetNextValue()
        {
            _count += 1;
            _totalCount += 1;
            return _count;
        }

        public static int TotalCount => _totalCount;
    }

    public struct CounterStruct
    {
        private int _count;
        private static int _totalCount;

        public int GetNextValue()
        {
            _count += 1;
            _totalCount += 1;
            return _count;
        }

        public static int TotalCount => _totalCount;
    }
}
