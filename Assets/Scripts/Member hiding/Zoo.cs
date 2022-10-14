using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        Mammal monkey = new Monkey();
        Mammal dolphin = new Dolphin();
        Mammal lion = new Lion();

        monkey.Live();
        dolphin.Live();
        lion.Live();
    }
}
