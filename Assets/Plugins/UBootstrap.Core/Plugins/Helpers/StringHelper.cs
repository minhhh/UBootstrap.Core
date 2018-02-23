using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UBootstrap
{
    static public partial class StringHelper
    {
        public static string PadDigit (int number, int total)
        {
            return number.ToString ("D" + total);
        }
    }
}
