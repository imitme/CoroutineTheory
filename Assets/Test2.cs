using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(Function2());
    }

    IEnumerator Function2()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
        }
    }
}
