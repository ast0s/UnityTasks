using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetableSalad : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Creating the vegetable");
        Vegetable myVegetable= new Vegetable();
        Debug.Log("Creating the cucumber");
        Cucumber myCucumber = new Cucumber();

        myVegetable.SayHello();
        myVegetable.Chop();

        myCucumber.SayHello();
        myCucumber.Chop();

        Debug.Log("Creating the vegetable");
        myVegetable = new Vegetable("tomato");
        Debug.Log("Creating the cucumber");
        myCucumber = new Cucumber("pickle");

        myVegetable.SayHello();
        myVegetable.Chop();

        myCucumber.SayHello();
        myCucumber.Chop();
    }
}
