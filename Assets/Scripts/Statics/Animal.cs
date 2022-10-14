using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public static int animalCount = 0;

    public Animal()
    {
        animalCount++;
    }
}
