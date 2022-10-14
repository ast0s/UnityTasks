using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolphin : Mammal
{
    new public void Live()
    {
        Debug.Log("Dolphin version of the Live() method");
    }
}
