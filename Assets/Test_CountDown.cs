using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_CountDown : MonoBehaviour
{
    private IEnumerator Start()
    {
        StartCoroutine(CountDown(5f));
        StartCoroutine(CountDown(5f));

        yield return StartCoroutine(CountDown(5f));
        yield return StartCoroutine(CountDown(5f));
        yield return StartCoroutine(CountDown(5f));
        StartCoroutine(CountDownProcess(5f));
    }
    IEnumerator CountDown(float duration)
    {
        //카운트 다운
        //5--4--3--2--1--0--시작;

        //시간을 계산해야 한다!
        var beginTime = Time.time;
        var time = 0f;
        for (; ;)
        {
            time =duration -( Time.time - beginTime);
            if(time >= 0f)
            {
                Debug.Log(time.ToString("0.00"));
            }
            else
            {
                Debug.Log(0.00f);
                break;
            }
            
            yield return null;
        }
        Debug.Log("시작!");
    }
    IEnumerator CountDownProcess(float duration)
    {
        var beginTime = Time.time;
        var time = 0f;
        for (; ; )
        {
            time = duration - (Time.time - beginTime);
            if (time >= 0f)
            {
                transform.position = new Vector3(0f, time, 0f);
            }
            else
            {
                transform.position = new Vector3(0f, 0f, 0f);
                break;
            }

            yield return null;
        }
        Debug.Log("이동완료!");
    }


    public float duration = 3f;
    public float beginY;
    public float endY;
    private float height;
    IEnumerator CountDownProcess2(float duration)
    {
        var beginTime = Time.time;
        var percent = 0f;
        for (; ; )
        {
            percent = (Time.time - beginTime) / duration;
            if (percent > 1f)
                break;

            
            transform.position = new Vector3(0f, beginY + height* percent, 0f);
            yield return null;
        }
        transform.position = new Vector3(0f, endY, 0f);
        Debug.Log("이동완료!");
    }


    public float duration_1 = 3f;
    public float beginY_1;
    Vector3 endY_1;
    private float height_1; 

    IEnumerator CountDownProcess2_1(float duration)
    {
        var beginTime = Time.time;
        var percent = 0f;
        for (; ; )
        {
            percent = (Time.time - beginTime) / duration;
            if (percent > 1f)
                break;


            transform.position = new Vector3(0f, beginY + height * percent, 0f);
            yield return null;
        }
        transform.position = endY_1;
        Debug.Log("이동완료!");
    }


}
