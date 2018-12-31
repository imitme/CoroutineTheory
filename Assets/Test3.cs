using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        StartCoroutine(Function3());
       
    }

    IEnumerator Function3()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("야옹");
        yield return new WaitForSeconds(3f);
        Debug.Log("어흥");
        for (; ; )
        {
            yield return new WaitForSeconds(0.5f);
            Debug.Log("얍");
        }
    }
}
