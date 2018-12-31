using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4_1 : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Debug.Log("------------------------------------------"+i);
            for (;Time.time < 7-i ; )
            {
                yield return null;
                Debug.Log(Time.time.ToString());
            }
        }
        yield return new WaitForSeconds(1f);
        StartC();
    }

    void StartC()
    {
        Debug.Log("---------------------------------------------시작!");
    }
}
