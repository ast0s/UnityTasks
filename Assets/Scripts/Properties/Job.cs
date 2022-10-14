using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    public void Start()
    {
        Employee myEmployee = new Employee();

        myEmployee.YearsOfExperience = 3;

        int e = myEmployee.YearsOfExperience;

        Debug.Log($"Overall experience of this employee is {e} years");
    }
}
