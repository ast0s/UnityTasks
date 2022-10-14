using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public Dog()
    {
        Debug.Log("1st Dog Constructor Called");
    }

    public virtual void Bark()
    {
        Debug.Log("The dog is barking");
    }
}
