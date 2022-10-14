using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabradorRetriever : Dog
{
    public LabradorRetriever()
    {
        Debug.Log("Labrador retriever Constructor Called");
    }

    public override void Bark()
    {
        base.Bark();
        Debug.Log("The Labrador retriever is barking");
    }
}
