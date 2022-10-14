using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    void Start()
    {
        transform.ResetTransformation();
        Debug.Log("Transformation has been set to deafult");
    }
}
