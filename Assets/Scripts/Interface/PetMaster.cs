using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMaster : MonoBehaviour
{
    void Start()
    {
        Pet myPet = new Pet();

        Debug.Log("The pet is hungry");

        myPet.GetFed();
    }
}
