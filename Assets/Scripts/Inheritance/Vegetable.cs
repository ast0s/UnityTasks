using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetable : MonoBehaviour
{
    public string taste;

    public Vegetable()
    {
        taste = "vegetable";
        Debug.Log("1st Vegetable Constructor Called");
    }

    public Vegetable(string newTaste)
    {
        taste = newTaste;
        Debug.Log("2nd Vegetable Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The vegetable tastes like " + taste);
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a vegetable.");
    }
}
