using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion : Mammal
{
    new public void Live()
    {
        Debug.Log("Lion version of the Live() method");
    }
}
