using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UBootstrap
{
    public enum EasingType
    {
        Linear,
        EaseInQuad,
        EaseOutQuad,
        EaseInOutQuad,
        EaseInCubic,
        EaseOutCubic,
        EaseInOutCubic,
        EaseInQuart,
        EaseOutQuart,
        EaseInOutQuart,
        EaseInQuint,
        EaseOutQuint,
        EaseInOutQuint,
        EaseInSine,
        EaseOutSine,
        EaseInOutSine,
        EaseInExpo,
        EaseOutExpo,
        EaseInOutExpo,
        EaseInCirc,
        EaseOutCirc,
        EaseInOutCirc,
        EaseInElastic,
        EaseOutElastic,
        EaseInOutElastic,
        EaseInBack,
        EaseOutBack,
        EaseInOutBack,
        EaseInBounce,
        EaseOutBounce,
        EaseInOutBounce,
    }

    public delegate float EasingDelegate (float k);
    public static class EasingTypeExtension
    {
        public static EasingDelegate GetFunction (this EasingType easingType)
        {
            switch (easingType) {
            case EasingType.Linear:
                return new EasingDelegate (Easing.Linear);
            case EasingType.EaseInQuad:
                return new EasingDelegate (Easing.EaseInQuad);
            case EasingType.EaseOutQuad:
                return new EasingDelegate (Easing.EaseOutQuad);
            case EasingType.EaseInOutQuad:
                return new EasingDelegate (Easing.EaseInOutQuad);
            case EasingType.EaseInCubic:
                return new EasingDelegate (Easing.EaseInCubic);
            case EasingType.EaseOutCubic:
                return new EasingDelegate (Easing.EaseOutCubic);
            case EasingType.EaseInOutCubic:
                return new EasingDelegate (Easing.EaseInOutCubic);
            case EasingType.EaseInQuart:
                return new EasingDelegate (Easing.EaseInQuart);
            case EasingType.EaseOutQuart:
                return new EasingDelegate (Easing.EaseOutQuart);
            case EasingType.EaseInOutQuart:
                return new EasingDelegate (Easing.EaseInOutQuart);
            case EasingType.EaseInQuint:
                return new EasingDelegate (Easing.EaseInQuint);
            case EasingType.EaseOutQuint:
                return new EasingDelegate (Easing.EaseOutQuint);
            case EasingType.EaseInOutQuint:
                return new EasingDelegate (Easing.EaseInOutQuint);
            case EasingType.EaseInSine:
                return new EasingDelegate (Easing.EaseInSine);
            case EasingType.EaseOutSine:
                return new EasingDelegate (Easing.EaseOutSine);
            case EasingType.EaseInOutSine:
                return new EasingDelegate (Easing.EaseInOutSine);
            case EasingType.EaseInExpo:
                return new EasingDelegate (Easing.EaseInExpo);
            case EasingType.EaseOutExpo:
                return new EasingDelegate (Easing.EaseOutExpo);
            case EasingType.EaseInOutExpo:
                return new EasingDelegate (Easing.EaseInOutExpo);
            case EasingType.EaseInCirc:
                return new EasingDelegate (Easing.EaseInCirc);
            case EasingType.EaseOutCirc:
                return new EasingDelegate (Easing.EaseInCirc);
            case EasingType.EaseInOutCirc:
                return new EasingDelegate (Easing.EaseInCirc);
            case EasingType.EaseInElastic:
                return new EasingDelegate (Easing.EaseInElastic);
            case EasingType.EaseOutElastic:
                return new EasingDelegate (Easing.EaseOutElastic);
            case EasingType.EaseInOutElastic:
                return new EasingDelegate (Easing.EaseInOutElastic);
            case EasingType.EaseInBack:
                return new EasingDelegate (Easing.EaseInBack);
            case EasingType.EaseOutBack:
                return new EasingDelegate (Easing.EaseOutBack);
            case EasingType.EaseInOutBack:
                return new EasingDelegate (Easing.EaseInOutBack);
            case EasingType.EaseInBounce:
                return new EasingDelegate (Easing.EaseInBounce);
            case EasingType.EaseOutBounce:
                return new EasingDelegate (Easing.EaseOutBounce);
            case EasingType.EaseInOutBounce:
                return new EasingDelegate (Easing.EaseInOutBounce);

            default:
                return new EasingDelegate (Easing.Linear);
            }
        }
    }

    public class Easing
    {
        public static float Linear (float k)
        {
            return k;
        }

        public static float EaseInQuad (float k)
        {
            return k * k;
        }

        public static float EaseOutQuad (float k)
        {
            return k * (2f - k);
        }

        public static float EaseInOutQuad (float k)
        {
            if ((k *= 2f) < 1f)
                return 0.5f * k * k;
            return -0.5f * ((k -= 1f) * (k - 2f) - 1f);
        }


        public static float EaseInCubic (float k)
        {
            return k * k * k;
        }

        public static float EaseOutCubic (float k)
        {
            return 1f + ((k -= 1f) * k * k);
        }

        public static float EaseInOutCubic (float k)
        {
            if ((k *= 2f) < 1f)
                return 0.5f * k * k * k;
            return 0.5f * ((k -= 2f) * k * k + 2f);
        }

        public static float EaseInQuart (float k)
        {
            return k * k * k * k;
        }

        public static float EaseOutQuart (float k)
        {
            return 1f - ((k -= 1f) * k * k * k);
        }

        public static float EaseInOutQuart (float k)
        {
            if ((k *= 2f) < 1f)
                return 0.5f * k * k * k * k;
            return -0.5f * ((k -= 2f) * k * k * k - 2f);
        }


        public static float EaseInQuint (float k)
        {
            return k * k * k * k * k;
        }

        public static float EaseOutQuint (float k)
        {
            return 1f + ((k -= 1f) * k * k * k * k);
        }

        public static float EaseInOutQuint (float k)
        {
            if ((k *= 2f) < 1f)
                return 0.5f * k * k * k * k * k;
            return 0.5f * ((k -= 2f) * k * k * k * k + 2f);
        }


        public static float EaseInSine (float k)
        {
            return 1f - Mathf.Cos (k * Mathf.PI / 2f);
        }

        public static float EaseOutSine (float k)
        {
            return Mathf.Sin (k * Mathf.PI / 2f);
        }

        public static float EaseInOutSine (float k)
        {
            return 0.5f * (1f - Mathf.Cos (Mathf.PI * k));
        }

        public static float EaseInExpo (float k)
        {
            return MathHelper.ApproximatelyEqual (k, 0f) ? 0f : Mathf.Pow (1024f, k - 1f);
        }

        public static float EaseOutExpo (float k)
        {
            return MathHelper.ApproximatelyEqual (k, 1f) ? 1f : 1f - Mathf.Pow (2f, -10f * k);
        }

        public static float EaseInOutExpo (float k)
        {
            if (MathHelper.ApproximatelyEqual (k, 0f)) {
                return 0f;
            }
                
            if (MathHelper.ApproximatelyEqual (k, 1f)) {
                return 1f;
            }

            if ((k *= 2f) < 1f)
                return 0.5f * Mathf.Pow (1024f, k - 1f);
            return 0.5f * (-Mathf.Pow (2f, -10f * (k - 1f)) + 2f);
        }


        public static float EaseInCirc (float k)
        {
            return 1f - Mathf.Sqrt (1f - k * k);
        }

        public static float EaseOutCirc (float k)
        {
            return Mathf.Sqrt (1f - ((k -= 1f) * k));
        }

        public static float EaseInOutCirc (float k)
        {
            if ((k *= 2f) < 1f)
                return -0.5f * (Mathf.Sqrt (1f - k * k) - 1);
            return 0.5f * (Mathf.Sqrt (1f - (k -= 2f) * k) + 1f);
        }

        public static float EaseInElastic (float k)
        {
            if (MathHelper.ApproximatelyEqual (k, 0f)) {
                return 0;
            }
            if (MathHelper.ApproximatelyEqual (k, 1f)) {
                return 1;
            }
            return -Mathf.Pow (2f, 10f * (k -= 1f)) * Mathf.Sin ((k - 0.1f) * (2f * Mathf.PI) / 0.4f);
        }

        public static float EaseOutElastic (float k)
        {
            if (MathHelper.ApproximatelyEqual (k, 0f)) {
                return 0;
            }
            if (MathHelper.ApproximatelyEqual (k, 1f)) {
                return 1;
            }
            return Mathf.Pow (2f, -10f * k) * Mathf.Sin ((k - 0.1f) * (2f * Mathf.PI) / 0.4f) + 1f;
        }

        public static float EaseInOutElastic (float k)
        {
            if ((k *= 2f) < 1f)
                return -0.5f * Mathf.Pow (2f, 10f * (k -= 1f)) * Mathf.Sin ((k - 0.1f) * (2f * Mathf.PI) / 0.4f);
            return Mathf.Pow (2f, -10f * (k -= 1f)) * Mathf.Sin ((k - 0.1f) * (2f * Mathf.PI) / 0.4f) * 0.5f + 1f;
        }

        static float s = 1.70158f;
        static float s2 = 2.5949095f;

        public static float EaseInBack (float k)
        {
            return k * k * ((s + 1f) * k - s);
        }

        public static float EaseOutBack (float k)
        {
            return (k -= 1f) * k * ((s + 1f) * k + s) + 1f;
        }

        public static float EaseInOutBack (float k)
        {
            if ((k *= 2f) < 1f)
                return 0.5f * (k * k * ((s2 + 1f) * k - s2));
            return 0.5f * ((k -= 2f) * k * ((s2 + 1f) * k + s2) + 2f);
        }


        public static float EaseInBounce (float k)
        {
            return 1f - EaseOutBounce (1f - k);
        }

        public static float EaseOutBounce (float k)
        {         
            if (k < (1f / 2.75f)) {
                return 7.5625f * k * k;             
            } else if (k < (2f / 2.75f)) {
                return 7.5625f * (k -= (1.5f / 2.75f)) * k + 0.75f;
            } else if (k < (2.5f / 2.75f)) {
                return 7.5625f * (k -= (2.25f / 2.75f)) * k + 0.9375f;
            } else {
                return 7.5625f * (k -= (2.625f / 2.75f)) * k + 0.984375f;
            }
        }

        public static float EaseInOutBounce (float k)
        {
            if (k < 0.5f)
                return EaseInBounce (k * 2f) * 0.5f;
            return EaseOutBounce (k * 2f - 1f) * 0.5f + 0.5f;
        }

    }
}