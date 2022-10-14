using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cucumber : Vegetable
{
    public Cucumber()
    {
        taste = "cucumber";
        Debug.Log("1st Cucumber Constructor Called");
    }

    public Cucumber(string newTaste) : base(newTaste)
    {
        Debug.Log("2nd Cucumber Constructor Called");
    }
}
