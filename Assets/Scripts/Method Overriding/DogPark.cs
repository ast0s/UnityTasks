using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogPark : MonoBehaviour
{
    void Start()
    {
        LabradorRetriever myLR = new LabradorRetriever();

        myLR.Bark();

        Dog myDog = new LabradorRetriever();
        myDog.Bark();
    }
}
