using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
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
        StartCoroutine(Function("First", "Second", "Third"));
    }

    IEnumerator Function(string a, string b, string c)
    {
        yield return new WaitForSeconds(2f);
        Debug.Log(a);
        yield return new WaitForSeconds(2f);
        Debug.Log(b);
        yield return new WaitForSeconds(2f);
        Debug.Log(c);
    }
 
}
