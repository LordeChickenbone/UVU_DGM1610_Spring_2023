using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBehavior : MonoBehaviour
{
    private Vector3 offScreen = new Vector3(10, 0, 0);
    public void MoveOffScreen()
    {
        transform.position = offScreen;
    }
    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }
}
