using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee : MonoBehaviour
{

    private int years_of_experience;

    public int YearsOfExperience
    {
        get
        {
            return years_of_experience;
        }
        set
        {
            years_of_experience = value;
        }
    }
}

