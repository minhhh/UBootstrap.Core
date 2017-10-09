using System;
using System.Collections;

namespace UBootstrap
{
    static public partial class ListHelper
    {
        public static bool IsNullOrEmpty(IList list)
        {
            return list == null || list.Count == 0;
        }
    }
}
