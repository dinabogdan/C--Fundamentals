using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class ListExtensions
    {
        public static List<T> AddOneElement<T>(this List<T> elements, T element)
        {
            elements.Add(element);
            return elements;
        }
    }
}
