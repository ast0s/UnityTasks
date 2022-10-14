using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyingCheck : MonoBehaviour
{
    void Start()
    {
        Multiplying myClass = new Multiplying();

        Debug.Log(myClass.Multiply(7, 2));
        Debug.Log(myClass.Multiply("Hello ", 3));
    }
}
