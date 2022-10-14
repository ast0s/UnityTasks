using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour
{
    void Start()
    {
        Animal animal1 = new Animal();
        Animal animal2 = new Animal();
        Animal animal3 = new Animal();

        int x = Animal.animalCount;
        Debug.Log($"Overall animal count is {x}");
    }
}
