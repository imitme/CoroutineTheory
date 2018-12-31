using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NA
{
    public static class Utility
    {
        public static IEnumerator Lerp<T>(
            T begin,
            T end,
            float duration,
            AnimationCurve curve,
            Func<T, T, float, T> Lerp,
            Action<T> OnValueChanged,
            Action OnCompleted = null)
        {
            var beginTime = Time.time;
            var endTime = beginTime + duration;
            var t = 0f;

            OnValueChanged(begin);

            for (; ; )
            {
                t = curve.Evaluate((Time.time - beginTime) / duration);
                OnValueChanged(Lerp(begin, end, t));
                if (Time.time >= endTime)
                    break;
                yield return null;
            }

            OnValueChanged(end);

            if (OnCompleted != null)
                OnCompleted();
        }
    }
}
