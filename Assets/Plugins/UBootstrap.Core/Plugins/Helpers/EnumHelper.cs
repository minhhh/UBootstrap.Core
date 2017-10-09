using System;
using System.Collections.Generic;

namespace UBootstrap
{
    static public partial class EnumHelper
    {
        static Dictionary <Enum, string> _enumToStringDict = new Dictionary <Enum, string> ();
        static Dictionary <Enum, string> _enumToStringUpperDict = new Dictionary <Enum, string> ();
        static Dictionary <Enum, string> _enumToStringLowerDict = new Dictionary <Enum, string> ();

        public static int EnumToInt (Enum e)
        {
            return (int)((object)e);
        }

        public static bool EnumEqual (Enum a, Enum b)
        {
            return EnumToInt (a) == EnumToInt (b);
        }

        public static string EnumToString (Enum e)
        {
            if (!_enumToStringDict.ContainsKey (e)) {
                _enumToStringDict [e] = e.ToString ();
            }

            return _enumToStringDict [e];
        }

        public static string EnumToStringUpper (Enum e)
        {
            if (!_enumToStringUpperDict.ContainsKey (e)) {
                _enumToStringUpperDict [e] = e.ToString ().ToUpper ();
            }

            return _enumToStringUpperDict [e];
        }

        public static string EnumToStringLower (Enum e)
        {
            if (!_enumToStringLowerDict.ContainsKey (e)) {
                _enumToStringLowerDict [e] = e.ToString ().ToLower ();
            }

            return _enumToStringLowerDict [e];
        }
    }
}
