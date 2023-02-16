using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFromSourceGenerator : MonoBehaviour
{
    static string GetStringFromSourceGenerator()
    {
        return ExampleSourceGenerated.ExampleSourceGenerated.GetTestText();
    }

    // Start is called before the first frame update
    void Start()
    {
        var output = "Test";
        output = GetStringFromSourceGenerator();
        Debug.Log(output);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
