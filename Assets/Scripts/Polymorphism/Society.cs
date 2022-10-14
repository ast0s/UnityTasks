using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Society : MonoBehaviour
{
    public void Start()
    {
        Creature myCreature = new Human();
        myCreature.SayHello();  

        Human myHuman = (Human)myCreature;
        myHuman.SayHello();
    }
}
