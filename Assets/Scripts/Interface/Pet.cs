using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour, IFeedable
{
    public void GetFed()
    {
        Debug.Log("You just fed your pet");
    }
}
