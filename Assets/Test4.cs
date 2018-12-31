using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(i);
        }
        yield return new WaitForSeconds(1f);
        StartC();    
    }    

    void StartC()
    {
        Debug.Log("시작!");
    }

    private void Start()
    {
        Debug.Log("스타트 함수 실행!");
    }

}
