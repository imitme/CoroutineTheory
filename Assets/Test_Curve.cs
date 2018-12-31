using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NA;

public class Test_Curve : MonoBehaviour
{
    public float duration = 3f;
    public Vector3 beginPos;
    public Vector3 endPos;
    private Vector3 distance;

    public AnimationCurve curve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

    private IEnumerator Start()
    {
        //distance = endPos - beginPos;

        //StartCoroutine(Process(duration));
        StartCoroutine(Utility.Lerp(beginPos, endPos, duration, curve, Vector3.Lerp,
            (v) =>
            {
                transform.position = v;
            }));

        StartCoroutine(Utility.Lerp(Quaternion.Euler(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f), duration, curve, Quaternion.Lerp,
            (v) =>
            {
                transform.rotation = v;
            }));

        yield return StartCoroutine(Utility.Lerp(1f, 3f, duration, curve, Mathf.Lerp,
            (v) =>
            {
                transform.localScale = new Vector3(v, v, v);
            }));

        StartCoroutine(Utility.Lerp(3f, 1f, duration, curve, Mathf.Lerp,
            (v) =>
            {
                transform.localScale = new Vector3(v, v, v);
            }));
    }

    //private IEnumerator Process(float duration)
    //{
    //    var beginTime = Time.time;
    //    var percent = 0f;

    //    for (; ; )
    //    {
    //        percent = (Time.time - beginTime) / duration;
    //        if (percent > 1f)
    //            break;

    //        //transform.position = beginPos + distance * percent;
    //        transform.position = beginPos + distance * curve.Evaluate(percent);
    //        yield return null;
    //    }

    //    transform.position = endPos;
    //    Debug.Log("시작!!!");
    //}
}