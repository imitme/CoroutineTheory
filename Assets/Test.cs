using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(ShowTimeProcess());
        StartCoroutine(ShowProcess());
    }

    IEnumerator ShowTimeProcess()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
        }
    }

    IEnumerator ShowProcess()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("야옹");
        yield return new WaitForSeconds(3f);
        Debug.Log("어흥");
        for(; ; )
        {
            yield return new WaitForSeconds(.5f);
            Debug.Log("얍");
        }
        
    }
}

