using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : Mammal
{
    new public void Live()
    {
        Debug.Log("Monkey version of the Live() method");
    }
}
