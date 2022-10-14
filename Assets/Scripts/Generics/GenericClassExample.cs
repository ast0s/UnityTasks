using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass<int> myClass = new GenericClass<int>();

        myClass.UpdateItem(5);
        Debug.Log(myClass.item);
        myClass.UpdateItem(10);
        Debug.Log(myClass.item);
    }
}
