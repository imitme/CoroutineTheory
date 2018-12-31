using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_AnimationCurve : MonoBehaviour
{
    public float duration = 3f;
    public Vector3 beginPos;
    public Vector3 endPos;
    public Vector3 distance;
    public AnimationCurve curve = AnimationCurve.EaseInOut(0f,0f,1f,1f);

    private void Start()
    {
        distance = endPos - beginPos;
        StartCoroutine(Process(5f));
    }

    IEnumerator Process(float duration)
    {
        var beginTime = Time.time;
        var percent = 0f;
        for (; ; )
        {
            percent = (Time.time - beginTime) / duration;
            if (percent > 1f)
                break;


            transform.position = beginPos + distance * curve.Evaluate(percent);
            yield return null;
        }
        transform.position = endPos;
        Debug.Log("이동완료!");
    }
}
