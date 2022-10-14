using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Creature
{
    public Human()
    {
        Debug.Log("1st Human Constructor Called");
    }
    public new void SayHello()
    {
        Debug.Log("Hello, I am human.");
    }
}
