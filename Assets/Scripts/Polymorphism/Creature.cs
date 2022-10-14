using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public Creature()
    {
        Debug.Log("1st Creature Constructor Called");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a creature.");
    }
}