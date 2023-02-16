using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RethrowError : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            DoSomethingInteresting();
        }

        catch(Exception e)
        {
            Debug.Log(e.Message);
            throw e;
        }
    }

    private void DoSomethingInteresting()
    {
        throw new System.NotImplementedException();
    }
}
